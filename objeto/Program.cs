Teclado tecladoDell = new Teclado();
tecladoDell.tamanho = 15;
tecladoDell.numTeclas = 104;
tecladoDell.cor = "preto";
tecladoDell.marca = "Dell";
tecladoDell.tipo = "membrana";
tecladoDell.fio = true;
tecladoDell.led = false;

Console.WriteLine($"tamanho: {tecladoDell.tamanho}");
Console.WriteLine($"numero de teclas: {tecladoDell.numTeclas}");
Console.WriteLine($"cor: {tecladoDell.cor}");
Console.WriteLine($"marca: {tecladoDell.marca}");
Console.WriteLine($"tipo: {tecladoDell.tipo}");
Console.WriteLine($"fio? {tecladoDell.fio}");
Console.WriteLine($"led? {tecladoDell.led}");

tecladoDell.Digitar();
tecladoDell.Deletar();
tecladoDell.Enviar();
tecladoDell.TrocarTela();
tecladoDell.Capslock();

