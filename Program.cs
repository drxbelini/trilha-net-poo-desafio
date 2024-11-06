using DesafioPOO.Models;

Smartphone nokia = new Nokia( numero:"(14)981721223", modelo:"A21", imei:"N123456", memoria:6400);
Smartphone iphone = new Iphone(numero:"(14)981317751", modelo:"iphone11", imei:"IPH123456789", 12800);


Console.WriteLine("SmartPhone Nokia");
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("SmartPhone Iphone");
iphone.Ligar();
iphone.InstalarAplicativo("Telegran");


