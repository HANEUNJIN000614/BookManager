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
        CustomersRepository _CustomersRepo = null;

        public CustomersService()
        {
            _CustomersRepo = new CustomersRepository();
        }

        public bool Save(CustomersEntity customers)
        {
            return _CustomersRepo.Save(customers);
        }
        
        public bool Delete(CustomersEntity customers)
        {
            return _CustomersRepo.Delete(customers);
        }

        public List<CustomersEntity> Search()
        {
            return _CustomersRepo.Search();
        }
    }
}