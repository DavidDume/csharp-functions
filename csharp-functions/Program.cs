// See https://aka.ms/new-console-template for more information
void StampaArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        } else
        {
            Console.Write($"{array[i]}");
        }
        
    }
    Console.WriteLine("]");
}

int[] arr = { 1, 2, 3, 4, 5, 6 };

StampaArray(arr);

int Quadrato(int numero)
{
    return numero * numero;
}
Console.WriteLine(Quadrato(16));

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copia = (int[])array.Clone();
    for (int i = 0; i < copia.Length; i++) {
        copia[i] *= copia[i];
    }
    return copia;
}

StampaArray(ElevaArrayAlQuadrato(arr));