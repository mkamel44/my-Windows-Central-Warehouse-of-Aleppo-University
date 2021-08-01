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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();

			comboBox2.SelectedIndex = 0;
			
			comboBox4.SelectedIndex = 0;
			
			getAllRecords();
			
			getAllRecordsOfPersons(comboBox1);
			
			getAllRecordsOfPersons(comboBox3);
			
			DataGridView.CheckForIllegalCrossThreadCalls = false;
			
		}
		
		
		public void getAllRecordsOfPersons(ComboBox box)
		{
			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * FROM persons order by person_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();

			box.DisplayMember = "Text";
			
			box.ValueMember = "Value";
			
			
			while (reader.Read()) {
				
				box.Items.Add(new { Text = reader["person_name"].ToString(), Value = reader["person_id"].ToString() });
				
				box.SelectedIndex = 0;

			}

			reader.Close();

			con.Close();

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
		
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]")) {
				textBox1.Text = "";
			}
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
		void TextBox2KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				Button2Click(sender, e);
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			
			if (comboBox2.SelectedItem.Equals("اخراج")) {
			
				int u =	SumTow(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
			
				int y = int.Parse(textBox4.Text);
				
				if (u >= y) {
					
					addnewReq();
			
					rest_all();
			
					MessageBox.Show("تمت الاضافة بنجاح");
					
				} else {
					MessageBox.Show("ان القيمة المدرجة بحقل الاخراج اكبر من الرصيد الرجاء ادخال قيمة اصغر من الرصيد او يساويه");
				}
				
			} else {
				addnewReq();
			
				rest_all();
			
				MessageBox.Show("تمت الاضافة بنجاح");
			}
				
		
			
		}
		
		public void rest_all()
		{
			textBox1.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
			textBox7.Text = "";
		}
		
		public string gettypenow()
		{
		
			if (comboBox2.SelectedItem.Equals("اخراج")) {
				if (radioButton3.Checked) {
					return comboBox4.SelectedItem.ToString();
				}
			}
			
			return "";
			
		
		}
		
		public void addnewReq()
		{
			OleDbConnection con = DBase.createConnection();

			int a1 = getNum(textBox3);
			
			int a2 = getNum(textBox4);
			
			string aa1 = getMaterial_from();
			
			string aa2 = getMaterial_to();
			
			String insertSQL = "insert into materials (material_type,material_num,material_date,material_in,material_out,material_from,material_to,material_to_type,material_post_id,material_s_t,material_desc) values ('" + comboBox2.Text + "'," + textBox1.Text + ",'" + dateTimePicker1.Value.ToShortDateString() + "'," + a1 + "," + a2 + ",'" + aa1 + "','" + aa2 + "','" + gettypenow() + "'," + dataGridView2.SelectedRows[0].Cells[0].Value + ",'" + textBox5.Text + "','" + textBox6.Text + "')";

			OleDbCommand command = new OleDbCommand(insertSQL, con);

			command.ExecuteNonQuery();

			con.Close();
				
			getRecordsMaterials();
		}
		
		
		public int getNum(TextBox tex)
		{
			try {
				
				return Convert.ToInt32(tex.Text);
				
			} catch {
				return 0;
			}
		}
		
		
		public  string getMaterial_from()
		{
			if (comboBox2.SelectedItem.Equals("ادخال")) {
				if (radioButton1.Checked) {
					return textBox7.Text;
				} else if (radioButton2.Checked) {
					return (comboBox1.SelectedItem as dynamic).Value;
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
		
		
		public string getMaterial_to()
		{
			if (comboBox2.SelectedItem.Equals("اخراج")) {
				if (radioButton3.Checked) {
					return (comboBox3.SelectedItem as dynamic).Value;
				} else if (radioButton4.Checked) {
					return "منسقات";
				} else if (radioButton5.Checked) {
					return "محضر تركيب";
				}
				
			}
			
			return "";

		}
		
		public void getRecordsMaterials()
		{
			
			int ii = 0;
		
			dataGridView1.Rows.Clear();


			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * FROM materials where material_post_id = " + dataGridView2.SelectedRows[0].Cells[0].Value + " order by material_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();
			
			while (reader.Read()) {
				
				dataGridView1.Rows.Add(new string[] {
					reader["material_id"].ToString(),
					reader["material_type"].ToString(),
					reader["material_num"].ToString(),
					sum_tow(reader["material_in"].ToString(), reader["material_out"].ToString()),
					SumTow(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()).ToString(),
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
		
		public int SumTow(string id)
		{
			int i1 = getSum("material_in", id);
			
			int i2 = getSum("material_out", id);
			
			return i1 - i2;
		}
		
		
		public int getSum(string col, string id)
		{
		
			int ii = 0;
			
			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT sum(" + col + ") as lolo from materials where material_post_id=" + id;

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();
			
			if (reader.Read()) {
				
				string ccc = reader["lolo"].ToString();
				
				try {
					
					ii = int.Parse(ccc);
					
				} catch (Exception) {
					
					ii = 0;
					
				}

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
		
		
		void Button3Click(object sender, EventArgs e)
		{
			if (dataGridView1.Rows.Count != 0) {
			
				deleteReq(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

				getRecordsMaterials();
			}
		
		}
		
		public void deleteReq(string id)
		{
			OleDbConnection con = DBase.createConnection();
			
			String insertSQL = "DELETE FROM materials where material_id=" + id;

			OleDbCommand command = new OleDbCommand(insertSQL, con);

			command.ExecuteNonQuery();

			con.Close();
		
		}
		
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox2.SelectedItem.Equals("اخراج")) {
				textBox3.Enabled = false;
				textBox4.Enabled = true;
				groupBox1.Enabled = false;
				groupBox2.Enabled = true;
			
			} else if (comboBox2.SelectedItem.Equals("ادخال")) {
			
				textBox3.Enabled = true;
				textBox4.Enabled = false;
				groupBox1.Enabled = true;
				groupBox2.Enabled = false;
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			new Thread(new ThreadStart(getRecordsMaterials2)).Start();
		}
		
		
		 void getRecordsMaterials2()
		{
			
			int ii = 0;
		
			dataGridView1.Rows.Clear();


			OleDbConnection con = DBase.createConnection();

			String selectSQL = "SELECT * FROM materials where material_num = " + textBox8.Text + " order by material_id desc";

			OleDbCommand command = new OleDbCommand(selectSQL, con);

			OleDbDataReader reader = command.ExecuteReader();
			
			while (reader.Read()) {
				
				dataGridView1.Rows.Add(new string[] {
					reader["material_id"].ToString(),
					reader["material_type"].ToString(),
					reader["material_num"].ToString(),
					sum_tow(reader["material_in"].ToString(), reader["material_out"].ToString()),
					SumTow(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()).ToString(),
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
		void TextBox8TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, "[^0-9]")) {
				textBox8.Text = "0";
			}
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
			
		
	}
	
}


