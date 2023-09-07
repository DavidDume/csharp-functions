// See https://aka.ms/new-console-template for more information

Console.WriteLine("Quanti elementi inserire?");
int nElementi = int.Parse(Console.ReadLine());
int[] arr = new int[nElementi];
for (int i = 0; i < nElementi; i++)
{
    Console.WriteLine($"Inserire il {i+1} numero:");
    arr[i] = int.Parse(Console.ReadLine());
}
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

Console.WriteLine("Array: ");
StampaArray(arr);

int Quadrato(int numero)
{
    return numero * numero;
}
Console.WriteLine("Quadrato di 16: " + Quadrato(16));

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copia = (int[])array.Clone();
    for (int i = 0; i < copia.Length; i++) {
        copia[i] *= copia[i];
    }
    return copia;
}

Console.WriteLine("Array modificato un i valori elevati al quadrato:");
StampaArray(ElevaArrayAlQuadrato(arr));
Console.WriteLine("Array originale è rimasto invariato:");
StampaArray(arr);
int sommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0;i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;

}
Console.WriteLine("Somma di tutti gli elementi dell'array: ");
Console.WriteLine(sommaElementiArray(arr));
Console.WriteLine("Il quadrato della somma di tutti gli elementi dell'array: ");
Console.WriteLine(Quadrato(sommaElementiArray(arr)));