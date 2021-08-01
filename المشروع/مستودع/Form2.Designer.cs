namespace مستودع
{
    partial class Form2
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
        	this.dataGridView2 = new System.Windows.Forms.DataGridView();
        	this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.button1 = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.textBox3 = new System.Windows.Forms.TextBox();
        	this.button2 = new System.Windows.Forms.Button();
        	this.textBox4 = new System.Windows.Forms.TextBox();
        	this.button3 = new System.Windows.Forms.Button();
        	this.button4 = new System.Windows.Forms.Button();
        	this.printDocument1 = new System.Drawing.Printing.PrintDocument();
        	this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
        	this.button5 = new System.Windows.Forms.Button();
        	this.button6 = new System.Windows.Forms.Button();
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
        	this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column1,
			this.Column2,
			this.Column3,
			this.Column4,
			this.Column5});
        	this.dataGridView2.Location = new System.Drawing.Point(4, 5);
        	this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
        	this.dataGridView2.MultiSelect = false;
        	this.dataGridView2.Name = "dataGridView2";
        	this.dataGridView2.ReadOnly = true;
        	this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        	this.dataGridView2.RowHeadersVisible = false;
        	this.dataGridView2.RowTemplate.Height = 25;
        	this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dataGridView2.ShowCellToolTips = false;
        	this.dataGridView2.ShowEditingIcon = false;
        	this.dataGridView2.Size = new System.Drawing.Size(701, 266);
        	this.dataGridView2.TabIndex = 18;
        	this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView2SelectionChanged);
        	// 
        	// Column1
        	// 
        	this.Column1.HeaderText = "الرقم";
        	this.Column1.Name = "Column1";
        	this.Column1.ReadOnly = true;
        	this.Column1.Visible = false;
        	// 
        	// Column2
        	// 
        	this.Column2.FillWeight = 93.79269F;
        	this.Column2.HeaderText = "اسم الموظف";
        	this.Column2.Name = "Column2";
        	this.Column2.ReadOnly = true;
        	// 
        	// Column3
        	// 
        	this.Column3.FillWeight = 169.4435F;
        	this.Column3.HeaderText = "مكان الموظف";
        	this.Column3.Name = "Column3";
        	this.Column3.ReadOnly = true;
        	// 
        	// Column4
        	// 
        	this.Column4.FillWeight = 106.3069F;
        	this.Column4.HeaderText = "عمل الموظف";
        	this.Column4.Name = "Column4";
        	this.Column4.ReadOnly = true;
        	// 
        	// Column5
        	// 
        	this.Column5.FillWeight = 30.45686F;
        	this.Column5.HeaderText = "ترقيم";
        	this.Column5.Name = "Column5";
        	this.Column5.ReadOnly = true;
        	// 
        	// button1
        	// 
        	this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.button1.Location = new System.Drawing.Point(583, 394);
        	this.button1.Margin = new System.Windows.Forms.Padding(4);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(107, 34);
        	this.button1.TabIndex = 203;
        	this.button1.Text = "اضافة موظف";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// label1
        	// 
        	this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(603, 283);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(97, 19);
        	this.label1.TabIndex = 21;
        	this.label1.Text = "اسم الموظف";
        	// 
        	// textBox1
        	// 
        	this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.textBox1.Location = new System.Drawing.Point(4, 280);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(593, 27);
        	this.textBox1.TabIndex = 200;
        	this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        	// 
        	// label2
        	// 
        	this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(603, 316);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(99, 19);
        	this.label2.TabIndex = 23;
        	this.label2.Text = "مكان الموظف";
        	// 
        	// textBox2
        	// 
        	this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.textBox2.Location = new System.Drawing.Point(4, 313);
        	this.textBox2.Name = "textBox2";
        	this.textBox2.Size = new System.Drawing.Size(593, 27);
        	this.textBox2.TabIndex = 201;
        	this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        	// 
        	// label3
        	// 
        	this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(603, 349);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(97, 19);
        	this.label3.TabIndex = 25;
        	this.label3.Text = "عمل الموظف";
        	// 
        	// textBox3
        	// 
        	this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.textBox3.Location = new System.Drawing.Point(4, 346);
        	this.textBox3.Name = "textBox3";
        	this.textBox3.Size = new System.Drawing.Size(593, 27);
        	this.textBox3.TabIndex = 202;
        	this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        	// 
        	// button2
        	// 
        	this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.button2.Location = new System.Drawing.Point(473, 394);
        	this.button2.Margin = new System.Windows.Forms.Padding(4);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(102, 34);
        	this.button2.TabIndex = 204;
        	this.button2.Text = "تعديل موظف";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.Button2Click);
        	// 
        	// textBox4
        	// 
        	this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.textBox4.Location = new System.Drawing.Point(10, 399);
        	this.textBox4.Name = "textBox4";
        	this.textBox4.Size = new System.Drawing.Size(10, 27);
        	this.textBox4.TabIndex = 28;
        	this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        	this.textBox4.Visible = false;
        	// 
        	// button3
        	// 
        	this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.button3.Location = new System.Drawing.Point(250, 394);
        	this.button3.Margin = new System.Windows.Forms.Padding(4);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(102, 34);
        	this.button3.TabIndex = 205;
        	this.button3.Text = "افراغ الحقول";
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.Click += new System.EventHandler(this.Button3Click);
        	// 
        	// button4
        	// 
        	this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.button4.Location = new System.Drawing.Point(27, 394);
        	this.button4.Margin = new System.Windows.Forms.Padding(4);
        	this.button4.Name = "button4";
        	this.button4.Size = new System.Drawing.Size(105, 34);
        	this.button4.TabIndex = 206;
        	this.button4.Text = "طباعة";
        	this.button4.UseVisualStyleBackColor = true;
        	this.button4.Click += new System.EventHandler(this.Button4Click);
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
        	// button5
        	// 
        	this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.button5.Location = new System.Drawing.Point(360, 394);
        	this.button5.Margin = new System.Windows.Forms.Padding(4);
        	this.button5.Name = "button5";
        	this.button5.Size = new System.Drawing.Size(105, 34);
        	this.button5.TabIndex = 207;
        	this.button5.Text = "حذف موظف";
        	this.button5.UseVisualStyleBackColor = true;
        	this.button5.Click += new System.EventHandler(this.Button5Click);
        	// 
        	// button6
        	// 
        	this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.button6.Location = new System.Drawing.Point(139, 394);
        	this.button6.Margin = new System.Windows.Forms.Padding(4);
        	this.button6.Name = "button6";
        	this.button6.Size = new System.Drawing.Size(103, 34);
        	this.button6.TabIndex = 208;
        	this.button6.Text = "العهدة";
        	this.button6.UseVisualStyleBackColor = true;
        	this.button6.Click += new System.EventHandler(this.Button6Click);
        	// 
        	// Form2
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(709, 443);
        	this.Controls.Add(this.button6);
        	this.Controls.Add(this.button5);
        	this.Controls.Add(this.button4);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.textBox4);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.textBox3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.textBox2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.dataGridView2);
        	this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.Name = "Form2";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "الموظفين";
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}