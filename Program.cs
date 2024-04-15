
using Strategy.StrategyPattern;

Console.WriteLine("Selecciona una opcion\n");
Console.WriteLine("A - Genera ruta para auto.");
Console.WriteLine("B - Genera ruta para micro.");

var opcion = Console.ReadLine();

if(opcion != null)
{
    if(opcion == "A")
    {
        var context =  new ContextRoute(new RouteCar());
        context.CreateRoute();
    }
    else if (opcion == "B") 
    {
        var context = new ContextRoute(new RouteBus());
        context.CreateRoute();
    }
    else
    {
        Console.WriteLine("Opción inválida.");
    }
}