using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace OfficeInteropDemo
{
	class Program
	{
		static void Main()
		{
			
			CreateDocument();
		}

		private static void CreateDocument()
		{
			try
			{
				Application winword = new Application
				{
					ShowAnimation = false, 
					Visible = false
				};

				var document = winword.Documents.Add();

				foreach (Section section in document.Sections)
				{
					var headerRange =
						section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
					headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
					headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
					headerRange.Font.ColorIndex = WdColorIndex.wdBlue;
					headerRange.Font.Size = 10;
					headerRange.Text = "Header text goes here";
				}

				foreach (Section wordSection in document.Sections)
				{
					var footerRange =
						wordSection.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
					footerRange.Font.ColorIndex = WdColorIndex.wdDarkRed;
					footerRange.Font.Size = 10;
					footerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
					footerRange.Text = "Footer text goes here";
				}

				document.Content.SetRange(0, 0);
				document.Content.Text = "This is test document " + Environment.NewLine;

				//Add paragraph with Heading 1 style
				var para1 = document.Content.Paragraphs.Add();
				object styleHeading1 = "Heading 1";
				para1.Range.set_Style(ref styleHeading1);
				para1.Range.Text = "Para 1 text";
				para1.Range.InsertParagraphAfter();

				//Add paragraph with Heading 2 style
				var para2 = document.Content.Paragraphs.Add();
				object styleHeading2 = "Heading 2";
				para2.Range.set_Style(ref styleHeading2);
				para2.Range.Text = "Para 2 text";
				para2.Range.InsertParagraphAfter();

				//Create a 5X5 table and insert some dummy record
				Table firstTable = document.Tables.Add(para1.Range, 5, 5);

				firstTable.Borders.Enable = 1;
				foreach (Row row in firstTable.Rows)
				{
					foreach (Cell cell in row.Cells)
					{
						//Header row
						if (cell.RowIndex == 1)
						{
							cell.Range.Text = "Column " + cell.ColumnIndex;
							cell.Range.Font.Bold = 1;
							//other format properties goes here
							cell.Range.Font.Name = "verdana";
							cell.Range.Font.Size = 10;
							//cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                            
							cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
							//Center alignment for the Header cells
							cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
							cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

						}
						//Data row
						else
						{
							cell.Range.Text = (cell.RowIndex - 2 + cell.ColumnIndex).ToString();
						}
					}
				}

				//Save the document
				object filename = @"c:\teste\temp1.docx";
				document.SaveAs2(ref filename);
				document.Close();
				document = null;
				winword.Quit();
				winword = null;
				MessageBox.Show("Document created successfully !");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
