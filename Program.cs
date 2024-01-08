using DesafioPOO.Models;

// FEITO COM SUCESSO
Console.Clear();

Console.WriteLine("Smartphone NOKIA");
Smartphone nokia = new Nokia(numero: "123456", modelo: "NOKIA C20", imei: "1212121212", tamanho: 128);
nokia.Ligar();
nokia.InstalarAplicativo("DBZ BUDOKAI TENKAICHI 3");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Iphone 14", imei: "2323232323", tamanho: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("PSPP JOGOS DE PLAYSTANTIO 2");