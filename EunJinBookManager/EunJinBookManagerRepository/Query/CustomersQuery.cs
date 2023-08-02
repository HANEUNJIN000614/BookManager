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
            sql.AppendLine(" INSERT INTO public.customers                                  ");
            sql.AppendLine(" (                                                             ");
            sql.AppendLine(" 	c_id, c_nm, addr, sex, job, phone                          ");
            sql.AppendLine(" )                                                             ");
            sql.AppendLine(" VALUES                                                        ");
            sql.AppendLine(" (                                                             ");
            sql.AppendLine(" 	(SELECT COALESCE(MAX(c_id)+1, 100) FROM public.customers), ");
            sql.AppendLine(" 	@cNm, @addr, @sex, @job, @phone                            ");
            sql.AppendLine(" )                                                             ");

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
            sql.AppendLine(" SELECT c_id                                 ");
            sql.AppendLine("      , c_nm                                 ");
            sql.AppendLine("      , addr                                 ");
            sql.AppendLine("      , sex                                  ");
            sql.AppendLine("      , (SELECT code_val FROM book_code      ");
            sql.AppendLine("      	WHERE code_div = 'sex'               ");
            sql.AppendLine("      		AND a.sex = code_key) AS sex_nm  ");
            sql.AppendLine("      , job                                  ");
            sql.AppendLine("      , (SELECT code_val FROM book_code      ");
            sql.AppendLine("      	WHERE code_div = 'job'               ");
            sql.AppendLine("      		AND a.job = code_key) AS job_nm  ");
            sql.AppendLine("      , phone                                ");
            sql.AppendLine(" FROM customers a;                           ");

            return sql.ToString();
        }
    }
}