using dao;
using Metier;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ui
{
    public class Dialogue2
    {
 static void Main()
        { 
 // on crée les couches [metier et dao]
IImpotMetier metier = new ImpotMetier(new HardwiredImpot());
             // boucle infinie
 while (true)
            {
 // les paramètres sont corrects - on calcule l'Impot
Console.WriteLine("Impot=" + metier.CalculerImpot(marié == "o", nbEnfants, salaire) + "
euros");
 // contribuable suivant
 }//while
             }
 }
}


