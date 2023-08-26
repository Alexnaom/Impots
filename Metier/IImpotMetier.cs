using dao;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
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
            
 }//calculer
 }//classe

 }

