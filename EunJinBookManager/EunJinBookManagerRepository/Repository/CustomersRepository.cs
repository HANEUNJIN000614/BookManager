using eGhis.Core;
using EunJinBookManagerEntity;
using EunJinBookManagerRepository.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManagerRepository
{
    public class CustomersRepository : RepositoryBase
    {
        public bool Save(CustomersEntity customers)
        {
            string sql = new CustomersQuery().SaveQuery();

            return Execute(sql, customers) == 1;
        }

        public bool Delete(CustomersEntity customer)
        {
            string sql = new CustomersQuery().DeleteQuery();

            return Execute(sql, customer) == 1;
        }

        public List<CustomersEntity> Search()
        {
            string sql = new CustomersQuery().SearchQuery();

            return Query<CustomersEntity>(sql);
        }
    }
}