using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia (numero: "22232425",modelo:"Nokia G60", imei: "122333444455550", memoria: 512 );
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone (numero: "32333435",modelo:"Iphone 16 pro", imei: "478512369856214", memoria: 256 );
nokia.Ligar();
nokia.InstalarAplicativo(" YouTube ");
