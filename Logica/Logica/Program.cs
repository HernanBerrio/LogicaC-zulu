
//-------------1. Construir un programa que me pida un numero y luego diga si es par o no---------------------------

int num1;
Console.WriteLine("Ingrese un numero: ");
num1 = Convert.ToInt32(Console.ReadLine()); //ReadLine lee string toca convertirlo a int
 if (num1 % 2 == 0)
{
    Console.WriteLine("El número: {0} es par", num1);
}
else
{
    Console.WriteLine("El número: {0} es impar", num1);
}
 Console.ReadKey();



