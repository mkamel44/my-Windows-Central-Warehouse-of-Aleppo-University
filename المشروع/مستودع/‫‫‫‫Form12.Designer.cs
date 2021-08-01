namespace مستودع
{
    partial class Form12
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
        	this.button1 = new System.Windows.Forms.Button();
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
        	this.printDocument1 = new System.Drawing.Printing.PrintDocument();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// button1
        	// 
        	this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        	this.button1.Location = new System.Drawing.Point(372, 431);
        	this.button1.Margin = new System.Windows.Forms.Padding(4);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(243, 31);
        	this.button1.TabIndex = 19;
        	this.button1.Text = "طباعة";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// dataGridView1
        	// 
        	this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        	this.dataGridView1.AllowUserToAddRows = false;
        	this.dataGridView1.AllowUserToDeleteRows = false;
        	this.dataGridView1.AllowUserToResizeColumns = false;
        	this.dataGridView1.AllowUserToResizeRows = false;
        	this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        	dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
        	dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
        	dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        	dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        	dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        	this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        	this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dataGridViewTextBoxColumn2,
			this.dataGridViewTextBoxColumn3,
			this.dataGridViewTextBoxColumn5,
			this.Column8,
			this.Column9,
			this.Column12,
			this.Column10,
			this.Column11});
        	this.dataGridView1.Location = new System.Drawing.Point(6, 15);
        	this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
        	this.dataGridView1.MultiSelect = false;
        	this.dataGridView1.Name = "dataGridView1";
        	this.dataGridView1.ReadOnly = true;
        	this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        	dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        	dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
        	dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
        	dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        	dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        	dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        	this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
        	this.dataGridView1.RowHeadersVisible = false;
        	dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        	this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
        	this.dataGridView1.RowTemplate.Height = 25;
        	this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dataGridView1.ShowCellToolTips = false;
        	this.dataGridView1.ShowEditingIcon = false;
        	this.dataGridView1.Size = new System.Drawing.Size(1002, 395);
        	this.dataGridView1.TabIndex = 30;
        	// 
        	// dataGridViewTextBoxColumn2
        	// 
        	this.dataGridViewTextBoxColumn2.FillWeight = 82.67041F;
        	this.dataGridViewTextBoxColumn2.HeaderText = "نوعه";
        	this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        	this.dataGridViewTextBoxColumn2.ReadOnly = true;
        	// 
        	// dataGridViewTextBoxColumn3
        	// 
        	this.dataGridViewTextBoxColumn3.FillWeight = 77.93157F;
        	this.dataGridViewTextBoxColumn3.HeaderText = "رقمه";
        	this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        	this.dataGridViewTextBoxColumn3.ReadOnly = true;
        	// 
        	// dataGridViewTextBoxColumn5
        	// 
        	this.dataGridViewTextBoxColumn5.FillWeight = 72.17972F;
        	this.dataGridViewTextBoxColumn5.HeaderText = "الكمية";
        	this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        	this.dataGridViewTextBoxColumn5.ReadOnly = true;
        	// 
        	// Column8
        	// 
        	this.Column8.FillWeight = 168.7174F;
        	this.Column8.HeaderText = "تاريخ";
        	this.Column8.Name = "Column8";
        	this.Column8.ReadOnly = true;
        	// 
        	// Column9
        	// 
        	this.Column9.FillWeight = 168.7174F;
        	this.Column9.HeaderText = "المادة";
        	this.Column9.Name = "Column9";
        	this.Column9.ReadOnly = true;
        	// 
        	// Column12
        	// 
        	this.Column12.FillWeight = 143.2115F;
        	this.Column12.HeaderText = "مستهلكة ام لا";
        	this.Column12.Name = "Column12";
        	this.Column12.ReadOnly = true;
        	// 
        	// Column10
        	// 
        	this.Column10.FillWeight = 72.22719F;
        	this.Column10.HeaderText = "ص ت";
        	this.Column10.Name = "Column10";
        	this.Column10.ReadOnly = true;
        	// 
        	// Column11
        	// 
        	this.Column11.FillWeight = 94.13294F;
        	this.Column11.HeaderText = "ملاحظات";
        	this.Column11.Name = "Column11";
        	this.Column11.ReadOnly = true;
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
        	// printDocument1
        	// 
        	this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1PrintPage);
        	// 
        	// Form12
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(1012, 475);
        	this.Controls.Add(this.dataGridView1);
        	this.Controls.Add(this.button1);
        	this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "Form12";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "العهدة";
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}