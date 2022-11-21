using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework
{
    public class Guns
    {
        public string Name { get; private set; }
        public decimal BulletPrice { get; private set; }
        public Guns(string name, decimal bulletprice) 
        { 
            Name= name; 
            BulletPrice= bulletprice;   
        }
    }
    
}
