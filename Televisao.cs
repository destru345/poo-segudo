public class Televisao
{
    public Televisao (float tamanho)
    {
        Tamanho = tamanho;
    }

    public float Tamanho { set;}
    public int Resucao {get; set;}
    public int Volume {get; private set;}
    public int Canal {get; set;}
    public bool Estado {get; set;}

    public void AumentarVolume()
    {
        if(Volume < 100)
            Volume = volume + 1;
        else 
            Console.WriteLine("TV já está no máximo.");
    }
}