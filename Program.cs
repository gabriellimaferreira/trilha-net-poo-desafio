using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Executando teste no Nokia");
Smartphone nokia = new Nokia(numero: "11976778738", modelo: "tijolão", imei: "123456789", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Nubank");

Console.WriteLine("Executando teste no Iphone");
Smartphone iphone = new Iphone(numero: "9120398388", modelo: "5c", imei: "873737282", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("NetFlix");