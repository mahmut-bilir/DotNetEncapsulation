// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Car car = new Car();
car.Barand = "BMW";
// car.speed=100; // Error!, "speed" is private so it cannot be accessed
car.SetSpeed(100);//Speed adjustable