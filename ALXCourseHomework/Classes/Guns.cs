using System;
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
