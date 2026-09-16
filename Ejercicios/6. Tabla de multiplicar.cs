/*
Solicite al usuario un número entero y genere su tabla de multiplicar del 1 al 12. 
Utilice un ciclo for para realizar el proceso.
*/

Console.Write("Digite un numero: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine(i + " x " + num + " = " + (num * i));
}