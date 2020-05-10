﻿using SimpleBilling.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SimpleBilling.MasterForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TxtLogin.Focus();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                CashierLogin();
            }
            catch (Exception ex)
            {
                Info.Mes(ex.Message);
            }
        }

        private void CashierLogin()
        {
            using (BillingContext db = new BillingContext())
            {
                if (Info.IsEmpty(TxtLogin))
                {
                    var data = db.Employee.FirstOrDefault(c => c.SecretCode == TxtLogin.Text.Trim());
                    if (data != null)
                    {
                        Main m = new Main();
                        m.Show();
                        Hide();
                        Info.CashierId = data.EmployeeId;
                    }
                }
            }
        }

        private void TxtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CashierLogin();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdminExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}