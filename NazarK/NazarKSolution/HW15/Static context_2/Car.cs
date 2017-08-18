namespace Static_context_2
{
	public class Car
	{
		private string color;
		private double price;

		// create new Car using constructor if it passes some validation
		public static Car Create(string color, double price)
		{
			if (color.ToLower() == "red")
			{
				return new Car(color, price);
			}
			else
				return null;
		}

		// private constructor which can be used only internally
		private Car(string color, double price)
		{
			this.color = color;
			this.price = price;
		}
	}
}