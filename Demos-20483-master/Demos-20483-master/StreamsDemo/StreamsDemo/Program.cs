using System;
using System.IO;
using System.Text;

namespace StreamsDemo
{
	class Program
	{
		static void Main()
		{
			BinaryWriter();
			BinaryReader();

			StreamWriter();
			StreamReader();

			Console.Read();
		}

		static void BinaryReader()
		{
			string sourceFilePath = "D:\\settings.bin ";
			var sourceFile = new FileStream(
				sourceFilePath,
				FileMode.Open,
				FileAccess.Read);

			var reader = new BinaryReader(sourceFile);
			int position = 0;
			int length = (int)reader.BaseStream.Length;
			byte[] dataCollection = new byte[length];
			int returnedByte;
			while ((returnedByte = reader.Read()) != -1)
			{
				dataCollection[position] = (byte)returnedByte;
				position += sizeof(byte);
			}

			foreach (var item in dataCollection)
			{
				Console.WriteLine(item);
			}
			reader.Close();
			sourceFile.Close();
		}

		static void BinaryWriter()
		{
			string destinationFilePath = "D:\\settings.bin";
			byte[] dataCollection = { 1, 4, 6, 7, 12, 33, 26, 98, 82, 101 };
			FileStream destFile = new FileStream(
				destinationFilePath,
				FileMode.Create,
				FileAccess.Write);

			BinaryWriter writer = new BinaryWriter(destFile);
			foreach (byte data in dataCollection)
			{
				writer.Write(data);
			}
			writer.Close();
			destFile.Close();
		}

		static void StreamReader()
		{
			string sourceFilePath = @"D:\settings.txt ";
			var sourceFile = new FileStream(
				sourceFilePath,
				FileMode.Open,
				FileAccess.Read);
				

			var reader = new StreamReader(sourceFile);
			var fileContents = new StringBuilder();
			while (reader.Peek() != -1)
			{
				fileContents.Append((char)reader.Read();
			}
			string data = fileContents.ToString();
			Console.WriteLine(data);
			reader.Close();
			sourceFile.Close();
		}

		static void StreamWriter()
		{
			string destinationFilePath = @"D:\settings.txt ";
			string data = "Hello, this will be written in plain text";

			using (var destFile = new FileStream(
				destinationFilePath, 
				FileMode.Create, 
				FileAccess.Write))
			using (var writer = new StreamWriter(destFile))
			{
				writer.WriteLine(data);
			}
		}
	}
}
