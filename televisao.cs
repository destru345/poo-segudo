public class televisao
{
    public televisao (float tamanho)
    {
        Tamanho = tamanho;
    }

    public float Tamanho{get; set;}
    public int Resucao{get; set;}
    public int Volume{get; set;}
    public int Canal{get; set;}
    public bool Estado {get; set;}

    public void AumentarVolume()
    {
      Volume = volume = 1;
    }
}