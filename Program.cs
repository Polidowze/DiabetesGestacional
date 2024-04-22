using System.Data;

Console.Clear();
int reavaliar;


Console.WriteLine("------------Diabetes gestacional------------");

Console.WriteLine("Digite a sua glicose:");

reavaliar = Convert.ToInt32(Console.ReadLine());


if(reavaliar < 92)
{
    Console.ForegroundColor = ConsoleColor.Blue;

Console.Write("reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
}

if( reavaliar < 126 && reavaliar >= 92)
{
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Compatível com Diabetes Gestacional");}
    
if(reavaliar >= 126)
{
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Diabetes Mellitus na gravidez");
}

Console.ResetColor();