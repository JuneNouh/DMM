﻿
namespace DMM.AddPage
{
    partial class Add_Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Supplier));
            this.label1 = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_address = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addclose = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Name";
            // 
            // edt_name
            // 
            this.edt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_name.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(471, 210);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(378, 40);
            this.edt_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone Number";
            // 
            // edt_phone
            // 
            this.edt_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_phone.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_phone.Location = new System.Drawing.Point(471, 301);
            this.edt_phone.Name = "edt_phone";
            this.edt_phone.Size = new System.Drawing.Size(378, 40);
            this.edt_phone.TabIndex = 2;
            this.edt_phone.TextChanged += new System.EventHandler(this.edt_phone_TextChanged);
            this.edt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edt_phone_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // edt_address
            // 
            this.edt_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_address.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_address.Location = new System.Drawing.Point(471, 404);
            this.edt_address.Name = "edt_address";
            this.edt_address.Size = new System.Drawing.Size(378, 40);
            this.edt_address.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_addclose);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 701);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 100);
            this.panel1.TabIndex = 2;
            // 
            // btn_addclose
            // 
            this.btn_addclose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_addclose.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addclose.Appearance.Options.UseFont = true;
            this.btn_addclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_addclose.ImageOptions.Image")));
            this.btn_addclose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_addclose.Location = new System.Drawing.Point(801, 24);
            this.btn_addclose.Name = "btn_addclose";
            this.btn_addclose.Size = new System.Drawing.Size(177, 50);
            this.btn_addclose.TabIndex = 5;
            this.btn_addclose.Text = "Add and  Close";
            this.btn_addclose.Click += new System.EventHandler(this.btn_addclose_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_add.Location = new System.Drawing.Point(254, 24);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 50);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "5dfa77dc-b34f-468d-afcf-30d985a591ae";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("1ef882dc-2b02-4898-8238-d4cc9b99e224", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "Added Successfully", "Added Successfully", "Added Successfully", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // Add_Supplier
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 801);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.edt_address);
            this.Controls.Add(this.edt_phone);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Supplier";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Supplier";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox edt_name;
        public System.Windows.Forms.TextBox edt_phone;
        public System.Windows.Forms.TextBox edt_address;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.SimpleButton btn_addclose;
    }
}