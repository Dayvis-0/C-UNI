**Ejercicios Propuestos de C\#**

Para los siguientes ejercicios analice y diseñe un programa en C\#.

1. **Clasificación de un número**  
   Desarrolle un programa en C\# que solicite al usuario un número entero y determine si es positivo, negativo o cero. Además, indique si el número es par o impar. Utilice estructuras condicionales if, else if y else.

2. **Calculadora de operaciones básicas**  
   Solicite al usuario dos números reales y un operador aritmético (+, -, \*, /). El programa debe realizar la operación correspondiente y mostrar el resultado. Valide la división entre cero y los operadores no válidos. Utilice la estructura switch.

3. **Clasificación según la edad**  
   Solicite la edad de una persona y clasifíquela de acuerdo con los siguientes rangos: de 0 a 12 años, niño; de 13 a 17 años, adolescente; de 18 a 59 años, adulto; y de 60 años en adelante, adulto mayor. Valide que la edad ingresada no sea negativa.

4. **Cálculo de tarifa de transporte**  
   Una empresa de transporte establece el precio de sus boletos según la edad del pasajero. Los menores de 5 años viajan gratis; de 5 a 12 años tienen un descuento del 50 %; de 13 a 59 años pagan la tarifa completa; y las personas de 60 años o más reciben un descuento del 40 %. Solicite la edad y el precio base del boleto y determine el importe que debe pagar el pasajero.

5. **Mayor y menor de tres números**  
   Solicite tres números enteros e indique cuál es el mayor, cuál es el menor y si existen números repetidos. Resuelva el problema utilizando estructuras condicionales y sin utilizar funciones de ordenamiento.

6. **Tabla de multiplicar**  
   Solicite al usuario un número entero y genere su tabla de multiplicar del 1 al 12. Utilice un ciclo for para realizar el proceso.

7. **Suma de números hasta ingresar cero**  
   Solicite números enteros de manera continua. El programa debe acumular la suma de los números ingresados y finalizar cuando el usuario introduzca el número 0\. Al finalizar, muestre la cantidad de números ingresados, la suma total y el promedio.

8. **Juego: Adivina el número**  
   Genere aleatoriamente un número entre 1 y 100\. El usuario deberá intentar adivinarlo. Después de cada intento, indique si el número buscado es mayor o menor que el valor ingresado. Cuando el usuario acierte, muestre la cantidad de intentos realizados.

9. **Números primos**  
   Solicite un número entero positivo y determine si es primo. Posteriormente, modifique el programa para mostrar todos los números primos comprendidos entre 1 y el número ingresado. Utilice estructuras repetitivas.

10. **Menú interactivo**  
    Desarrolle un programa que muestre repetidamente el siguiente menú:

* Mostrar saludo.  
* Mostrar fecha actual.  
* Calcular el cuadrado de un número.  
* Mostrar tabla de multiplicar.  
* Salir.  
  El programa debe continuar ejecutándose hasta que el usuario seleccione la opción 5. Utilice do-while y switch.

11. **Funciones matemáticas**  
    Cree un programa que contenga funciones independientes para sumar, restar, multiplicar y dividir dos números. Cada función debe recibir los parámetros correspondientes y devolver el resultado. El programa principal debe permitir seleccionar la operación mediante un menú.

12. **Función para determinar números primos**  
    Implemente una función denominada EsPrimo(int numero) que devuelva true si el número recibido es primo y false en caso contrario. Utilice esta función para mostrar todos los números primos existentes dentro de un rango determinado.

13. **Conversor de unidades**  
    Desarrolle un programa que permita realizar las siguientes conversiones: Celsius a Fahrenheit, Fahrenheit a Celsius, kilómetros a millas y millas a kilómetros. Implemente una función independiente para cada tipo de conversión.

14. **Estadísticas de un conjunto de números**  
    Solicite al usuario una cantidad N de números y almacénelos en un arreglo. Implemente funciones independientes para calcular la suma, el promedio, el valor mayor y el valor menor. Muestre todos los resultados en pantalla.

15. **Validador de contraseñas**  
    Cree una función llamada EsContrasenaValida(string contrasena). Una contraseña será válida si contiene al menos 8 caracteres, una letra mayúscula, una letra minúscula y un número. El programa debe solicitar una contraseña y determinar si cumple todos los requisitos.

16. **Estadísticas de un arreglo**  
    Solicite al usuario 10 números enteros y almacénelos en un arreglo. Determine la suma, el promedio, el mayor, el menor, la cantidad de números pares y la cantidad de números impares. Utilice funciones para realizar cada operación.

17. **Búsqueda de elementos en un arreglo**  
    Cree un arreglo de números enteros y solicite al usuario un número que desea buscar. El programa debe indicar si el número existe, las posiciones donde aparece y cuántas veces se repite. No utilice Array.IndexOf(); implemente la búsqueda mediante ciclos.

18. **Ordenamiento de un arreglo**  
    Solicite al usuario una cantidad N de números enteros y almacénelos en un arreglo. Ordene los elementos de menor a mayor utilizando el algoritmo Bubble Sort. Posteriormente, modifique el programa para ordenar los elementos de mayor a menor. No utilice métodos de ordenamiento incorporados.

