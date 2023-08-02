using EunJinBookManagerEntity;
using EunJinBookManagerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManager.Presenter
{
    internal class CustomersPresenter
    {
        CustomersService _customersService = null;

        public CustomersPresenter()
        {
            _customersService = new CustomersService();
        }

        public bool Save(CustomersEntity customers)
        {
            return _customersService.Save(customers);
        }

        public bool Delete(CustomersEntity customers)
        {
            return _customersService.Delete(customers);
        }

        public List<CustomersEntity> Search()
        {
            return _customersService.Search();                
        }
    }
}