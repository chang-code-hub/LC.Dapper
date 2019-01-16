using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper
{
    class _TestClass
    {
        public void test()
        {
            UdfAccesser acc = new UdfAccesser();
            if (acc.UdfColumns == null)
            {
                acc.UdfColumns = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            }


            acc.UdfColumns.Add("1", 1);
        }

        public void test2(IDbCommand command, Dictionary<string,object> p )
        {
            if (p != null)
            {
                foreach (var kv in p)
                {
                    var param = command.CreateParameter();
                    //command.Parameters.Add(new )
                }
            }

        }
    }
     
}
