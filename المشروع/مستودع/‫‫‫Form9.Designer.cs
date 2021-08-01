namespace مستودع
{
    partial class Form9
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
        	System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        	System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        	System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
        	this.dataGridView2 = new System.Windows.Forms.DataGridView();
        	this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.button2 = new System.Windows.Forms.Button();
        	this.button1 = new System.Windows.Forms.Button();
        	this.printDocument1 = new System.Drawing.Printing.PrintDocument();
        	this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// dataGridView2
        	// 
        	this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        	this.dataGridView2.AllowUserToAddRows = false;
        	this.dataGridView2.AllowUserToDeleteRows = false;
        	this.dataGridView2.AllowUserToResizeColumns = false;
        	this.dataGridView2.AllowUserToResizeRows = false;
        	this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        	dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
        	dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
        	dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        	dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        	dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        	this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        	this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column2,
			this.Column4});
        	this.dataGridView2.Location = new System.Drawing.Point(6, 48);
        	this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
        	this.dataGridView2.MultiSelect = false;
        	this.dataGridView2.Name = "dataGridView2";
        	this.dataGridView2.ReadOnly = true;
        	this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        	dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        	dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
        	dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
        	dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        	dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        	dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        	this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
        	this.dataGridView2.RowHeadersVisible = false;
        	dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        	this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
        	this.dataGridView2.RowTemplate.Height = 25;
        	this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dataGridView2.ShowCellToolTips = false;
        	this.dataGridView2.ShowEditingIcon = false;
        	this.dataGridView2.Size = new System.Drawing.Size(1002, 355);
        	this.dataGridView2.TabIndex = 18;
        	// 
        	// Column2
        	// 
        	this.Column2.FillWeight = 83.7121F;
        	this.Column2.HeaderText = "اسم المادة";
        	this.Column2.Name = "Column2";
        	this.Column2.ReadOnly = true;
        	// 
        	// Column4
        	// 
        	this.Column4.FillWeight = 94.88133F;
        	this.Column4.HeaderText = "الكمية الموجودة";
        	this.Column4.Name = "Column4";
        	this.Column4.ReadOnly = true;
        	// 
        	// textBox2
        	// 
        	this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.textBox2.Location = new System.Drawing.Point(400, 12);
        	this.textBox2.Name = "textBox2";
        	this.textBox2.Size = new System.Drawing.Size(348, 27);
        	this.textBox2.TabIndex = 28;
        	this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(250, 13);
        	this.button2.Margin = new System.Windows.Forms.Padding(4);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(143, 27);
        	this.button2.TabIndex = 29;
        	this.button2.Text = "البحث";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.Button2Click);
        	// 
        	// button1
        	// 
        	this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.button1.Location = new System.Drawing.Point(428, 413);
        	this.button1.Margin = new System.Windows.Forms.Padding(4);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(143, 27);
        	this.button1.TabIndex = 30;
        	this.button1.Text = "طباعة";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// printDocument1
        	// 
        	this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1PrintPage);
        	// 
        	// printPreviewDialog1
        	// 
        	this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
        	this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
        	this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
        	this.printPreviewDialog1.Document = this.printDocument1;
        	this.printPreviewDialog1.Enabled = true;
        	this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
        	this.printPreviewDialog1.Name = "printPreviewDialog1";
        	this.printPreviewDialog1.Visible = false;
        	// 
        	// Form9
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(1012, 444);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.textBox2);
        	this.Controls.Add(this.dataGridView2);
        	this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.Name = "Form9";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "المستودع";
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}