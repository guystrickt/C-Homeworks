using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    public class OrderValidator
    {
        public void Validation(string itemName, int quantity)
        {
            if (string.IsNullOrEmpty(itemName))
            {
                Console.WriteLine("Ошибка: Название товара не может быть пустым.");
                return;
            
            }
            if (quantity <= 0)
            {
                Console.WriteLine("Ошибка: Количество должно быть больше нуля.");
                return;
            }
            Console.WriteLine("Заказ прошел валидацию.");
        }
    }
}
