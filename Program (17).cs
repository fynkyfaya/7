int carNumber = int.Parse(Console.ReadLine());

Car[] cars = new Car[carNumber];
for (var i = 0; i < carNumber; i++)
{
    Car car = new Car();
    car.brandName = Console.ReadLine();
    car.producerName = Console.ReadLine();
    car.carType = Console.ReadLine();
    car.issueYear = int.Parse(Console.ReadLine());
    car.registrationDate = new DateOnly(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    cars[i] = car;
}

foreach (Car car in cars)
{
    if (car.brandName == "Ford" && car.registrationDate < new DateOnly(2000, 1, 1))
    {
        Console.WriteLine(car.producerName);
        Console.WriteLine(car.carType);
        Console.WriteLine(car.issueYear);
        Console.WriteLine();
    }
}



struct Car
{ 
    public string brandName;
    public string producerName;
    public string carType;
    public int issueYear;
    public DateOnly registrationDate;

    public Car(string brandName, string producerName, string carType, int issueYear, DateOnly registrationDate)
    {
        this.brandName = brandName;
        this.producerName = producerName;
        this.carType = carType;
        this.issueYear = issueYear;
        this.registrationDate = registrationDate;
    }
}