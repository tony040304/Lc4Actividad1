using Lc4Ej1;

class Program
{
    static void Main(string[] args)
    {
        DeliveryFactory factory = new ConcreteDeliveryFactory();

        Console.WriteLine("Ingrese que tipo de delivery desea (Repartidor o Dron repartidor) ");
        IDelivery repartidor = factory.GetDelivery(Console.ReadLine());
        Console.WriteLine("Ingrese local de comida");
        repartidor.Retirar(Console.ReadLine());
        Console.WriteLine("Ingrese su ubicacion");
        repartidor.Entregar(Console.ReadLine());
        repartidor.CalcularTiempo(10, 30);


        Console.ReadKey();
    }
}