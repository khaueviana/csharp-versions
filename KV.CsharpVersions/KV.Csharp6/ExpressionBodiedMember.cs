using System;

namespace KV.Csharp6
{
    public static class ExpressionBodiedMember
    {
        public static void Example()
        {
            Console.WriteLine("Set dos valores 10 e 1.50 nas propriedades Quantity e Price");            

            OrderItem orderItem = new OrderItem();
            orderItem.Quantity = 10;
            orderItem.Price = 1.50;
            
            Console.WriteLine("Resultado: " + orderItem.TotalItem);

            Console.WriteLine("Set dos valores São Vicente e São Paulo nas propriedades City e State");

            City city = new City();
            city.Name = "São Vicente";
            city.State = "São Paulo";

            Console.WriteLine("Resultado: " + city.ToString());
        }
    }

    public class OrderItem
    {
        public string BarCode { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public double TotalItem => Quantity * Price;
    }

    public class City
    {
        public string Name { get; set; }

        public string State { get; set; }

        public override string ToString() => Name + " - " + State;
    }
}
