Console.Clear();

Conta contaZeColmeia = new Conta("123", "Zé Colméia", 500);
contaZeColmeia.retirar(145,DateTime.Now,"Pagamento da conta de luz");
Console.WriteLine( contaZeColmeia. mostrarDados() );
Console.WriteLine();
Console.ReadKey();

Conta contaCatatau = new Conta("456", "Catatau", 340);
contaCatatau.retirar(145, DateTime.Now, "Camisera do curso");
Console.WriteLine( contaCatatau.mostrarDados() );
Console.WriteLine();
Console.ReadKey();

Console.WriteLine("Contas criadas: " + Conta.quantContas);
Console.ReadKey();

