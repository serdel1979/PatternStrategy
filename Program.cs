
using Strategy.StrategyPattern;

Console.WriteLine("Selecciona una opcion\n");
Console.WriteLine("A - Genera ruta para auto.");
Console.WriteLine("B - Genera ruta para micro.");
Console.WriteLine("C - Genera ruta para bicicleta.");
Console.WriteLine("D - Salir.");

/*
 
Por defecto se crea el contexto con una estrategia para auto (Car)

Después en tiempo de ejecución cambio a la estrategia bus (micro)

Para eso es el seter en context
 
 */

var opcion = Console.ReadLine().ToUpper();

var context = new ContextRoute();
do
{
    switch (opcion)
    {
        case "A":
            context.strategy = new RouteCar();
            context.CreateRoute();
            break;
        case "B":
            context.strategy = new RouteBus();
            context.CreateRoute();
            break;
        case "C":
            context.strategy = new RouteCicle();
            context.CreateRoute();
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }
    opcion = Console.ReadLine().ToUpper();
} while(opcion != "D");
