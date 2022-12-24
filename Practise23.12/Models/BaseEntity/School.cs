using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise23._12.Models.BaseEntity
{
    internal class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static Class[] Classes { get; set; }

        static School()
        {
            Classes = new Class[0];
        }
        


    }
}
