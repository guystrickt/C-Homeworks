using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    public class OrderRepository
    {
        public void Save(string itemName, int quantity)
        {
            File.WriteAllText("order.txt", $"Товар: {itemName}, Количество: {quantity}");
            Console.WriteLine("Заказ сохранен в файл.");
            return;
        }
    }
}
