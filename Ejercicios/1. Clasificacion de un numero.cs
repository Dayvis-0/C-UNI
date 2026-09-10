/*
Desarrolle un programa en C# que solicite al usuario un número entero y determine si 
es positivo, negativo o cero. Además, indique si el número es par o impar. Utilice 
estructuras condicionales if, else if y else
*/

int number = 0;
Console.Write("Ingrese el numero: ");
number = Convert.ToInt32(Console.ReadLine());
String posinega = "";
String parimpar = "";

if (number > 0) {
    posinega = "positivo";
} else if (number == 0) {
    posinega = "cero";
} else {
    posinega = "negativo";
}

if (number % 2 == 0) {
    parimpar = "par";
} else {
    parimpar = "impar";
}

Console.WriteLine("El numero " + number + " es " + parimpar + " y " + posinega);