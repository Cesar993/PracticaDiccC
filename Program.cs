// Tres matrices básicas

int[] matNumeros = new int[10];

string[] nombres = new string[4];

nombres[0] = "Tim";
nombres[1] = "Martin";
nombres[2] = "Nikki" ;
nombres[3] = "Sara";


bool[] altern = new bool[10];
int largo = altern.Length +2;
for (int i = 2; i < largo; i++)
{
    if (i%2==0)
    {
        altern[i-2] = true;
    }
    else{
        altern[i-2] = false;
    }
    
}
foreach (var item in altern)
{
   /*  Console.WriteLine(item); */
}

//Lista de Sabores

List<string> sabores = new List<string>();

sabores.Add("Chocolate");
sabores.Add("Pistacho");
sabores.Add("Banana");
sabores.Add("Limon");
sabores.Add("Menta Chips");

Console.WriteLine(sabores.Count);
Console.WriteLine(sabores[2]);

sabores.RemoveAt(2);

Console.WriteLine(sabores.Count);


//Diccionario de Información del Usuario

Dictionary<string,string> info = new Dictionary<string, string>();

for (int i = 0; i < nombres.Length; i++)
{
   info.Add(nombres[i],sabores[i]);
}



foreach (var item in info)
{
    Console.WriteLine(item.Key+ " -- " + item.Value);
}