19. **Gestión de calificaciones de estudiantes**  
    Desarrolle un programa que permita registrar los nombres y calificaciones finales de un grupo de estudiantes. El programa debe mostrar el promedio general, el estudiante con mayor calificación, el estudiante con menor calificación, la cantidad de estudiantes aprobados y la cantidad de estudiantes desaprobados.

20. **Matriz de ventas**  
    Una empresa registra las ventas de cuatro vendedores durante siete días. Utilice una matriz de dimensiones \[4,7\], donde cada fila represente un vendedor y cada columna represente un día. Calcule el total vendido por cada vendedor, el total vendido por cada día, el vendedor con mayor venta, el día con mayor venta y el total general de ventas.

21. **Clase Persona**  
    Cree una clase denominada Persona con las propiedades Nombre, Apellido y Edad. Implemente un constructor, un método MostrarInformacion() y un método EsMayorDeEdad() que devuelva true o false. Desde el método Main, cree al menos tres objetos de la clase y muestre su información.

22. **Clase CuentaBancaria**  
    Diseñe una clase CuentaBancaria que contenga las propiedades NumeroCuenta, Titular y Saldo. Implemente los métodos Depositar(), Retirar() y MostrarSaldo(). Valide que no se puedan realizar depósitos negativos, retiros superiores al saldo disponible ni operaciones que generen un saldo negativo.

23. **Sistema de estudiantes mediante POO**  
    Cree una clase Estudiante con las propiedades Codigo, Nombre, Carrera, Nota1, Nota2 y Nota3. Implemente métodos para calcular el promedio, determinar si el estudiante aprobó y mostrar su información. Posteriormente, cree una lista de estudiantes y determine cuál obtuvo el promedio más alto.

24. **Producto y control de inventario**  
    Diseñe una clase Producto con las propiedades Codigo, Nombre, Precio y Stock. Implemente los métodos AgregarStock(), Vender(), CalcularValorInventario() y MostrarInformacion(). Valide que el precio y el stock no sean negativos y que no se pueda vender una cantidad superior al stock disponible.

25. **Sistema de empleados**  
    Cree una clase Empleado con las propiedades Id, Nombre y SueldoBase. Implemente métodos para calcular el sueldo, aplicar un bono y mostrar la información del empleado. Registre varios empleados utilizando List\<Empleado\> y determine cuál posee el sueldo final más alto.

26. **Sistema de vehículos: herencia y polimorfismo**  
    Cree una clase base Vehiculo con las propiedades Marca, Modelo y Anio, además de un método MostrarInformacion(). Cree las clases derivadas Automovil, Motocicleta y Camion. Cada clase debe sobrescribir el método de información utilizando virtual y override. Finalmente, almacene los diferentes vehículos en una lista y muestre su información mediante polimorfismo.

27. **Sistema de empleados con diferentes tipos**  
    Cree una clase abstracta Empleado que contenga las propiedades Nombre e Id y un método abstracto CalcularSalario(). Cree las clases EmpleadoTiempoCompleto, EmpleadoPorHoras y EmpleadoComision. Cada clase deberá implementar su propia forma de calcular el salario. Utilice una List\<Empleado\> para almacenar y procesar todos los empleados.

28. **Sistema de figuras geométricas**  
    Diseñe una clase abstracta Figura con un método CalcularArea(). Cree las clases Circulo, Rectangulo y Triangulo, implementando en cada una la fórmula correspondiente para calcular el área. Almacene diferentes figuras en una lista y utilice polimorfismo para calcular y mostrar sus áreas. Como desafío adicional, implemente el método CalcularPerimetro().

29. **Sistema de biblioteca**  
    Desarrolle un sistema para administrar una biblioteca. El programa debe incluir las clases Libro, Usuario y Biblioteca. La clase Libro debe contener ISBN, Titulo, Autor y Disponible. La clase Usuario debe contener Id y Nombre. La clase Biblioteca debe permitir registrar libros y usuarios, buscar libros por título, prestar libros, devolver libros, mostrar libros disponibles y mostrar libros prestados. Utilice clases, objetos, encapsulamiento, constructores y List\<T\>. Como desafío adicional, impida que un usuario tenga más de tres libros prestados simultáneamente.

30. **Proyecto integrador: Sistema de ventas e inventario**  
    Desarrolle un sistema completo para administrar las ventas e inventario de una pequeña tienda. El sistema debe implementar, como mínimo, las clases Producto, Cliente, Venta y DetalleVenta. El producto debe contener código, nombre, precio y stock; el cliente debe contener identificación, nombre y documento; y la venta debe registrar cliente, fecha, productos vendidos, cantidades, subtotal, impuesto y total.

    El sistema deberá presentar un menú con las siguientes opciones:

1. Registrar producto.  
2. Listar productos.  
3. Registrar cliente.  
4. Registrar venta.  
5. Buscar producto.  
6. Consultar stock.  
7. Mostrar ventas.  
8. Mostrar reporte de ventas.  
9. Salir.

   El proyecto debe aplicar variables, estructuras condicionales, estructuras repetitivas, funciones, arreglos o listas, clases y objetos, encapsulamiento, constructores, herencia cuando sea apropiada, polimorfismo, validación de datos y manejo básico de excepciones mediante try-catch. Como desafío final, implemente el almacenamiento de información mediante archivos de texto o archivos JSON para conservar los datos después de cerrar el programa.

