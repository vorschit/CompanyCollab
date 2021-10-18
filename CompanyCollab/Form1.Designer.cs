
namespace CompanyCollab
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.lblConnSuccessFail = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnDeadline = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.ForeColor = System.Drawing.Color.Black;
            this.lblConnStatus.Location = new System.Drawing.Point(16, 754);
            this.lblConnStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(131, 17);
            this.lblConnStatus.TabIndex = 4;
            this.lblConnStatus.Text = "Connection Status :";
            this.lblConnStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblConnSuccessFail
            // 
            this.lblConnSuccessFail.AutoSize = true;
            this.lblConnSuccessFail.Location = new System.Drawing.Point(171, 754);
            this.lblConnSuccessFail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnSuccessFail.Name = "lblConnSuccessFail";
            this.lblConnSuccessFail.Size = new System.Drawing.Size(46, 17);
            this.lblConnSuccessFail.TabIndex = 8;
            this.lblConnSuccessFail.Text = "label1";
            this.lblConnSuccessFail.Click += new System.EventHandler(this.lblConnSuccessFail_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1540, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelSideMenu.Controls.Add(this.btnDeadline);
            this.panelSideMenu.Controls.Add(this.panel2);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.lblConnSuccessFail);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Controls.Add(this.lblConnStatus);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 30);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(333, 870);
            this.panelSideMenu.TabIndex = 12;
            // 
            // btnDeadline
            // 
            this.btnDeadline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeadline.BackgroundImage")));
            this.btnDeadline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeadline.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeadline.FlatAppearance.BorderSize = 0;
            this.btnDeadline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeadline.Location = new System.Drawing.Point(0, 369);
            this.btnDeadline.Name = "btnDeadline";
            this.btnDeadline.Size = new System.Drawing.Size(333, 123);
            this.btnDeadline.TabIndex = 0;
            this.btnDeadline.UseVisualStyleBackColor = true;
            this.btnDeadline.Click += new System.EventHandler(this.btnDeadline_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 815);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 55);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.btnNewEntry);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 246);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 123);
            this.panel1.TabIndex = 1;
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNewEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewEntry.BackgroundImage")));
            this.btnNewEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewEntry.FlatAppearance.BorderSize = 0;
            this.btnNewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEntry.Location = new System.Drawing.Point(0, 0);
            this.btnNewEntry.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(333, 123);
            this.btnNewEntry.TabIndex = 0;
            this.btnNewEntry.UseVisualStyleBackColor = false;
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            this.btnNewEntry.MouseHover += new System.EventHandler(this.btnNewEntry_MouseHover);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 123);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHome.Size = new System.Drawing.Size(333, 123);
            this.btnHome.TabIndex = 0;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(333, 123);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.Silver;
            this.panel_header.Controls.Add(this.btnClose);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(4);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1600, 30);
            this.panel_header.TabIndex = 11;
            this.panel_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_header_Paint);
            this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            this.panel_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseMove);
            this.panel_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseUp);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(333, 30);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1267, 870);
            this.panelMain.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblConnStatus;
        private System.Windows.Forms.Label lblConnSuccessFail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnDeadline;
    }
}

