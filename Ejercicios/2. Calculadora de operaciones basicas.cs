/*
Solicite al usuario dos números reales y un operador aritmético (+, -, *, /). 
El programa debe realizar la operación correspondiente y mostrar el resultado. 
Valide la división entre cero y los operadores no válidos. Utilice la estructura switch.
*/

Console.Write("Ingrese el primer numero: ");
float number1 = float.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
float number2 = float.Parse(Console.ReadLine());

Console.Write("Ingrese un operador aritmetico: ");
String operador = Console.ReadLine();
double resulnum = 0;
String resul = "";

switch (operador) {
    case "+":
        resulnum = number1 + number2;
        resul = "suma";
        break;
    case "-":
        resulnum = number1 - number2;
        resul = "resta";
        break;
    case "*":
        resulnum = number1 * number2;
        resul = "multiplicacion";
        break;
    case "/":
        if (number2 == 0) {
            Console.WriteLine("La division entre cero no esta definido");
        } else {
            resulnum = number1 / number2;
            resul = "division";
        }
        break;

    default:
        Console.WriteLine("Error el operador no es valido");
        break;
}

if (!(operador == "/" & number2 == 0)){
    Console.WriteLine("La " + resul + " es: " + resulnum);
}