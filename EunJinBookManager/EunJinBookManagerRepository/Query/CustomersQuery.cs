using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManagerRepository.Query
{
    internal class CustomersQuery
    {
        public string SaveQuery()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("INSERT INTO public.customers              ");
            sql.AppendLine("(                                         ");
            sql.AppendLine("	c_id, c_nm, addr, sex, job, phone     ");
            sql.AppendLine(")                                         ");
            sql.AppendLine("VALUES                                    ");
            sql.AppendLine("(                                         ");
            sql.AppendLine("	@cId, @cNm, @addr, @sex, @job, @phone ");
            sql.AppendLine(")                                         ");

            return sql.ToString();
        }
        public string DeleteQuery()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("DELETE FROM public.customers");
            sql.AppendLine("WHERE c_id = @cId            ;");

            return sql.ToString();
        }
        public string SearchQuery()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("  SELECT a.c_id                ");
            sql.AppendLine("       , a.c_nm                ");
            sql.AppendLine("       , a.addr                ");
            sql.AppendLine("       , a.sex                 ");
            sql.AppendLine("       , a.job                 ");
            sql.AppendLine("       , a.phone               ");
            sql.AppendLine("  	 , b.code_val AS sex_nm   ");
            sql.AppendLine("  	 , c.code_val AS job_nm   ");
            sql.AppendLine("  FROM customers a,            ");
            sql.AppendLine("  	 book_code b,             ");
            sql.AppendLine("  	 book_code c              ");
            sql.AppendLine("  WHERE b.code_div = 'sex'     ");
            sql.AppendLine("    AND b.code_key = a.sex     ");
            sql.AppendLine("    AND c.code_div = 'job'     ");
            sql.AppendLine("    AND c.code_key = a.job;    ");

            return sql.ToString();
        }
    }
}