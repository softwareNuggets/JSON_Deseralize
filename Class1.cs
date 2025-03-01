using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newtonsoft_load_and_show_json
{
	
	public class Rootobject
	{
		public School school { get; set; }
	}

	public class School
	{
		public string name { get; set; }
		public Class1[] classes { get; set; }
	}

	public class Class1
	{
		public int class_id { get; set; }
		public string name { get; set; }
		public Teacher teacher { get; set; }
		public Schedule[] schedule { get; set; }
	}

	public class Teacher
	{
		public string name { get; set; }
		public string email { get; set; }
	}

	public class Schedule
	{
		public string day { get; set; }
		public string time { get; set; }
	}

}
