
namespace CompanyCollab
{
    partial class UserControlHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewSyarikat = new System.Windows.Forms.DataGridView();
            this.lblHome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSyarikat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewSyarikat);
            this.panel1.Location = new System.Drawing.Point(71, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 604);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewSyarikat
            // 
            this.dataGridViewSyarikat.AllowUserToResizeColumns = false;
            this.dataGridViewSyarikat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSyarikat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSyarikat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataGridViewSyarikat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSyarikat.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSyarikat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSyarikat.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSyarikat.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSyarikat.Name = "dataGridViewSyarikat";
            this.dataGridViewSyarikat.RowHeadersWidth = 51;
            this.dataGridViewSyarikat.Size = new System.Drawing.Size(1128, 604);
            this.dataGridViewSyarikat.TabIndex = 10;
            this.dataGridViewSyarikat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSyarikat_CellContentClick);
            this.dataGridViewSyarikat.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewSyarikat_CellFormatting);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Nirmala UI", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(71, 36);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(188, 77);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Home";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1044, 729);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlHome";
            this.Size = new System.Drawing.Size(1267, 870);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSyarikat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewSyarikat;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button button1;
    }
}
