using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctionalites.Services.Interface
{
    public interface ITaxService
    {
        double CalculateTax(double income);
    }
}
