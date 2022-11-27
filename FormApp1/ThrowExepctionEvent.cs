using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp1
{
    public class ThrowExepctionEvent
    {
        public void Run()
        {
            MessageBox.Show("Throwing exception");
            throw new OwnExepction("Do not click that button!");
        }
    }
}
