using System.Data;

Console.Clear();
int reavaliar;
int gravidez;
int Mellitus;


Console.WriteLine("------------Diabetes gestacional------------");

Console.WriteLine("Digite a sua glicose:");

Console.ReadLine();


Console.Write("reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
reavaliar = Convert.ToInt32(Console.ReadLine());

{
if( reavaliar <= 92)
{
    Console.ForegroundColor = ConsoleColor.Blue;
}
}

Console.Write("Compatível com Diabetes Gestacional");
gravidez = Convert.ToInt32(Console.ReadLine());

{
if(gravidez >= 92)
{
    Console.ForegroundColor = ConsoleColor.Red;
}
}

Console.Write("Compatível com Diabetes Gestacional");
gravidez = Convert.ToInt32(Console.ReadLine());
{
if( gravidez <= 126)
{
    Console.ForegroundColor = ConsoleColor.Red;
}
}

Console.Write("Compatível com Diabetes Gestacional");
Mellitus = Convert.ToInt32(Console.ReadLine());
{
if(Mellitus <= 126)
{
    Console.ForegroundColor = ConsoleColor.Green;
}
}