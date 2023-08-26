using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dao
{
    class FileImpot : IImpotDao
    {
        // fichier des données
        public string FileName { get; set; }

        // tranches d'impôt
        public TrancheImpot[] TranchesImpot { get; private set; }

        // constructeur
        public FileImpot(string fileName)
        {
            // on mémorise le nom du fichier
            FileName = fileName;
            // données
            List<TrancheImpot> listTranchesImpot = new List<TrancheImpot>();
            int numLigne = 1;
            // exception
            FileImpotException fe = null;
            // lecture contenu du fichier fileName, ligne par ligne
            Regex pattern = new Regex(@"s*:\s*");
            // au départ pas d'erreur
            FileImpotException.CodeErreurs code = 0;
            try
            {
                using (StreamReader input = new StreamReader(FileName))
                {
                    while (!input.EndOfStream && code == 0)
                    {
                        // ligne courante
                        string ligne = input.ReadLine().Trim();
                        // on ignore les lignes vides
                        if (ligne == "")
                            continue;
                        // ligne décomposée en trois champs séparés par :
                        string[] champsLigne = pattern.Split(ligne);
                        // a-t-on 3 champs ?
                        if (champsLigne.Length != 3)
                        {
                            code = FileImpotException.CodeErreurs.Ligne;
                        }
                        // conversions des 3 champs
                        decimal limite = 0, coeffR = 0, coeffN = 0;
                        if (code == 0)
                        {
                            if (!Decimal.TryParse(champsLigne[0], out limite))
                                code = FileImpotException.CodeErreurs.Champ1;
                            if (!Decimal.TryParse(champsLigne[1], out coeffR))
                                code |= FileImpotException.CodeErreurs.Champ2;
                            if (!Decimal.TryParse(champsLigne[2], out coeffN))
                                code |= FileImpotException.CodeErreurs.Champ3;
                            ;
                        }
                        // erreur ?
                        if (code != 0)
                        {
                            // on note l'erreur
                            fe = new FileImpotException(String.Format("Ligne n° {0} incorrecte", numLigne))
                            { Code = code };
                        }
                        else
                        {
                            // on mémorise la nouvelle tranche d'impôt
                            listTranchesImpot.Add(new TrancheImpot()
                            {
                                Limite = limite,
                                CoeffR = coeffR,
                                CoeffN = coeffN
                            });
                            // ligne suivante
                            numLigne++;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                 // on note l'erreur
fe = new FileImpotException(String.Format("Erreur lors de la lecture du fichier {0}",
FileName), e)
{ Code = FileImpotException.CodeErreurs.Acces };
                 }
             // erreur à signaler ?
 if (fe != null)
            {
                 // on lance l'exception
 throw fe;
                 }
            else
            {
                 // on rend la liste listImpot dans le tableau tranchesImpot
TranchesImpot = listTranchesImpot.ToArray();
                 }
             }
 }
 }





