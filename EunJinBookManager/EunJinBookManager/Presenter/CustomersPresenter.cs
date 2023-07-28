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
        CustomersService customersService = null;

        public CustomersPresenter()
        {
            customersService = new CustomersService();
        }

        public bool Save(CustomersEntity customers)
        {
            return customersService.Save(customers);
        }

        public bool Delete(CustomersEntity customers)
        {
            return customersService.Delete(customers);
        }

        public List<CustomersEntity> Search()
        {
            return customersService.Search();                
        }
    }
}