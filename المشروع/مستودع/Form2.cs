using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.VisualStyles;

namespace مستودع
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();

			getAllRecords();
			
		}
		
		
		public void getAllRecords()
		{
			int ii=0;
			
			dataGridView2.Rows.Clear();
			
			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * FROM persons order by person_id desc ";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();

			while (reader.Read()) {
				
				dataGridView2.Rows.Add(new string[] {
					reader["person_id"].ToString(),
					reader["person_name"].ToString(),
					reader["person_place"].ToString(),
					reader["person_functionality"].ToString(),
					(++ii).ToString()
				                       		
				});

			}

			reader.Close();

			con.Close();
			
			textBox4.Text = "";
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (!textBox1.Text.Trim().Equals("") && !textBox2.Text.Trim().Equals("") && !textBox3.Text.Trim().Equals("")) {
				
				OleDbConnection con = DBase.createConnection();

				String insertSQL = "insert into persons (person_name,person_place,person_functionality) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";

				OleDbCommand command = new OleDbCommand(insertSQL, con);

				command.ExecuteNonQuery();

				con.Close();
				
				getAllRecords();
			} else {
				MessageBox.Show("الرجاء التأكد من المدخلات");
			}
			
		}
		
		void  rest_data()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(textBox4.Text)) {
				
				OleDbConnection con = DBase.createConnection();

				String insertSQL = "update persons set person_name='" + textBox1.Text + "' , person_place='" + textBox2.Text + "', person_functionality='" + textBox3.Text + "' where person_id =" + textBox4.Text;

				OleDbCommand command = new OleDbCommand(insertSQL, con);

				command.ExecuteNonQuery();

				con.Close();
				
				getAllRecords();
			}
			
		}
		
		void DataGridView2SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridView2.SelectedRows.Count > 0) {
				textBox4.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
				textBox1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
				textBox2.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
				textBox3.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			rest_data();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Close();
			dataGridView2.Columns.Remove("Column1");
			printPreviewDialog1.ShowDialog();
		}
		
		
		void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			DBase.print(dataGridView2, e);
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if (check_name_here(dataGridView2.SelectedRows[0].Cells[0].Value.ToString())) {
			
				delete(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
				
				getAllRecords();
				
			} else {
			
				MessageBox.Show("ان الموظف المطلوب حذفه مرتبط بعمليات");
			}
		}
		
		public bool check_name_here(string id)
		{
			bool ii = true;
			
			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * from materials where material_to='" + id + "' or material_from='" + id + "'";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();
			
			if (reader.Read()) {
				
				ii = false;

			}

			reader.Close();

			con.Close();
			
			return ii;
		}
		
		public void delete(string id)
		{
			OleDbConnection con = DBase.createConnection();
			
			String insertSQL = "DELETE FROM persons where person_id=" + id;

			OleDbCommand command = new OleDbCommand(insertSQL, con);

			command.ExecuteNonQuery();

			con.Close();
		
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			var ff = new Form12();
			ff.getRecordsMaterials(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
			ff.ShowDialog();
		}
		

	}
}