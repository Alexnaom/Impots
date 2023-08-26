using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAX_CALCULATOR
{
        abstract class AbstractImpot : IImpot
        {

 // les tranches d'impôt nécessaires au calcul de l'impôt
 // proviennent d'une source extérieure

 protected TrancheImpot[] tranchesImpot;

 // calcul de l'impôt
 public int calculer(bool marié, int nbEnfants, int salaire)
            {
                 // calcul du nombre de parts
 decimal nbParts;
                 if (marié) nbParts = (decimal)nbEnfants / 2 + 2;
                 else nbParts = (decimal)nbEnfants / 2 + 1;
                 if (nbEnfants >= 3) nbParts += 0.5M;
                 // calcul revenu imposable & Quotient familial
 decimal revenu = 0.72M * salaire;
                 decimal QF = revenu / nbParts;
                 // calcul de l'impôt
tranchesImpot[tranchesImpot.Length - 1].Limite = QF + 1;
                 int i = 0;
                 while (QF > tranchesImpot[i].Limite) i++;
                 // retour résultat
 return (int)(revenu * tranchesImpot[i].CoeffR - nbParts * tranchesImpot[i].CoeffN);
                 }//calculer
 }//classe
    }

