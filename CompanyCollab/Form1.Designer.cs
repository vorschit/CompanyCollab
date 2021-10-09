
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtAgensi = new System.Windows.Forms.TextBox();
            this.txtAktiviti = new System.Windows.Forms.TextBox();
            this.txtSkop = new System.Windows.Forms.TextBox();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConnSuccessFail = new System.Windows.Forms.Label();
            this.dataGridViewSyarikat = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel_header = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSyarikat)).BeginInit();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAgensi
            // 
            this.txtAgensi.BackColor = System.Drawing.Color.Gray;
            this.txtAgensi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgensi.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAgensi.Location = new System.Drawing.Point(124, 91);
            this.txtAgensi.Name = "txtAgensi";
            this.txtAgensi.Size = new System.Drawing.Size(267, 20);
            this.txtAgensi.TabIndex = 1;
            // 
            // txtAktiviti
            // 
            this.txtAktiviti.BackColor = System.Drawing.Color.Gray;
            this.txtAktiviti.ForeColor = System.Drawing.Color.White;
            this.txtAktiviti.Location = new System.Drawing.Point(124, 156);
            this.txtAktiviti.Name = "txtAktiviti";
            this.txtAktiviti.Size = new System.Drawing.Size(267, 20);
            this.txtAktiviti.TabIndex = 2;
            // 
            // txtSkop
            // 
            this.txtSkop.BackColor = System.Drawing.Color.Gray;
            this.txtSkop.Location = new System.Drawing.Point(124, 215);
            this.txtSkop.Multiline = true;
            this.txtSkop.Name = "txtSkop";
            this.txtSkop.Size = new System.Drawing.Size(267, 86);
            this.txtSkop.TabIndex = 3;
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConnStatus.Location = new System.Drawing.Point(491, 241);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(100, 13);
            this.lblConnStatus.TabIndex = 4;
            this.lblConnStatus.Text = "Connection Status :";
            this.lblConnStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(23, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agensi / Syarikat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(26, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aktiviti Agensi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(26, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Skop Kerjasama";
            // 
            // lblConnSuccessFail
            // 
            this.lblConnSuccessFail.AutoSize = true;
            this.lblConnSuccessFail.Location = new System.Drawing.Point(607, 241);
            this.lblConnSuccessFail.Name = "lblConnSuccessFail";
            this.lblConnSuccessFail.Size = new System.Drawing.Size(35, 13);
            this.lblConnSuccessFail.TabIndex = 8;
            this.lblConnSuccessFail.Text = "label1";
            // 
            // dataGridViewSyarikat
            // 
            this.dataGridViewSyarikat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSyarikat.Location = new System.Drawing.Point(37, 330);
            this.dataGridViewSyarikat.Name = "dataGridViewSyarikat";
            this.dataGridViewSyarikat.Size = new System.Drawing.Size(885, 361);
            this.dataGridViewSyarikat.TabIndex = 9;
            this.dataGridViewSyarikat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSyarikat_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(920, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_header.Controls.Add(this.btnClose);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(998, 33);
            this.panel_header.TabIndex = 11;
            this.panel_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_header_Paint);
            this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            this.panel_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseMove);
            this.panel_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(998, 721);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.dataGridViewSyarikat);
            this.Controls.Add(this.lblConnSuccessFail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblConnStatus);
            this.Controls.Add(this.txtSkop);
            this.Controls.Add(this.txtAktiviti);
            this.Controls.Add(this.txtAgensi);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSyarikat)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAgensi;
        private System.Windows.Forms.TextBox txtAktiviti;
        private System.Windows.Forms.TextBox txtSkop;
        private System.Windows.Forms.Label lblConnStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConnSuccessFail;
        private System.Windows.Forms.DataGridView dataGridViewSyarikat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel_header;
    }
}

