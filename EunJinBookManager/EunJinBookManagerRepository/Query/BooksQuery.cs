﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunJinBookManagerRepository.Query
{
    internal class BooksQuery
    {
        public string Save()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("INSERT INTO public.books                 ");
            sql.AppendLine(" (                                        ");
            sql.AppendLine(" 	b_id, b_nm, b_anthor, b_cost         ");
            sql.AppendLine(" )                                        ");
            sql.AppendLine(" VALUES                                   ");
            sql.AppendLine(" (                                        ");
            sql.AppendLine(" 	@bId, @bNm, @bAnthor, @bCost     ");
            sql.AppendLine(" )");
            return sql.ToString();
        }

        public string Delete()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine("DELETE FROM public.books"        );
            sb.AppendLine("WHERE     b_id = @bId"          );
            sb.AppendLine("      AND b_nm = @bNm"          );
            sb.AppendLine("      AND b_anthor = @bAnthor"  );
            sb.AppendLine("      AND b_cost = @bCost;"     );

            return sb.ToString();
        }
    }
}
