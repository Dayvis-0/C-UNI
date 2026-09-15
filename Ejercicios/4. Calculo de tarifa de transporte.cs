/* 
Una empresa de transporte establece el precio de sus boletos según la edad del pasajero. 
Los menores de 5 años viajan gratis; de 5 a 12 años tienen un descuento del 50%; de 13 
a 59 años pagan la tarifa completa; y las personas de 60 años o más reciben un descuento 
del 40%. Solicite la edad y el precio base del boleto y determine el importe que debe 
pagar el pasajero.
*/

Console.Write("Digite su edad: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite el precio de su boleto: ");
double price = double.Parse(Console.ReadLine());

if (age < 5){
    Console.WriteLine("Viaja gratis");

} else if (age <= 12) {
    price = price - (price * 0.5);

    Console.WriteLine("Usted pagara: " + price);

} else if (age <= 59) {
    Console.WriteLine("Usted paga la tarifa completa");

} else {
    price = price - (price * 0.4);

    Console.WriteLine("Usted pagara: " + price);
}