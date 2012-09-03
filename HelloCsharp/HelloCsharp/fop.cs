using System;
using System.IO;

namespace HelloCsharp
{
	public class fop
	{
		public fop ()
		{
		}

		//text file operation
		public void FileTextOp()
		{
			StreamWriter writer = File.CreateText("example.txt");
			writer.WriteLine("text file example!");
			writer.Flush();
			writer.Close();

			StreamReader reader = File.OpenText("example.txt");
			String content = reader.ReadLine();
			Console.WriteLine(content);
			reader.Close();
		}
	}
}

