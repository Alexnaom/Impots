using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    public class HardwiredImpot : IImpotDao
    {

 // tableaux de données nécessaires au calcul de l'impôt
 decimal[] limites = { 4962M, 8382M, 14753M, 23888M, 38868M, 47932M, 0M };
 decimal[] coeffR = { 0M, 0.068M, 0.191M, 0.283M, 0.374M, 0.426M, 0.481M };
 decimal[] coeffN = { 0M, 291.09M, 1322.92M, 2668.39M, 4846.98M, 6883.66M, 9505.54M };
 // tranches d'impôt
 public TrancheImpot[] TranchesImpot { get; private set; }

 // constructeur
 public HardwiredImpot()
        {
             // création du tableau des tranches d'impôt
TranchesImpot = new TrancheImpot[limites.Length];
             // remplissage
 for (int i = 0; i < TranchesImpot.Length; i++)
            {
                TranchesImpot[i] = new TrancheImpot
                {
                    Limite = limites[i],
                    CoeffR = coeffR[i],
                    CoeffN =
                coeffN[i]
                };
                 }
             }
 }// classe
 }// namespace

