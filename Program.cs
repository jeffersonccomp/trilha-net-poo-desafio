using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "112222", modelo:"h122", imei:"120098", memoria: 64);
         
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatzap");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "135569", modelo:"iphone10", imei:"55555", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatzap");