using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste Nokia:");
Smartphone nokia = new Nokia(numero: "987654321", modelo: "N1", imei: "1234567890", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Waze");

Console.WriteLine("---------------");

Console.WriteLine("Teste Iphone");
Smartphone iphone = new Iphone(numero: "123456789", modelo: "i15 Pro", imei: "9876543210", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Ifood");