using System;

class Car
{
    public string Name { get; set; }
    public int Engine { get; set; }
    public double MaxSpeed { get; set; }

    public Car(string name, int engine, double maxSpeed)
    {
        Name = name;
        Engine = engine;
        MaxSpeed = maxSpeed;
    }

    public override string ToString()
    {
        return Name;
    }

    //public static bool operator >(Car left, Car right)
    //{
    //    return left.Engine > right.Engine && left.MaxSpeed > right.MaxSpeed;
    //}

    //public static bool operator <(Car left, Car right)
    //{
    //    return left.Engine < right.Engine && left.MaxSpeed < right.MaxSpeed;
    //}

    //public static bool operator ==(Car left, Car right)
    //{
    //    return left.Engine == right.Engine && left.MaxSpeed == right.MaxSpeed;
    //}

    //public static bool operator !=(Car left, Car right)
    //{
    //    return !(left == right);
    //}
}

class CarComparer : IEquatable<Car>
{
    public bool Equals(Car car1, Car car2)
    {
        if (car1 == null || car2 == null)
            return false;

        return car1.Name == car2.Name && car1.Engine == car2.Engine && car1.MaxSpeed == car2.MaxSpeed;
    }

    public bool Equals(Car? other)
    {
        throw new NotImplementedException();
    }
}

class CarsCatalog
{
    private List<Car> cars;

    public CarsCatalog()
    {
        cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public Car this[int index]
    {
        get
        {
            if (index >= 0 && index < cars.Count)
                return cars[index];
            else
                throw new IndexOutOfRangeException("Index is out of range");
        }
    }
}

class lab032
{
    static void Main()
    {
        Car car1 = new Car("Normal car", 100, 180);
        Car car2 = new Car("Super - Ultra car", 10000, 10000);

        CarsCatalog catalog = new CarsCatalog();
        catalog.AddCar(car1);
        catalog.AddCar(car2);

        Console.WriteLine("Car 1: " + catalog[0].Name + " - " + catalog[0].Engine);
        Console.WriteLine("Car 2: " + catalog[1].Name + " - " + catalog[1].Engine);

        if (Equals(car1, car2))
            Console.WriteLine($"\n{car1} and {car2} are equal");
        else
            Console.WriteLine($"\n{car1} and {car2} are not equal");
    }
}
