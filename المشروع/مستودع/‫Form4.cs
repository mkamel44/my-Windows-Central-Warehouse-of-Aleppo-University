using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace مستودع
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();

			getAllRecords();
		
		}
        
        
		public void getAllRecords()
		{
			int ii = 0;
			
			dataGridView2.Rows.Clear();
			
			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * FROM posts order by post_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();

			while (reader.Read()) {
				
				dataGridView2.Rows.Add(new string[] {
					reader["post_id"].ToString(),
					reader["post_name"].ToString(),
					reader["post_num"].ToString(),
					reader["post_last"].ToString(),
					reader["post_first"].ToString(),
					reader["post_of_num"].ToString(),
					(++ii).ToString()
				});

			}

			reader.Close();

			con.Close();
			
			textBox4.Text = "";
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (!textBox1.Text.Trim().Equals("") && !textBox2.Text.Trim().Equals("") && !textBox3.Text.Trim().Equals("") && !textBox5.Text.Trim().Equals("") && !textBox6.Text.Trim().Equals("")) {
			
				OleDbConnection con = DBase.createConnection();

				String insertSQL = "insert into posts (post_name,post_num,post_last,post_first,post_of_num) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";

				OleDbCommand command = new OleDbCommand(insertSQL, con);

				command.ExecuteNonQuery();

				con.Close();
			
				getAllRecords();
			} else {
				MessageBox.Show("الرجاء التأكد من المدخلات");
			}
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(textBox4.Text)) {
			
				OleDbConnection con = DBase.createConnection();

				String insertSQL = "update posts set post_name='" + textBox1.Text + "' , post_num='" + textBox2.Text + "', post_last='" + textBox3.Text + "', post_first='" + textBox5.Text + "', post_of_num='" + textBox5.Text + "' where post_id =" + textBox4.Text;

				OleDbCommand command = new OleDbCommand(insertSQL, con);

				command.ExecuteNonQuery();

				con.Close();
				
				getAllRecords();
 				
				rest_data();
			}
			
		}
		
		void  rest_data()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
		}
	
		void DataGridView2SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridView2.SelectedRows.Count > 0) {  
				textBox4.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
				textBox1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
				textBox2.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
				textBox3.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
				textBox5.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
				textBox6.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
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
			
				MessageBox.Show("ان هذه المادة مرتبطة بعمليات");
			}
		}
		
		public bool check_name_here(string id)
		{
			bool ii = true;
			
			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * from materials where material_post_id=" + id;

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
			
			String insertSQL = "DELETE FROM posts where post_id=" + id;

			OleDbCommand command = new OleDbCommand(insertSQL, con);

			command.ExecuteNonQuery();

			con.Close();
		
		}
	

	}
}