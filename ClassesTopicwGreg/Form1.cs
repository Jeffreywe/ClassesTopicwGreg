using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesTopicwGreg {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

    }
}
namespace ClassesTopic {

	/*
	 classes
	 3 things go inside classes, 
	 1 is data/properties of the class
	 2 is actions/methods on the class
	*/

	//syntax for class example

	public class Student {
		public string Name { get; set; }//means other classes can read and write from this one 

		private bool IsVeteran { get; set; } //properties / unique pieces of data

		public string Zipcode { get; set; }

		public void Print() {
			Console.WriteLine($"Student's name is {Name} and zip is {Zipcode}");
		}
		public static void Run() {
			Student Jeff = new Student(); //instances
			Jeff.Name = "Jeff"; //properties
			Jeff.Zipcode = "12345";

			Student Philip = new Student();
			Philip.Name = "Philip";
			Philip.Zipcode = "98765";

			Jeff.Print(); //executes the method .Print() of the property Jeff
			Philip.Print();
		}
	}
}
/*
public class Teacher {

public static void Run() {
	Student Greg = new Student();
	Greg.Name == "Greg";
	Greg.IsVeteran = true; //false because does not have access to veteran property from Student Class due to private
	}
}

// methods
*/