using System;

CuentaBancaria cuenta1 = new CuentaBancaria("Ana", 500m);
CuentaBancaria cuenta2 = new CuentaBancaria("Luis", 300m);

cuenta1.MostrarResumen();
cuenta2.MostrarResumen();

Console.WriteLine("\nDepósito de 200 a cuenta1");
cuenta1.Depositar(200m);
cuenta1.MostrarResumen();
