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
	public partial class Form12 : Form
	{
		
		string aa1 = "اخراج";
		string aa2 = "ادخال";
		
		
		public Form12()
		{
			InitializeComponent();
		
		}
		
		
		
		public void getRecordsMaterials(string id)
		{
			
			int ii = 0;
			
			dataGridView1.Rows.Clear();


			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * FROM materials where material_from='" + id + "' or material_to='" + id + "' order by material_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();
			
			while (reader.Read()) {
				
				dataGridView1.Rows.Add(new string[] {
					(reader["material_type"].ToString().Equals(aa1) ? aa2 : aa1),
					reader["material_num"].ToString(),
					sum_tow(reader["material_in"].ToString(), reader["material_out"].ToString()),
					DateTime.Parse(reader["material_date"].ToString()).ToString("MM/dd/yyyy"),
					getNameOFPost(reader["material_post_id"].ToString()),
					reader["material_to_type"].ToString(),
					reader["material_s_t"].ToString(),
					reader["material_desc"].ToString(),
					(++ii).ToString()
				});

			}

			reader.Close();

			con.Close();

			
		}
		
		public string getNameOFPost(string post_id)
		{
			string name = "";
			
			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * FROM posts where post_id =" + post_id;

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


