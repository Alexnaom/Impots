using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAX_CALCULATOR
{
    internal interface IImpot
    {
        int calculer(bool marié, int nbEnfants, int salaire);
    }
}
