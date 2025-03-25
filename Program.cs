// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");
Car car = new Car();
car.Barand = "BMW";
// car.speed=100; // Error!, "speed" is private so it cannot be accessed
car.SetSpeed(100);//Speed adjustable

Minibus minibus = new Minibus();
minibus.Speed = 100;
Console.WriteLine("Minibus speed:" + minibus.Speed);

Truck truck = new Truck();

//truck.Barand="Fiat"; Error! "Brand" is read only
Console.WriteLine("Truck brand : " + truck.Barand);
User user = new User();
user.Password = "123456";
//Console.WriteLine("password : "+user.Password); Error! Password can only be written.

Bicycle bicycle = new Bicycle();
bicycle.Speed = 120;
Console.WriteLine("Bicycle speed : " + bicycle.Speed);

Console.WriteLine("User name : " + user.Name);