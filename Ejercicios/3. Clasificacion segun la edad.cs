/*
Solicite la edad de una persona y clasifíquela de acuerdo con los siguientes rangos: 
de 0 a 12 años, niño; de 13 a 17 años, adolescente; de 18 a 59 años, adulto; y de 
60 años en adelante, adulto mayor. Valide que la edad ingresada no sea negativa.
*/

Console.Write("Digite su edad: ");
int age = int.Parse(Console.ReadLine());

if (age < 0){
    Console.WriteLine("La edad no puede ser negativa");
} else{
    if (age <= 12){
        Console.WriteLine("Eres un niño");
    } else if (age <= 17){
        Console.WriteLine("Eres un adolescente");
    } else if (age <= 59){
        Console.WriteLine("Eres un adulto");
    } else{
        Console.WriteLine("Eres un adulto mayor");
    }
}