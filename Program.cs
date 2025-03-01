using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newtonsoft_load_and_show_json
{
	public class Program
	{
		static void Main(string[] args)
		{
			string filename = @"D:\YOUTUBE\C#\Newtonsoft_load_and_show_json\school.json";

			if (!System.IO.File.Exists(filename))
			{
				Console.WriteLine(
					string.Format($"{filename} - file does not exist"));
				return;
			}

			//read the file .. it's just a file right now, but looks like json data
			string jsonText = File.ReadAllText(filename);

			// read json file, deserialize the text, that looks like JSON format into a c# object of type Rootobject
			var root = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(jsonText);

			Console.WriteLine($"School Name: {root.school.name}");

			if (root != null && root.school != null && root.school.classes != null)
			{
				foreach (Class1 classObj in root.school.classes)
				{
					Console.WriteLine($"Class Name: {classObj.name}");
					Console.WriteLine($"Teacher Name: {classObj.teacher.name}");
					Console.WriteLine();

					if (classObj.schedule != null)
					{
						foreach (Schedule scheduleItem in classObj.schedule)
						{
							Console.WriteLine($"Class: {classObj.name}, Day: {scheduleItem.day}, Time: {scheduleItem.time}");
						}
					}
					Console.WriteLine();
				}
			}

		}
	}
}
