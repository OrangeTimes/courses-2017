using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_house_with_parameters_Part_2
{
	class Roof
	{
		public string roofMaterial;
		public string roofForm;
		public Roof(string roofMaterial, string roofForm)
		{
			this.roofMaterial = roofMaterial;
			this.roofForm = roofForm;
		}
		public static void outputRoof(Roof Roof) // no need of this static method
		{
			Console.WriteLine($"Roof material: {Roof.roofMaterial} / Roof form: {Roof.roofForm}.");
		}
	}
}
