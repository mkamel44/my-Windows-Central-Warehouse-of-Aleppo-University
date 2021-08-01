using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections;

namespace مستودع
{
	public partial class Form11 : Form
	{
		public Form11()
		{
			InitializeComponent();
			
			comboBox1.SelectedIndex = 0;
		}
		
		
		
		public void getRecordsMaterials()
		{
			
			int ii = 0;
			
			dataGridView1.Rows.Clear();


			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * FROM materials where MONTH(material_date)=" + comboBox1.SelectedItem.ToString() + " order by material_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();
			
			while (reader.Read()) {
				
				dataGridView1.Rows.Add(new string[] {
					reader["material_type"].ToString(),
					reader["material_num"].ToString(),
					sum_tow(reader["material_in"].ToString(), reader["material_out"].ToString()),
					getNameOfMatirial(reader["material_post_id"].ToString()),
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
		
		public string getNameOfMatirial(string id)
		{
			string name = "";
			
			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * FROM posts where post_id =" + id;

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();

			if (reader.Read()) {
				
				name =	reader["post_name"].ToString();
			
			}

			reader.Close();

			con.Close();
			
			return name;

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
		
		void Button2Click(object sender, EventArgs e)
		{
			getRecordsMaterials();
		}
		
		void Button1Click(object sender, EventArgs e)
		{

			printDocument1.DefaultPageSettings.Margins = new Margins(10, 10, 50, 50);
			
			printPreviewDialog1.ShowDialog();
		}
		
		void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			DBase.print(dataGridView1, e);
		}
		
		
	}
	
}


