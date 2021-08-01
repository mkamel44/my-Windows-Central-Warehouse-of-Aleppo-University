using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace مستودع
{
	public class DBase
	{
		public static OleDbConnection createConnection()
		{

			int index = Application.ExecutablePath.LastIndexOf('\\');

			string path = Application.ExecutablePath.Substring(0, index) + "\\" + "db1.mdb";

			OleDbConnection aConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Jet OLEDB:Database Password=lolo");

			aConnection.Open();

			return aConnection;

		}
		
		
		public static void print(DataGridView dataGridView2, System.Drawing.Printing.PrintPageEventArgs e)
		{
			StringFormat strFormat = new StringFormat();
			//Used to format the grid rows.
			ArrayList arrColumnLefts = new ArrayList();
			//Used to save left coordinates of columns
			ArrayList arrColumnWidths = new ArrayList();
			//Used to save column widths
			int iCellHeight = 0;
			//Used to get/set the datagridview cell height
			int iTotalWidth = 0;
			//
			int iRow = 0;
			//Used as counter
			bool bFirstPage = false;
			//Used to check whether we are printing first page
			bool bNewPage = false;
			// Used to check whether we are printing a new page
			int iHeaderHeight = 0;
			//Used for the header height
			
			
				
			try {
				
				strFormat.Alignment = StringAlignment.Near;
				strFormat.LineAlignment = StringAlignment.Center;
				strFormat.Trimming = StringTrimming.EllipsisCharacter;

				arrColumnLefts.Clear();
				arrColumnWidths.Clear();
				iCellHeight = 0;
				iRow = 0;
				bFirstPage = true;
				bNewPage = true;

				// Calculating Total Widths
				iTotalWidth = 0;
				foreach (DataGridViewColumn dgvGridCol in dataGridView2.Columns) {
					iTotalWidth += dgvGridCol.Width;
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			try {
				
				

				//Set the left margin
				int iLeftMargin = e.MarginBounds.Left;
				//Set the top margin
				int iTopMargin = e.MarginBounds.Top;
				//Whether more pages have to print or not
				bool bMorePagesToPrint = false;
				int iTmpWidth = 0;             

				//For the first page to print set the cell width and header height
				if (bFirstPage) {
					foreach (DataGridViewColumn GridCol in dataGridView2.Columns) {
						iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
						(double)iTotalWidth * (double)iTotalWidth *
						((double)e.MarginBounds.Width / (double)iTotalWidth))));

						iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
							GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

						// Save width and height of headers
						arrColumnLefts.Add(iLeftMargin);
						arrColumnWidths.Add(iTmpWidth);
						iLeftMargin += iTmpWidth;
					}
				}
				//Loop till all the grid rows not get printed
				while (iRow <= dataGridView2.Rows.Count - 1) {
					DataGridViewRow GridRow = dataGridView2.Rows[iRow];
					//Set the cell height
					iCellHeight = GridRow.Height + 5;
					int iCount = 0;
					//Check whether the current page settings allows more rows to print
					if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top) {
						bNewPage = true;
						bFirstPage = false;
						bMorePagesToPrint = true;
						break;
					} else {
						if (bNewPage) {
							//Draw Header
							e.Graphics.DrawString("Customer Summary", 
								new Font(dataGridView2.Font, FontStyle.Bold),
								Brushes.Black, e.MarginBounds.Left, 
								e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary",
									new Font(dataGridView2.Font, FontStyle.Bold),
									e.MarginBounds.Width).Height - 13);

							String strDate = DateTime.Now.ToLongDateString() + " " +
							                 DateTime.Now.ToShortTimeString();
							//Draw Date
							e.Graphics.DrawString(strDate, 
								new Font(dataGridView2.Font, FontStyle.Bold), Brushes.Black,
								e.MarginBounds.Left +
								(e.MarginBounds.Width - e.Graphics.MeasureString(strDate, 
									new Font(dataGridView2.Font, FontStyle.Bold),
									e.MarginBounds.Width).Width), 
								e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary",
									new Font(new Font(dataGridView2.Font, FontStyle.Bold), 
										FontStyle.Bold), e.MarginBounds.Width).Height - 13);

							//Draw Columns                 
							iTopMargin = e.MarginBounds.Top;
							foreach (DataGridViewColumn GridCol in dataGridView2.Columns) {
								e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),    
									new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
										(int)arrColumnWidths[iCount], iHeaderHeight));

								e.Graphics.DrawRectangle(Pens.Black,             
									new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
										(int)arrColumnWidths[iCount], iHeaderHeight));

								e.Graphics.DrawString(GridCol.HeaderText,
									GridCol.InheritedStyle.Font,
									new SolidBrush(GridCol.InheritedStyle.ForeColor),
									new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
										(int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
								iCount++;
							}
							bNewPage = false;
							iTopMargin += iHeaderHeight;
						}
						iCount = 0;
						//Draw Columns Contents                
						foreach (DataGridViewCell Cel in GridRow.Cells) {
							if (Cel.Value != null) {
								e.Graphics.DrawString(Cel.Value.ToString(),
									Cel.InheritedStyle.Font,
									new SolidBrush(Cel.InheritedStyle.ForeColor),
									new RectangleF((int)arrColumnLefts[iCount],
										(float)iTopMargin,
										(int)arrColumnWidths[iCount], (float)iCellHeight),
									strFormat);
							}
							//Drawing Cells Borders 
							e.Graphics.DrawRectangle(Pens.Black, 
								new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
									(int)arrColumnWidths[iCount], iCellHeight)); 
							iCount++;
						}
					}
					iRow++;
					iTopMargin += iCellHeight;                    
				}        
				//If more lines exist, print another page.
				if (bMorePagesToPrint)
					e.HasMorePages = true;
				else
					e.HasMorePages = false;
			} catch (Exception exc) {
				MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		
		}

	}
}