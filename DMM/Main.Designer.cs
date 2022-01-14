
namespace DMM
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pn_container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btn_home = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_suppliers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_customers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_reports = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_analysis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_users = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_settings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_about = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.txt_username = new DevExpress.XtraBars.BarStaticItem();
            this.txt_role = new DevExpress.XtraBars.BarStaticItem();
            this.btn_logout = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_container
            // 
            this.pn_container.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.pn_container.Appearance.Options.UseBackColor = true;
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Font = new System.Drawing.Font("Calisto MT", 10F);
            this.pn_container.Location = new System.Drawing.Point(198, 29);
            this.pn_container.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(872, 686);
            this.pn_container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_home,
            this.btn_suppliers,
            this.btn_customers,
            this.btn_reports,
            this.btn_analysis,
            this.btn_users,
            this.btn_settings,
            this.btn_about});
            this.accordionControl1.Location = new System.Drawing.Point(0, 29);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(198, 686);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btn_home
            // 
            this.btn_home.Appearance.Hovered.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Appearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btn_home.Appearance.Hovered.Options.UseFont = true;
            this.btn_home.Appearance.Hovered.Options.UseForeColor = true;
            this.btn_home.Appearance.Normal.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Appearance.Normal.Options.UseFont = true;
            this.btn_home.Appearance.Pressed.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Appearance.Pressed.Options.UseFont = true;
            this.btn_home.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.ImageOptions.Image")));
            this.btn_home.Name = "btn_home";
            this.btn_home.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_home.Text = "Home";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_suppliers
            // 
            this.btn_suppliers.Appearance.Hovered.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppliers.Appearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btn_suppliers.Appearance.Hovered.Options.UseFont = true;
            this.btn_suppliers.Appearance.Hovered.Options.UseForeColor = true;
            this.btn_suppliers.Appearance.Normal.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppliers.Appearance.Normal.Options.UseFont = true;
            this.btn_suppliers.Appearance.Pressed.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppliers.Appearance.Pressed.Options.UseFont = true;
            this.btn_suppliers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_suppliers.ImageOptions.Image")));
            this.btn_suppliers.Name = "btn_suppliers";
            this.btn_suppliers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_suppliers.Text = "Suppliers";
            this.btn_suppliers.Click += new System.EventHandler(this.btn_suppliers_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Appearance.Hovered.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.Appearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btn_customers.Appearance.Hovered.Options.UseFont = true;
            this.btn_customers.Appearance.Hovered.Options.UseForeColor = true;
            this.btn_customers.Appearance.Normal.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.Appearance.Normal.Options.UseFont = true;
            this.btn_customers.Appearance.Pressed.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.Appearance.Pressed.Options.UseFont = true;
            this.btn_customers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_customers.ImageOptions.Image")));
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_customers.Text = "Customers";
            // 
            // btn_reports
            // 
            this.btn_reports.Appearance.Hovered.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.Appearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btn_reports.Appearance.Hovered.Options.UseFont = true;
            this.btn_reports.Appearance.Hovered.Options.UseForeColor = true;
            this.btn_reports.Appearance.Normal.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.Appearance.Normal.Options.UseFont = true;
            this.btn_reports.Appearance.Pressed.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.Appearance.Pressed.Options.UseFont = true;
            this.btn_reports.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_reports.ImageOptions.Image")));
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_reports.Text = "Reports";
            // 
            // btn_analysis
            // 
            this.btn_analysis.Appearance.Hovered.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analysis.Appearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btn_analysis.Appearance.Hovered.Options.UseFont = true;
            this.btn_analysis.Appearance.Hovered.Options.UseForeColor = true;
            this.btn_analysis.Appearance.Normal.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analysis.Appearance.Normal.Options.UseFont = true;
            this.btn_analysis.Appearance.Pressed.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analysis.Appearance.Pressed.Options.UseFont = true;
            this.btn_analysis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_analysis.ImageOptions.Image")));
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_analysis.Text = "Analysis";
            // 
            // btn_users
            // 
            this.btn_users.Appearance.Hovered.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Appearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btn_users.Appearance.Hovered.Options.UseFont = true;
            this.btn_users.Appearance.Hovered.Options.UseForeColor = true;
            this.btn_users.Appearance.Normal.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Appearance.Normal.Options.UseFont = true;
            this.btn_users.Appearance.Pressed.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Appearance.Pressed.Options.UseFont = true;
            this.btn_users.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_users.ImageOptions.Image")));
            this.btn_users.Name = "btn_users";
            this.btn_users.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_users.Text = "Users";
            // 
            // btn_settings
            // 
            this.btn_settings.Appearance.Hovered.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Appearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btn_settings.Appearance.Hovered.Options.UseFont = true;
            this.btn_settings.Appearance.Hovered.Options.UseForeColor = true;
            this.btn_settings.Appearance.Normal.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Appearance.Normal.Options.UseFont = true;
            this.btn_settings.Appearance.Pressed.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Appearance.Pressed.Options.UseFont = true;
            this.btn_settings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.ImageOptions.Image")));
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_settings.Text = "Settings";
            // 
            // btn_about
            // 
            this.btn_about.Appearance.Hovered.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.Appearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btn_about.Appearance.Hovered.Options.UseFont = true;
            this.btn_about.Appearance.Hovered.Options.UseForeColor = true;
            this.btn_about.Appearance.Normal.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.Appearance.Normal.Options.UseFont = true;
            this.btn_about.Appearance.Pressed.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.Appearance.Pressed.Options.UseFont = true;
            this.btn_about.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_about.ImageOptions.Image")));
            this.btn_about.Name = "btn_about";
            this.btn_about.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_about.Text = "About";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.txt_username,
            this.txt_role,
            this.btn_logout});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1070, 29);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.txt_username);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.txt_role);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.btn_logout);
            // 
            // txt_username
            // 
            this.txt_username.Caption = "June Nouh";
            this.txt_username.Id = 0;
            this.txt_username.Name = "txt_username";
            // 
            // txt_role
            // 
            this.txt_role.Caption = "Admin";
            this.txt_role.Id = 1;
            this.txt_role.Name = "txt_role";
            // 
            // btn_logout
            // 
            this.btn_logout.Caption = "Logout";
            this.btn_logout.Id = 2;
            this.btn_logout.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.btn_logout.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btn_logout.Name = "btn_logout";
            // 
            // Main
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 715);
            this.ControlContainer = this.pn_container;
            this.Controls.Add(this.pn_container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.NavigationControl = this.accordionControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMM";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer pn_container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_home;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_suppliers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_customers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_reports;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_analysis;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_users;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_settings;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_about;
        private DevExpress.XtraBars.BarStaticItem txt_username;
        private DevExpress.XtraBars.BarStaticItem txt_role;
        private DevExpress.XtraBars.BarButtonItem btn_logout;
    }
}

