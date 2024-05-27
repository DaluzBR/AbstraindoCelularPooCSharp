using AbstraindoCelularPoo.Models;

Console.WriteLine("============ Smartphone Nokia ============\n");

Nokia nokia = new("021 9 8456-3218", "NK095", "1234567895", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.ListarContatos();
nokia.MostrarSobre();
nokia.InstalarAplicativo("Snake Game");

Console.WriteLine("\n");

Console.WriteLine("============ Smartphone Iphone ============\n");
Iphone iphone = new("021 9 8956-4826", "Apple iPhone 13 (256GB)", "1256845864", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.ListarContatos();
iphone.MostrarSobre();
iphone.InstalarAplicativo("I Dig It");

Console.WriteLine("\n");

Console.WriteLine("============ Smartphone Samsung ============\n");
Samsung samsung = new("021 9 8456-3218", "A05", "7854263595", 128);
samsung.Ligar();
samsung.ReceberLigacao();
samsung.ListarContatos();
samsung.MostrarSobre();
samsung.InstalarAplicativo("Modern PTE");