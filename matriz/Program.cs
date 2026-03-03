Console.WriteLine("bienvendo a programa");
Console.WriteLine("escriba el numero de filas a ocupar");
int n=int.Parse(Console.ReadLine());
Console.WriteLine("escriba el numero de filas a ocupar");
int m = int.Parse(Console.ReadLine());


int[,] matriz = new int[n, m];
int[,] matrizNueva = new int[n, m];
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine($"Ingrese valor para [{i},{j}]");
        matriz[i, j] = Convert.ToInt32(Console.ReadLine());

        if (matriz[i,j]% 2==0)
        {
            matrizNueva[i,j]= matriz[i, j]* 2;
        }
        else
        {
            matrizNueva [i,j]= matriz[i, j]*3;

        }
    }
}
for (int i = 0; i < matrizNueva.GetLength(0); i++)
{
    for (int j = 0; j < matrizNueva.GetLength(1); j++)
    {
        Console.Write(matrizNueva[i, j] + " ");
    }
    Console.WriteLine();
}