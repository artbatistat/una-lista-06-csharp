var matriz = new int [3,2];

for(int i = 0; i < 3;i++)
{
     for(int j = 0; j < 2; j++)
    {
        Console.WriteLine("Digite um valor para a linha {0} da coluna {1} matriz:",(i+1),(j+1));
        matriz[i,j] = Convert.ToInt16(Console.ReadLine());
    }

}

for(int i = 0; i < 3;i++)
{
     for(int j = 0; j < 2; j++)
    {
        Console.WriteLine("Posição: {0},{1} \nValor: {2}",(i+1),(j+1),matriz[i,j]);
    }

}

Console.ReadLine();

