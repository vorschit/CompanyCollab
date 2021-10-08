
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAgensi
            // 
            this.txtAgensi.Location = new System.Drawing.Point(184, 115);
            this.txtAgensi.Name = "txtAgensi";
            this.txtAgensi.Size = new System.Drawing.Size(267, 20);
            this.txtAgensi.TabIndex = 1;
            // 
            // txtAktiviti
            // 
            this.txtAktiviti.Location = new System.Drawing.Point(184, 180);
            this.txtAktiviti.Name = "txtAktiviti";
            this.txtAktiviti.Size = new System.Drawing.Size(267, 20);
            this.txtAktiviti.TabIndex = 2;
            // 
            // txtSkop
            // 
            this.txtSkop.Location = new System.Drawing.Point(184, 239);
            this.txtSkop.Multiline = true;
            this.txtSkop.Name = "txtSkop";
            this.txtSkop.Size = new System.Drawing.Size(267, 86);
            this.txtSkop.TabIndex = 3;
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.Location = new System.Drawing.Point(222, 481);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(100, 13);
            this.lblConnStatus.TabIndex = 4;
            this.lblConnStatus.Text = "Connection Status :";
            this.lblConnStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agensi / Syarikat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aktiviti Agensi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Skop Kerjasama";
            // 
            // lblConnSuccessFail
            // 
            this.lblConnSuccessFail.AutoSize = true;
            this.lblConnSuccessFail.Location = new System.Drawing.Point(338, 481);
            this.lblConnSuccessFail.Name = "lblConnSuccessFail";
            this.lblConnSuccessFail.Size = new System.Drawing.Size(35, 13);
            this.lblConnSuccessFail.TabIndex = 8;
            this.lblConnSuccessFail.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 552);
            this.Controls.Add(this.lblConnSuccessFail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblConnStatus);
            this.Controls.Add(this.txtSkop);
            this.Controls.Add(this.txtAktiviti);
            this.Controls.Add(this.txtAgensi);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

