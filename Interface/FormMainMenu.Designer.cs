
namespace WindowsFormsAppLogin.Interface
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Access = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sale1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sale2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.report1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstripLogin = new System.Windows.Forms.ToolStripButton();
            this.toolstripSale = new System.Windows.Forms.ToolStripButton();
            this.toolstripSearch = new System.Windows.Forms.ToolStripButton();
            this.PB_UKZN = new System.Windows.Forms.PictureBox();
            this.UserNameTxt = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UKZN)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Access,
            this.saleMenu,
            this.reportMenu,
            this.searchMenu,
            this.UserNameTxt});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1400, 44);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Access
            // 
            this.Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginMenu,
            this.logoutMenu,
            this.exitToolStripMenuItem});
            this.Access.Name = "Access";
            this.Access.Size = new System.Drawing.Size(188, 36);
            this.Access.Text = "Access_Control";
            // 
            // loginMenu
            // 
            this.loginMenu.Image = ((System.Drawing.Image)(resources.GetObject("loginMenu.Image")));
            this.loginMenu.Name = "loginMenu";
            this.loginMenu.Size = new System.Drawing.Size(224, 36);
            this.loginMenu.Text = "Login";
            this.loginMenu.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutMenu
            // 
            this.logoutMenu.Enabled = false;
            this.logoutMenu.Image = ((System.Drawing.Image)(resources.GetObject("logoutMenu.Image")));
            this.logoutMenu.Name = "logoutMenu";
            this.logoutMenu.Size = new System.Drawing.Size(224, 36);
            this.logoutMenu.Text = "Logout";
            this.logoutMenu.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saleMenu
            // 
            this.saleMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sale1ToolStripMenuItem,
            this.sale2ToolStripMenuItem});
            this.saleMenu.Enabled = false;
            this.saleMenu.Name = "saleMenu";
            this.saleMenu.Size = new System.Drawing.Size(73, 36);
            this.saleMenu.Text = "Sale";
            // 
            // sale1ToolStripMenuItem
            // 
            this.sale1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sale1ToolStripMenuItem.Image")));
            this.sale1ToolStripMenuItem.Name = "sale1ToolStripMenuItem";
            this.sale1ToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.sale1ToolStripMenuItem.Text = "Sale 1";
            this.sale1ToolStripMenuItem.Click += new System.EventHandler(this.sale1ToolStripMenuItem_Click);
            // 
            // sale2ToolStripMenuItem
            // 
            this.sale2ToolStripMenuItem.Name = "sale2ToolStripMenuItem";
            this.sale2ToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.sale2ToolStripMenuItem.Text = "Sale 2";
            // 
            // reportMenu
            // 
            this.reportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.report1ToolStripMenuItem,
            this.report2ToolStripMenuItem});
            this.reportMenu.Enabled = false;
            this.reportMenu.Name = "reportMenu";
            this.reportMenu.Size = new System.Drawing.Size(109, 36);
            this.reportMenu.Text = "Reports";
            // 
            // report1ToolStripMenuItem
            // 
            this.report1ToolStripMenuItem.Name = "report1ToolStripMenuItem";
            this.report1ToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.report1ToolStripMenuItem.Text = "Report1";
            this.report1ToolStripMenuItem.Click += new System.EventHandler(this.report1ToolStripMenuItem_Click);
            // 
            // report2ToolStripMenuItem
            // 
            this.report2ToolStripMenuItem.Name = "report2ToolStripMenuItem";
            this.report2ToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.report2ToolStripMenuItem.Text = "Report2";
            // 
            // searchMenu
            // 
            this.searchMenu.Enabled = false;
            this.searchMenu.Name = "searchMenu";
            this.searchMenu.Size = new System.Drawing.Size(100, 36);
            this.searchMenu.Text = "Search";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripLogin,
            this.toolstripSale,
            this.toolstripSearch});
            this.toolStrip1.Location = new System.Drawing.Point(1170, 44);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(230, 772);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolstripLogin
            // 
            this.toolstripLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripLogin.Image = ((System.Drawing.Image)(resources.GetObject("toolstripLogin.Image")));
            this.toolstripLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripLogin.Name = "toolstripLogin";
            this.toolstripLogin.Size = new System.Drawing.Size(227, 229);
            this.toolstripLogin.Text = "toolStripButton1";
            this.toolstripLogin.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolstripSale
            // 
            this.toolstripSale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripSale.Enabled = false;
            this.toolstripSale.Image = ((System.Drawing.Image)(resources.GetObject("toolstripSale.Image")));
            this.toolstripSale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripSale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripSale.Name = "toolstripSale";
            this.toolstripSale.Size = new System.Drawing.Size(227, 208);
            this.toolstripSale.Text = "toolStripButton2";
            this.toolstripSale.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolstripSearch
            // 
            this.toolstripSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripSearch.Enabled = false;
            this.toolstripSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolstripSearch.Image")));
            this.toolstripSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripSearch.Name = "toolstripSearch";
            this.toolstripSearch.Size = new System.Drawing.Size(227, 229);
            this.toolstripSearch.Text = "toolStripButton3";
            this.toolstripSearch.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // PB_UKZN
            // 
            this.PB_UKZN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_UKZN.Image = global::WindowsFormsAppLogin.Properties.Resources.UKZN;
            this.PB_UKZN.Location = new System.Drawing.Point(280, 204);
            this.PB_UKZN.Name = "PB_UKZN";
            this.PB_UKZN.Size = new System.Drawing.Size(712, 227);
            this.PB_UKZN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_UKZN.TabIndex = 7;
            this.PB_UKZN.TabStop = false;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.UserNameTxt.ForeColor = System.Drawing.Color.Red;
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(200, 36);
            this.UserNameTxt.Text = "Logged Out";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.Controls.Add(this.PB_UKZN);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.MdiChildActivate += new System.EventHandler(this.FormMainMenu_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UKZN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Access;
        private System.Windows.Forms.ToolStripMenuItem loginMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleMenu;
        private System.Windows.Forms.ToolStripMenuItem sale1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sale2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportMenu;
        private System.Windows.Forms.ToolStripMenuItem report1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem report2ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolstripLogin;
        private System.Windows.Forms.ToolStripButton toolstripSale;
        private System.Windows.Forms.ToolStripButton toolstripSearch;
        private System.Windows.Forms.PictureBox PB_UKZN;
        private System.Windows.Forms.ToolStripMenuItem searchMenu;
        private System.Windows.Forms.ToolStripTextBox UserNameTxt;
    }
}