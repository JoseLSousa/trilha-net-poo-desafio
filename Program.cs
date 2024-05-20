using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia NokiaTijolao = new(numero: "40028922", modelo: "1100", imei: "imei1234", memoria: 2);
Iphone Iphone5 = new(numero: "40028922", modelo: "Iphone5s", imei: "imei4532", memoria: 4);


NokiaTijolao.Ligar();
NokiaTijolao.ReceberLigacao();
NokiaTijolao.InstalarAplicativo("WhatsApp");


Iphone5.Ligar();
Iphone5.InstalarAplicativo("Facebook");
Iphone5.ReceberLigacao();