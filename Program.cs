// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

televisao tv = new televisao(55f);

Console.WriteLine($"A tv tem o tamanho {tv.Tamanho}");

tv.AumentarVolume();
Console.Writeline($"Volume {tv.Volume}");

tv.AumentarVolume();
Console.Writeline($"Volume {tv.Volume}");

tv.AumentarVolume();
Console.Writeline($"Volume {tv.Volume}");