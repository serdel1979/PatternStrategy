
using Strategy.StrategyPattern;

Console.WriteLine("Selecciona una opcion\n");
Console.WriteLine("A - Genera ruta para auto.");
Console.WriteLine("B - Genera ruta para micro.");

/*
 
Por defecto se crea el contexto con una estrategia para auto (Car)

Después en tiempo de ejecución cambio a la estrategia bus (micro)

Para eso es el seter en context
 
 */

var opcion = Console.ReadLine();

var context = new ContextRoute(new RouteCar());

if (opcion != null)
{
    if(opcion == "A")
    {
        context.CreateRoute();
    }
    else if (opcion == "B") 
    {
        context.strategy = new RouteBus();
        context.CreateRoute();
    }
    else
    {
        Console.WriteLine("Opción inválida.");
    }
}