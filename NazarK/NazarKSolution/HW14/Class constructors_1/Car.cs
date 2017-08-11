namespace Class_constructors_1
{
	class Car
	{
		private string manufacturer;
		private int yearOfManufacture;
		private double price;

		// Add constructor with 3 parameters
		public Car(string manufacturer, int yearOfManufacture, double price)
		{
			this.manufacturer = manufacturer;
			this.yearOfManufacture = yearOfManufacture;
			this.price = price;
		}

		// Override ToString to print values
		public override string ToString()
		{
			return ($"Manufacturer: {manufacturer}, Year of manufacture: {yearOfManufacture}, Price: {price}.");
		}
	}
}
