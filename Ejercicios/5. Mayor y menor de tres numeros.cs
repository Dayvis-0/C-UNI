/*
Solicite tres números enteros e indique cuál es el mayor, cuál es el menor y si existen 
números repetidos. Resuelva el problema utilizando estructuras condicionales y sin utilizar 
funciones de ordenamiento.
*/

Console.Write("Digite el primer numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Digite el segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Digite el tercer numero: ");
int num3 = int.Parse(Console.ReadLine());

int mayor = num1;
int menor = num1;
string repet = "";

if (num2 > num1)
{
    mayor = num2;
} else
{
    menor = num2;
}

if (num3 > mayor)
{
    mayor = num3;
} 

if (num3 < menor)
{
    menor = num3;
}

if ((num1 == num2) || (num1 == num3) || (num2 == num3))
{
    repet = "si hay repetidos";
} else
{
    repet = "no hay repetidos";
}

Console.WriteLine("El mayor es: " + mayor + ", el menor es: " + menor + ", y " + repet);