using System.Collections.Generic;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace ExcelInteropDemo
{
	class Program
	{
		public class Pessoa
		{
			public string Nome { get; set; }
			public string Sobrenome { get; set; }
		}

		static void Main()
		{
			var pessoas = new List<Pessoa>
			{
				new Pessoa {Nome = "Beltrano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Fulano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Sicrano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Beltrano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Fulano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Sicrano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Beltrano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Fulano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Sicrano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Beltrano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Fulano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Sicrano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Beltrano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Fulano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Sicrano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Beltrano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Fulano", Sobrenome = "de Tal"},
				new Pessoa {Nome = "Sicrano", Sobrenome = "de Tal"},
			};

			var excel = new Application { DisplayAlerts = false };
			var workBook = excel.Workbooks.Add();
			Worksheet workSheet = workBook.Sheets.Add();

			workSheet.Name = "Pessoas";
			workSheet.Cells[1, "A"] = "Nome";
			workSheet.Cells[1, "B"] = "Sobrenome";

			int row = 2;
			foreach (var pessoa in pessoas)
			{
				workSheet.Cells[row, "A"] = pessoa.Nome;
				workSheet.Cells[row, "B"] = pessoa.Sobrenome;
				row++;
			}
			workSheet.UsedRange.Columns.AutoFit();
			workSheet.UsedRange.AutoFormat(XlRangeAutoFormat.xlRangeAutoFormatList1);


			if (!Directory.Exists(@"C:\Excel"))
			{
				Directory.CreateDirectory(@"C:\Excel");
			}

			workBook.SaveAs(@"C:\Excel\pessoas.xlsx");
			excel.Visible = true;
			workBook.Activate();
		}
	}
}
