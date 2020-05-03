﻿using System;
using SimpleBilling.Model;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;

namespace SimpleBilling.MasterForms
{
    public partial class ManageItems : Form
    {
        public ManageItems()
        {
            InitializeComponent();
        }

        private void ManageItems_Load(object sender, EventArgs e)
        {
            PanelCRUD.Enabled = false;
            BtnCancel.Enabled = false;
            LblMessage.Text = string.Empty;
            LoadDGV();
            DGVItems_CellClick(sender, e as DataGridViewCellEventArgs);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PanelCRUD.Enabled = true;
            BtnCancel.Enabled = true;
            BtnSave.Enabled = true;
            TxtItemId.Text = "0";
            TxtItemCode.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PanelCRUD.Enabled = true;
            BtnCancel.Enabled = true;
            TxtItemCode.Focus();
            BtnSave.Enabled = true;
        }

        private void ItemCRUD()
        {
            using (BillingContext db = new BillingContext())
            {
                int CatId = Convert.ToInt32(CmbCategories.SelectedValue.ToString());
                int ShelveId = Convert.ToInt32(CmbShelf.SelectedValue.ToString());
                Category cat = db.Categories.FirstOrDefault(s => s.CategoryId == CatId);
                Shelf shelve = db.Shelves.FirstOrDefault(c => c.ShelfId == ShelveId);
                if (Info.IsEmpty(TxtItemId) && Info.IsEmpty(TxtUnitCost))
                {
                    Item items = new Item
                    {
                        Id = Convert.ToInt32(TxtItemId.Text.Trim()),
                        Code = TxtItemCode.Text.Trim(),
                        ItemName = TxtItemName.Text.Trim(),
                        Unit = TxtUnit.Text.Trim(),
                        UnitCost = Convert.ToSingle(TxtUnitCost.Text.Trim()),
                        Barcode = TxtBarcode.Text.Trim(),
                        Categories = cat,
                        IsService = GetIsService()
                    };

 
                    if (items.Id == 0)
                    {
                        if (db.Entry(items).State == EntityState.Detached)
                            db.Set<Item>().Attach(items);
                        db.Entry(items).State = EntityState.Added;
                        items.CreatedDate = DateTime.Today;
                        db.SaveChanges();
                        Info.Mes("Item Added Successfully");                   
                    }
                
                    else
                    {
                        var result = db.Items.SingleOrDefault(b => b.Id == items.Id);
                        if (result != null)
                        {
                            result.Code= TxtItemCode.Text.Trim();
                            result.ItemName = TxtItemName.Text.Trim();
                            result.Unit = TxtUnit.Text.Trim();
                            result.UnitCost = Convert.ToSingle(TxtUnitCost.Text.Trim());
                            result.Barcode = TxtBarcode.Text.Trim();
                            result.Categories = cat;
                            result.IsService = GetIsService();
                            if (db.Entry(result).State == EntityState.Detached)
                                db.Set<Item>().Attach(result);
                            result.UpdatedDate = DateTime.Now;
                            db.Entry(result).State = EntityState.Modified;
                            db.SaveChanges();
                            Info.Mes("Item Modified Successfully");
                        }                   
                    }
                }
            }
        }

        private bool GetIsService()
        {
            if (ChkBoxIsService.Checked == true)
                return true;
            else
                return false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ItemCRUD();
            }
            catch (Exception ex)
            {
                Info.Mes(ex.Message.ToString());
            }
            finally 
            {
                PanelCRUD.Enabled = false;
                BtnCancel.Enabled = false;
                BtnSave.Enabled = false;
                DGVItems.Refresh();
                LoadDGV();
                int lastRow = DGVItems.Rows.Count;
                DGVItems.CurrentCell = DGVItems.Rows[lastRow - 1].Cells[0];
            }
        }

        private void LoadDGV()
        {
            using (BillingContext db = new BillingContext())
            {
                var data = (from item in db.Items.Where(c=>c.IsDeleted==false)
                            join cat in db.Categories
                            on item.Categories.CategoryId equals cat.CategoryId
                            join shelve in db.Shelves
                            on item.Shelfs.ShelfId equals shelve.ShelfId
                            select new
                            {
                                item.Id,
                                item.Code,
                                item.ItemName,
                                item.Unit,
                                item.UnitCost,
                                item.Barcode,
                                item.Categories.CategoryName,
                                item.Shelfs.ShelfName
                            }).ToList();
                DGVItems.DataSource = data;

                CmbCategories.ValueMember = "CategoryId";
                CmbCategories.DisplayMember = "CategoryName";
                CmbCategories.DataSource = db.Categories.ToList();

                CmbShelf.ValueMember = "ShelfId";
                CmbShelf.DisplayMember = "ShelfName";
                CmbShelf.DataSource = db.Shelves.ToList();
            }
        }

        private void TimerMessage_Tick(object sender, EventArgs e)
        {
            LblMessage.Text = string.Empty;
        }

        private void DGVItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = DGVItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)DGVItems.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)DGVItems.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void DGVItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVItems.SelectedRows.Count > 0)
            {
                TxtItemId.Text = DGVItems.SelectedRows[0].Cells[0].Value + string.Empty;
                int Id = Convert.ToInt32(TxtItemId.Text.Trim());
                TxtItemCode.Text = DGVItems.SelectedRows[0].Cells[1].Value + string.Empty;
                TxtItemName.Text = DGVItems.SelectedRows[0].Cells[2].Value + string.Empty;
                TxtUnit.Text = DGVItems.SelectedRows[0].Cells[3].Value + string.Empty;
                TxtUnitCost.Text = DGVItems.SelectedRows[0].Cells[4].Value + string.Empty;
                TxtBarcode.Text = DGVItems.SelectedRows[0].Cells[5].Value + string.Empty;
                CmbCategories.Text = DGVItems.SelectedRows[0].Cells[6].Value + string.Empty;
                CmbShelf.Text = DGVItems.SelectedRows[0].Cells[7].Value + string.Empty;
                using (BillingContext db = new BillingContext()) 
                {
                    var item = db.Items.FirstOrDefault(c => c.Id == Id);
                    if(item.IsService == true) ChkBoxIsService.Checked = true; else ChkBoxIsService.Checked = false;
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PanelCRUD.Enabled = false;
            BtnCancel.Enabled = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected Item?", "Confirmation delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (BillingContext db = new BillingContext())
                    {
                        int Id = Convert.ToInt32(TxtItemId.Text.Trim().ToString());
                        Item items = db.Items.FirstOrDefault(s => s.Id == Id);

                        if (items != null)
                        {
                            items.IsDeleted = true;
                            items.UpdatedDate = DateTime.Now;
                            db.Entry(items).State = EntityState.Modified;
                            items.UpdatedDate = DateTime.Now;
                            db.SaveChanges();
                            Info.Mes("Item Deleted Successfully");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Info.Mes(ex.ToString());
            }
            finally
            {
                DGVItems.Refresh();
                LoadDGV();
            }
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ManageCategory))
                {
                    form.Activate();
                    return;
                }
            }

            ManageCategory manageCategory = new ManageCategory();
            manageCategory.Show();
            Hide();
        }

        private void BtnAddShelf_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ManageShelves))
                {
                    form.Activate();
                    return;
                }
            }

            ManageShelves manageShelve = new ManageShelves();
            manageShelve.Show();
            Hide();
        }
    }
}
