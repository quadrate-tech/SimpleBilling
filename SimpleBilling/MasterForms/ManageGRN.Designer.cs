﻿namespace SimpleBilling.MasterForms
{
    partial class ManageGRN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DGVGRNList = new System.Windows.Forms.DataGridView();
            this.gRNDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CRUDPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.CmbProduct = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUnitCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDiscount = new System.Windows.Forms.TextBox();
            this.CMBSupplier = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtReference = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtGRNNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.LblMessage = new System.Windows.Forms.Label();
            this.MessageTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnComplete = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblGrossTotal = new System.Windows.Forms.Label();
            this.LblTotalDiscount = new System.Windows.Forms.Label();
            this.LblNetTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnApprove = new System.Windows.Forms.Button();
            this.BtnLoadInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGRNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRNDetailsBindingSource)).BeginInit();
            this.CRUDPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVGRNList
            // 
            this.DGVGRNList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVGRNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGRNList.Location = new System.Drawing.Point(6, 130);
            this.DGVGRNList.Name = "DGVGRNList";
            this.DGVGRNList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVGRNList.Size = new System.Drawing.Size(899, 224);
            this.DGVGRNList.TabIndex = 0;
            this.DGVGRNList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGRNList_CellClick);
            // 
            // gRNDetailsBindingSource
            // 
            this.gRNDetailsBindingSource.DataSource = typeof(SimpleBilling.Model.GRNDetail);
            // 
            // CRUDPanel
            // 
            this.CRUDPanel.Controls.Add(this.tableLayoutPanel1);
            this.CRUDPanel.Location = new System.Drawing.Point(-4, 0);
            this.CRUDPanel.Name = "CRUDPanel";
            this.CRUDPanel.Size = new System.Drawing.Size(909, 110);
            this.CRUDPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddItem, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.CmbProduct, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtQuantity, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtUnitCost, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtDiscount, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.CMBSupplier, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.DTPDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtReference, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtGRNNo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblStatus, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.23932F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.64103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.65812F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.17094F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(903, 117);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product";
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.BackColor = System.Drawing.Color.White;
            this.BtnAddItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddItem.Location = new System.Drawing.Point(723, 72);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(174, 26);
            this.BtnAddItem.TabIndex = 15;
            this.BtnAddItem.Text = "Add Item";
            this.BtnAddItem.UseVisualStyleBackColor = false;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // CmbProduct
            // 
            this.CmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbProduct.DataSource = this.itemBindingSource;
            this.CmbProduct.DisplayMember = "ItemName";
            this.CmbProduct.FormattingEnabled = true;
            this.CmbProduct.Location = new System.Drawing.Point(3, 72);
            this.CmbProduct.Name = "CmbProduct";
            this.CmbProduct.Size = new System.Drawing.Size(174, 27);
            this.CmbProduct.TabIndex = 9;
            this.CmbProduct.ValueMember = "Id";
            this.CmbProduct.SelectedIndexChanged += new System.EventHandler(this.CmbProduct_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(SimpleBilling.Model.Item);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(183, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(183, 72);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(174, 26);
            this.TxtQuantity.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(363, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unit Cost";
            // 
            // TxtUnitCost
            // 
            this.TxtUnitCost.Location = new System.Drawing.Point(363, 72);
            this.TxtUnitCost.Name = "TxtUnitCost";
            this.TxtUnitCost.Size = new System.Drawing.Size(174, 26);
            this.TxtUnitCost.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(543, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Discount";
            // 
            // TxtDiscount
            // 
            this.TxtDiscount.Location = new System.Drawing.Point(543, 72);
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.Size = new System.Drawing.Size(174, 26);
            this.TxtDiscount.TabIndex = 5;
            // 
            // CMBSupplier
            // 
            this.CMBSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBSupplier.DataSource = this.supplierBindingSource;
            this.CMBSupplier.DisplayMember = "Name";
            this.CMBSupplier.FormattingEnabled = true;
            this.CMBSupplier.Location = new System.Drawing.Point(543, 21);
            this.CMBSupplier.Name = "CMBSupplier";
            this.CMBSupplier.Size = new System.Drawing.Size(174, 27);
            this.CMBSupplier.TabIndex = 13;
            this.CMBSupplier.ValueMember = "SupplierId";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(SimpleBilling.Model.Supplier);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(543, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Supplier";
            // 
            // DTPDate
            // 
            this.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDate.Location = new System.Drawing.Point(363, 21);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Size = new System.Drawing.Size(174, 26);
            this.DTPDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(363, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // TxtReference
            // 
            this.TxtReference.Location = new System.Drawing.Point(183, 21);
            this.TxtReference.Name = "TxtReference";
            this.TxtReference.Size = new System.Drawing.Size(174, 26);
            this.TxtReference.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(183, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reference No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "GRN No";
            // 
            // TxtGRNNo
            // 
            this.TxtGRNNo.Location = new System.Drawing.Point(3, 21);
            this.TxtGRNNo.Name = "TxtGRNNo";
            this.TxtGRNNo.Size = new System.Drawing.Size(174, 26);
            this.TxtGRNNo.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(723, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "Status";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.ForeColor = System.Drawing.Color.Yellow;
            this.LblStatus.Location = new System.Drawing.Point(723, 18);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(117, 19);
            this.LblStatus.TabIndex = 20;
            this.LblStatus.Text = "Invoice Status";
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataSource = typeof(SimpleBilling.Model.Item);
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.ForeColor = System.Drawing.Color.Lime;
            this.LblMessage.Location = new System.Drawing.Point(12, 435);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(54, 19);
            this.LblMessage.TabIndex = 2;
            this.LblMessage.Text = "label8";
            // 
            // MessageTimer
            // 
            this.MessageTimer.Enabled = true;
            this.MessageTimer.Interval = 10000;
            this.MessageTimer.Tick += new System.EventHandler(this.MessageTimer_Tick);
            // 
            // BtnComplete
            // 
            this.BtnComplete.BackColor = System.Drawing.Color.White;
            this.BtnComplete.Location = new System.Drawing.Point(3, 351);
            this.BtnComplete.Name = "BtnComplete";
            this.BtnComplete.Size = new System.Drawing.Size(84, 52);
            this.BtnComplete.TabIndex = 3;
            this.BtnComplete.Text = "Done";
            this.BtnComplete.UseVisualStyleBackColor = false;
            this.BtnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.76731F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.23269F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.LblGrossTotal, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblTotalDiscount, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblNetTotal, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(586, 360);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(318, 72);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Gross Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Total Discount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Net Total";
            // 
            // LblGrossTotal
            // 
            this.LblGrossTotal.AutoSize = true;
            this.LblGrossTotal.Location = new System.Drawing.Point(142, 1);
            this.LblGrossTotal.Name = "LblGrossTotal";
            this.LblGrossTotal.Size = new System.Drawing.Size(18, 19);
            this.LblGrossTotal.TabIndex = 3;
            this.LblGrossTotal.Text = "0";
            // 
            // LblTotalDiscount
            // 
            this.LblTotalDiscount.AutoSize = true;
            this.LblTotalDiscount.Location = new System.Drawing.Point(142, 24);
            this.LblTotalDiscount.Name = "LblTotalDiscount";
            this.LblTotalDiscount.Size = new System.Drawing.Size(18, 19);
            this.LblTotalDiscount.TabIndex = 4;
            this.LblTotalDiscount.Text = "0";
            // 
            // LblNetTotal
            // 
            this.LblNetTotal.AutoSize = true;
            this.LblNetTotal.Location = new System.Drawing.Point(142, 47);
            this.LblNetTotal.Name = "LblNetTotal";
            this.LblNetTotal.Size = new System.Drawing.Size(18, 19);
            this.LblNetTotal.TabIndex = 5;
            this.LblNetTotal.Text = "0";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.BtnComplete, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.BtnDelete, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.BtnApprove, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.BtnLoadInvoice, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(912, 13);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(90, 413);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(3, 119);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(84, 52);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnApprove
            // 
            this.BtnApprove.BackColor = System.Drawing.Color.White;
            this.BtnApprove.Location = new System.Drawing.Point(3, 293);
            this.BtnApprove.Name = "BtnApprove";
            this.BtnApprove.Size = new System.Drawing.Size(84, 52);
            this.BtnApprove.TabIndex = 17;
            this.BtnApprove.Text = "Approve";
            this.BtnApprove.UseVisualStyleBackColor = false;
            this.BtnApprove.Click += new System.EventHandler(this.BtnApprove_Click);
            // 
            // BtnLoadInvoice
            // 
            this.BtnLoadInvoice.BackColor = System.Drawing.Color.White;
            this.BtnLoadInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLoadInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnLoadInvoice.FlatAppearance.BorderSize = 0;
            this.BtnLoadInvoice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnLoadInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnLoadInvoice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadInvoice.Location = new System.Drawing.Point(3, 61);
            this.BtnLoadInvoice.Name = "BtnLoadInvoice";
            this.BtnLoadInvoice.Size = new System.Drawing.Size(84, 50);
            this.BtnLoadInvoice.TabIndex = 15;
            this.BtnLoadInvoice.Text = "Load Invoice";
            this.BtnLoadInvoice.UseVisualStyleBackColor = false;
            this.BtnLoadInvoice.Click += new System.EventHandler(this.BtnLoadInvoice_Click);
            // 
            // ManageGRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1015, 502);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.CRUDPanel);
            this.Controls.Add(this.DGVGRNList);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ManageGRN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Good Received Note";
            this.Load += new System.EventHandler(this.ManageGRN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGRNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRNDetailsBindingSource)).EndInit();
            this.CRUDPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVGRNList;
        private System.Windows.Forms.Panel CRUDPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.TextBox TxtReference;
        private System.Windows.Forms.ComboBox CmbProduct;
        private System.Windows.Forms.TextBox TxtUnitCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CMBSupplier;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDiscount;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Timer MessageTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtGRNNo;
        private System.Windows.Forms.BindingSource gRNDetailsBindingSource;
        private System.Windows.Forms.Button BtnComplete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblGrossTotal;
        private System.Windows.Forms.Label LblTotalDiscount;
        private System.Windows.Forms.Label LblNetTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnLoadInvoice;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button BtnApprove;
    }
}