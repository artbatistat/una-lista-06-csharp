var marca = new string [4];

for(int i = 0; i < 4;i++)
{
    Console.WriteLine("Digite uma marca de carro:");
    marca[i] = Console.ReadLine();
}

Console.WriteLine("Nomes inseridos no sistema:");
for(int i = 0; i < 4;i++)
{
   Console.WriteLine(marca[i].ToUpper());
}

Console.ReadLine();