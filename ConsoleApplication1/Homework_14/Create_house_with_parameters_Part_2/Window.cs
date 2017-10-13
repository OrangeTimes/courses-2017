using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_house_with_parameters_Part_2
{
	class Window
	{
		public string windowModel;
		public int numbersOfCameras;
		public double windowHight;
		public double windowWidth;

		public Window (string windowModel, int numbersOfCameras, double windowHight, double windowWidth)
		{
			this.windowModel = windowModel;
			this.numbersOfCameras = numbersOfCameras;
			this.windowHight = windowHight;
			this.windowWidth = windowWidth;
		}
		public static void outputWindow(Window Window)
		{
			Console.WriteLine($"Window Model: {Window.windowModel} / Window numbers of cameras: {Window.numbersOfCameras} / Window hight: {Window.windowHight} / Window width: {Window.windowWidth}.");
		}
	}
}
