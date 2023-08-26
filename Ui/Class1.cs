using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using Metier;
using Entites;

namespace Ui
{
    public class Dialogue
    {
 static void Main()
        {
             
 // on crée les couches [metier et dao]
IImpotMetier metier = null;
             try
            {
                 // création couche [metier]
metier = new ImpotMetier(new FileImpot("DataImpot.txt"));
                 }
            catch (FileImpotException e)
            {
               // affichage erreur
 string msg = e.InnerException == null ? null : String.Format(",Exception d'origine :{0}", e.InnerException.Message);
                Console.WriteLine("L'erreur suivante s'est produite : [Code={0},Message={1}{2}]",
                e.Code, e.Message, msg == null ? "" : msg);
                 // arrêt programme
Environment.Exit(1);
                 }
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