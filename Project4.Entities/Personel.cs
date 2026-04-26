using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Entities
{
    //we will use the mapping 
    //personel is turkish mean of the employee
    //we will relation the personel and employee tables
    public class Personel:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
