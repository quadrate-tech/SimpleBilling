﻿using SimpleBilling.Model;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SimpleBilling.MasterForms
{
    public partial class ManageBanks : Form
    {
        public ManageBanks()
        {
            InitializeComponent();
        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CRUDPanel.Enabled = true;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
            TxtBankName.Text = string.Empty;
            TxtBankId.Text = "0";
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            CRUDPanel.Enabled = true;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CRUDPanel.Enabled = false;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            BtnAdd.Enabled = true;
            if(Info.UserType != 3)BtnEdit.Enabled = true;
        }

        private void DGVBanks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVBanks.SelectedRows.Count > 0)
            {
                TxtBankId.Text = DGVBanks.SelectedRows[0].Cells[0].Value + string.Empty;
                TxtBankName.Text = DGVBanks.SelectedRows[0].Cells[1].Value + string.Empty;
                if(Info.UserType != 3)BtnDelete.Enabled = true;
            }
        }

        private void ManageBanks_Load(object sender, EventArgs e)
        {
            DGVLoad();
        }

        private void DGVLoad()
        {
            CRUDPanel.Enabled = false;
            BtnDelete.Enabled = false;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            BtnAdd.Enabled = true;
            if(Info.UserType != 3)
                BtnEdit.Enabled = true;
            using (BillingContext db = new BillingContext())
            {
                var data = (from bank in db.Banks.Where(c => !c.IsDeleted)
                            select new
                            {
                                bank.BankId,
                                bank.BankName
                            }).ToList();
                DGVBanks.DataSource = data;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                using (BillingContext db = new BillingContext())
                {
                    if (TxtBankId.Text.Length > 0)
                    {
                        if (TxtBankId.Text == "0" && Info.IsEmpty(TxtBankName))
                        {
                            Bank b = new Bank
                            {
                                BankName = TxtBankName.Text.Trim()
                            };
                            if (db.Entry(b).State == EntityState.Detached)
                                db.Set<Bank>().Attach(b);
                            db.Entry(b).State = EntityState.Added;
                            db.SaveChanges();
                            TxtBankName.Text = string.Empty;
                        }
                        else if (Info.IsEmpty(TxtBankName) && Info.IsEmpty(TxtBankId) && TxtBankId.Text.Trim() != "0")
                        {
                            var b = db.Banks.FirstOrDefault(c => c.BankId == Convert.ToInt32(TxtBankId.Text.Trim()) && !c.IsDeleted);
                            if (b != null)
                            {
                                b.BankName = TxtBankName.Text.Trim();
                                if (db.Entry(b).State == EntityState.Detached)
                                    db.Set<Bank>().Attach(b);
                                db.Entry(b).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExportJson.Add(ex); Info.Mes(ex.Message);
            }
            finally
            {
                DGVLoad();
                BtnSave.Enabled = false;
                BtnCancel.Enabled = false;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int BankId = Convert.ToInt32(TxtBankId.Text.Trim());
                using (BillingContext db = new BillingContext())
                {
                    if (DGVBanks.SelectedRows.Count > 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected Bank?", "Confirmation delete", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes && Info.IsEmpty(TxtBankId) && TxtBankId.Text.Trim() != "0")
                        {
                            var b = db.Banks.FirstOrDefault(c => c.BankId == BankId && !c.IsDeleted);
                            if (b != null)
                            {
                                b.IsDeleted = true;
                                if (db.Entry(b).State == EntityState.Detached)
                                    db.Set<Bank>().Attach(b);
                                db.Entry(b).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExportJson.Add(ex); Info.Mes(ex.Message);
            }
            finally
            {
                DGVLoad();
                BtnSave.Enabled = false;
                BtnCancel.Enabled = false;
            }
        }

        private void TxtBankName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }

        private void TxtBankName_KeyUp(object sender, KeyEventArgs e)
        {
            Info.ToCapital(TxtBankName);
        }
    }
}