using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppLogin.Business;
using WindowsFormsAppLogin.Interface;
using WindowsFormsAppLogin.Search;
using WindowsFormsAppLogin.Reports;

namespace WindowsFormsAppLogin.Interface
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void PrepareForm(Form f)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            //PB_UKZN.SendToBack();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            PrepareForm(login);
            
        }

        private void sale1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSale1 frmSale1 = new FormSale1();
            PrepareForm(frmSale1);
           
        }

        private void FormMainMenu_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                PB_UKZN.SendToBack();
            else
                PB_UKZN.BringToFront();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            loginMenu.Enabled = true;
            logoutMenu.Enabled = false;
            saleMenu.Enabled = false;
            reportMenu.Enabled = false;
            searchMenu.Enabled = false;
            toolstripSale.Enabled = false;
            toolstripSearch.Enabled = false;
            toolstripLogin.Enabled = true;
            UserNameTxt.ForeColor = Color.Red;
            UserNameTxt.Text = "Logged Out";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            PrepareForm(login);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormSale1 frmSale1 = new FormSale1();
            PrepareForm(frmSale1);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            PrepareForm(sf);
        }

        private void report1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            PrepareForm(rf);
        }
    }
}
