using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections;

namespace مستودع
{
	public partial class Form9 : Form
	{
		public static string materials_types = "منسقات";
		
		public Form9()
		{
			InitializeComponent();

			getAllRecords();
					
		}
		
		
	
		
		public void getAllRecords()
		{
			int ii=0;
			
			dataGridView2.Rows.Clear();
			
			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * FROM posts order by post_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();

			while (reader.Read()) {
				
				dataGridView2.Rows.Add(new string[] {
					reader["post_name"].ToString(),
					get_all_here(reader["post_id"].ToString()),
					(++ii).ToString()
				                       		
				});

			}

			reader.Close();

			con.Close();

		}
		
		
		public string get_all_here(string id)
		{
			
			int ii = 0;
			
			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * FROM materials where material_post_id=" + id;

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();

			while (reader.Read()) {

				ii = ii + int.Parse(reader["material_in"].ToString());
				
				ii = ii - int.Parse(reader["material_out"].ToString());

			}

			reader.Close();

			con.Close();
			
			return ii.ToString();
		
		}
		
		public void Button2Click(object sender, EventArgs e)
		{

			new Thread(new ThreadStart(SearchValueRowIndex)).Start();
			
		}
		
		public void SearchValueRowIndex()
		{
			string searchValue = textBox2.Text.Trim();

			if (searchValue != "") {
				
				foreach (DataGridViewRow row in dataGridView2.Rows) {
					
					foreach (DataGridViewCell cell in row.Cells) {
						
						if (cell.Value != null && cell.Value.ToString().Trim().Contains(searchValue)) {
							row.Selected = true;
							break;
						}
					}
				}
				
			}

			
		}
		
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			printPreviewDialog1.ShowDialog();
		}
		
			
		void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			DBase.print(dataGridView2, e);
		
		}

	
		
		
	}
	
}


