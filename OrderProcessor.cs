using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    public class OrderProcessor
    {
        private readonly OrderValidator _validator;
        private readonly OrderRepository _repository;
        private readonly NotificationService _service;

        public OrderProcessor(OrderValidator validator, OrderRepository repository, NotificationService service)
        {
            _validator = validator;
            _repository = repository;
            _service = service;
        }

        public void Order(string itemName, int quantity)
        {
            _validator.Validation(itemName, quantity);
            _repository.Save(itemName, quantity);
            _service.Notification();
        }
    }
}