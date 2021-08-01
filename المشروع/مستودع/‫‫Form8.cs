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
	public partial class Form8 : Form
	{
		public static string materials_types = "";
		
		public Form8()
		{
			InitializeComponent();

			getAllRecords();
			
			this.Text = materials_types;
					
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

		
		public string getNameOFPerson(string id)
		{
			string name = "";
			
			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * FROM persons where person_id =" + id;

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();

			if (reader.Read()) {
				
				name =	reader["person_name"].ToString();
			
			}

			reader.Close();

			con.Close();
			
			return name;

		}
		
		
	
		
		public void getRecordsMaterials()
		{
		
			int ii = 0;
			
			dataGridView1.Rows.Clear();


			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * FROM materials where material_post_id = " + dataGridView2.SelectedRows[0].Cells[0].Value + " and material_to = '" + materials_types + "' order by material_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();
			
			while (reader.Read()) {
				
				dataGridView1.Rows.Add(new string[] {
					reader["material_id"].ToString(),
					(reader["material_type"].ToString().Equals("اخال") ? "اخراج" : "ادخال"),
					reader["material_num"].ToString(),
					sum_tow(reader["material_in"].ToString(), reader["material_out"].ToString()),
					SumTow(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()),
					DateTime.Parse(reader["material_date"].ToString()).ToString("MM/dd/yyyy"),
					choose_tow(reader["material_type"].ToString(), reader["material_from"].ToString(), reader["material_to"].ToString()),
					reader["material_to_type"].ToString(),
					reader["material_s_t"].ToString(),
					reader["material_desc"].ToString(),
					(++ii).ToString()
				                       		
				});

			}

			reader.Close();

			con.Close();

		
		}
		
		public string SumTow(string id)
		{
			int i1 = getSum("material_in", id);
			
			int i2 = getSum("material_out", id);
			
			return (i2 - i1).ToString();
		}
		
		
		public int getSum(string col, string id)
		{
		
			int ii = 0;
			
			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT sum(" + col + ") as lolo from materials where material_post_id=" + id + " and material_to = '" + materials_types + "'";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();
			
			if (reader.Read()) {
				
				ii = int.Parse(reader["lolo"].ToString());

			}

			reader.Close();

			con.Close();
			
			return ii;
		
		}
		
		
		
		public string sum_tow(string a1, string a2)
		{
			return (int.Parse(a1) + int.Parse(a2)).ToString();
		}
		
		public string choose_tow(string a, string a1, string a2)
		{
			if (a.Equals("ادخال")) {
				
				int num;
				if (int.TryParse(a1, out num)) {
					return getNameOFPerson(a1);
				} else {
					return a1;
				}
				
			} else if (a.Equals("اخراج")) {
				int num;
				if (int.TryParse(a2, out num)) {
					return getNameOFPerson(a2);
				} else {
					return a2;
				}
			}
			
			return "";
		}
		
		void DataGridView2CellClick(object sender, DataGridViewCellEventArgs e)
		{
			getRecordsMaterials();
		}
		
		
		
			
		
	}
	
}


