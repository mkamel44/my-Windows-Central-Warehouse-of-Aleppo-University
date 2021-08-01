using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace مستودع
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();

		}
        
		void Button1Click(object sender, EventArgs e)
		{
			var ff = new Form4();

			ff.ShowDialog();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			var ff = new Form2();

			ff.ShowDialog();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			var ff = new Form7();

			ff.ShowDialog();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			var ff = new Form3();

			ff.ShowDialog();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			var ff = new Form9();

			ff.ShowDialog();
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			Form8.materials_types = "منسقات";
			
			var ff = new Form8();

			ff.ShowDialog();
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			Form8.materials_types = "محضر تركيب";
			
			var ff = new Form8();

			ff.ShowDialog();
		}
		
		
		void Button10Click(object sender, EventArgs e)
		{
			var ff = new Form10();

			ff.ShowDialog();
		}
		
		 
		void Button11Click(object sender, EventArgs e)
		{
			var ff = new Form11();

			ff.ShowDialog();
		}
		
		
		void Button5Click(object sender, EventArgs e)
		{
			try {
			
				//string path_new = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			
				System.IO.Directory.CreateDirectory("D:\\backup");
				
				string path_old_database = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf('\\')) + "\\" + "db1.mdb";
			
				string path_new_database = "D:\\backup\\db1.mdb";
		
				System.IO.File.Copy(path_old_database, path_new_database);
				
				string path_old_app = System.Reflection.Assembly.GetEntryAssembly().Location;
				
				string path_new_app = "D:\\backup\\المستودع.exe";
				
				System.IO.File.Copy(path_old_app, path_new_app);
				
				
				MessageBox.Show("تم انشاء نسخة احتياطية عن المشروع بالكامل على الدي \n backup \n الرجاء الاحتفاظ بالمجلد على قرص صلب آخر", "النسخ الاحتياطي");
				
			} 
			catch (Exception)
			{
				MessageBox.Show("ان المجلد \n backup \n موجود او لايمكن الكتابة على الدي", "النسخ الاحتياطي");
			}
		}
		
		
	}
}