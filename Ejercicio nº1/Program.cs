Console.Clear();
Console.WriteLine("Buenas, por favor ingrese su nombre");
Console.WriteLine();
string nombre = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("¡Hola " + nombre + "!");
Console.WriteLine();
Console.WriteLine("Esto es todo lo que hace este programa, si desea ingresar" +
    " otro nombre o simplemente quiere repetirlo, ingrese S, si desea cerrar el programa, ingrese N");
Console.WriteLine();
string Finalizar = Console.ReadLine();
while (Finalizar.ToUpper() == "S")
{
    Console.Clear();
    Console.WriteLine("Buenas, por favor ingrese su nombre");
    Console.WriteLine();
    nombre = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("¡Hola " + nombre + "!");
    Console.WriteLine();
    Console.WriteLine("Esto es todo lo que hace este programa, si desea ingresar" +
        " otro nombre o simplemente quiere repetirlo, ingrese S, si desea cerrar el programa, ingrese N");
    Console.WriteLine();
    Finalizar = Console.ReadLine();
}

if (Finalizar.ToUpper() == "N")
{
    Console.WriteLine();
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.Clear();
    Console.WriteLine("Opción no válida");
}

