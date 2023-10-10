using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPExtentions
{
    public static class Extention
    {
        public static List<T> Filter<T>(this List<T> records, Func<T,bool> func)
        {
            List<T> list = new List<T>();
            foreach (T record in records)
            {
                if (func(record))
                {
                    list.Add(record);
                }
            }
            return list;
        }
    }
}
