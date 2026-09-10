Console.WriteLine("Hello world");
Console.WriteLine("*****************");
Console.WriteLine("Bienvenido a C#");
Console.WriteLine("*****************");

Console.Write("Ingrese el nombre: ");
String name = Console.ReadLine();

Console.Write("Ingrese su edad: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Ingrese su direccion: ");
String addr = Console.ReadLine();

Console.Write("Ingrese su correo: ");
String mail = Console.ReadLine();

Console.WriteLine($"""
    Nombre: {name}
    Edad: {age}
    Dirección: {addr}
    Correo: {mail}
""");