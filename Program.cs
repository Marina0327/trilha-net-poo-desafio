using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

//instanciando um objeto da classe NOKIA
Nokia nokia1 = new("270307","Nokia +14","IMEI785469",25);
nokia1.ReceberLigacao();
nokia1.Ligar();
nokia1.InstalarAplicativo("boomberman");

Console.WriteLine( );
//instanciando um objeto da classe SMARTPHONE

Iphone iphone1 = new("852147", "Iphone B12", "IMEI5784613", 80);
iphone1.ReceberLigacao();
iphone1.Ligar();
iphone1.InstalarAplicativo("Doulingo");