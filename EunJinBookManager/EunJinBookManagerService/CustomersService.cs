using EunJinBookManagerEntity;
using EunJinBookManagerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManagerService
{
    public class CustomersService
    {
        CustomersRepository CustomersRepo = null;

        public CustomersService()
        {
            CustomersRepo = new CustomersRepository();
        }

        public bool Save(CustomersEntity customers)
        {
            return CustomersRepo.Save(customers);
        }
        
        public bool Delete(CustomersEntity customers)
        {
            return CustomersRepo.Delete(customers);
        }

        public List<CustomersEntity> Search()
        {
            return CustomersRepo.Search();
        }
    }
}