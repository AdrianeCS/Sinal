int numero;

Console.Write("digite um numero:...");
numero = Convert.ToInt32(Console.ReadLine());

if(numero< 0)
{ 
Console.WriteLine("Numero Negativo");
}
else if ( numero > 0)
{
Console.WriteLine("Numero positivo");
}
else
{
  Console.WriteLine("Numero zero");  
}
