using dao;
using Entites;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Metier
{
    public class ImpotMetier : IImpotMetier
    {
 // couche [dao]
 private IImpotDao Dao { get; set; }

 // les tranches d'impôt
 private TrancheImpot[] tranchesImpot;

 // constructeur
 public ImpotMetier(IImpotDao dao)
        {
             // mémorisation
Dao = dao;
             // tranches d'impôt
tranchesImpot = dao.TranchesImpot;
             }

 // calcul de l'impôt
 public int CalculerImpot(bool marié, int nbEnfants, int salaire)
        {
             // calcul du nombre de parts
 decimal nbParts;
             if (marié)
                nbParts = (decimal)nbEnfants / 2 + 2;
             else
                nbParts = (decimal)nbEnfants / 2 + 1;
             if (nbEnfants >= 3)
                nbParts += 0.5M;
             // calcul revenu imposable & Quotient familial
 decimal revenu = 0.72M * salaire;
             decimal QF = revenu / nbParts;
             // calcul de l'impôt
tranchesImpot[tranchesImpot.Length - 1].Limite = QF + 1;
             int i = 0;
             while (QF > tranchesImpot[i].Limite)
                i++;
             // retour résultat
 return (int)(revenu * tranchesImpot[i].CoeffR - nbParts * tranchesImpot[i].CoeffN);
             }//calculer

        public string CalculerImpot(bool v, object nbEnfants, object salaire)
        {
            throw new NotImplementedException();
        }
    }//classe

 }


