using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLogin.Interface
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "ISTN3AS";
            txtPassWord.Text = "2023";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="ISTN3AS" && txtPassWord.Text=="2023")
            {
                MessageBox.Show("WELCOME to the MAIN SYSTEM!! ");
                Form frm = (Form)Application.OpenForms["FormMainMenu"];
                MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
                ms.Items["saleMenu"].Enabled = true;
                ms.Items["reportMenu"].Enabled = true;
                ms.Items["searchMenu"].Enabled = true;
                ToolStripMenuItem ti = (ToolStripMenuItem)ms.Items["Access"];
                ti.DropDownItems["logoutMenu"].Enabled = true;
                ti.DropDownItems["loginMenu"].Enabled = false;
                ToolStrip ts = (ToolStrip)frm.Controls["toolstrip1"];
                ts.Items["toolstripLogin"].Enabled = false;
                ts.Items["toolstripSale"].Enabled = true;
                ts.Items["toolstripSearch"].Enabled = true;
                ToolStripTextBox tuser = (ToolStripTextBox)ms.Items["UserNameTxt"];
                tuser.ForeColor = Color.Green;
                tuser.Text = "Logged in as " + txtUserName.Text;
                this.Close();             
            }
        }
    }
}
