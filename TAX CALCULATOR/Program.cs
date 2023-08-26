using System;
// tableaux de données nécessaires au calcul de l'impôt
decimal[] limites = { 4962M, 8382M, 14753M, 23888M, 38868M, 47932M, 0M };
decimal[] coeffR = { 0M, 0.068M, 0.191M, 0.283M, 0.374M, 0.426M, 0.481M };
decimal[] coeffN = { 0M, 291.09M, 1322.92M, 2668.39M, 4846.98M, 6883.66M, 9505.54M };

// on récupère le statut marital
bool OK = false;
string? reponse = null;
while (!OK)
{
    Console.Write("Etes-vous marié(e) (O/N) ? ");
    reponse = Console.ReadLine().Trim().ToLower();
    if (reponse != "o" && reponse != "n")
        Console.Error.WriteLine("Réponse incorrecte. Recommencez");
    else OK = true;
}//while
bool marie = reponse == "o";

// nombre d'enfants
OK = false;
int nbEnfants = 0;
while (!OK)
{
    Console.Write("Nombre d'enfants : ");
    try
    {
        nbEnfants = int.Parse(Console.ReadLine());
        OK = nbEnfants >= 0;
    }
    catch
    {
    }// try
    if (!OK)
    {
        Console.WriteLine("Réponse incorrecte. Recommencez");
    }
}// while

// salaire
OK = false;
int salaire = 0;
while (!OK)
{

    Console.Write("Salaire annuel : ");
    try
    {
        salaire = int.Parse(s: Console.ReadLine());
        OK = salaire >= 0;
    }
    catch
    {
    }// try
    if (!OK)
    {
        Console.WriteLine("Réponse incorrecte. Recommencez");
    }
}// while

// calcul du nombre de parts
decimal nbParts;
if (marie) nbParts = (decimal)nbEnfants / 2 + 2;
else nbParts = (decimal)nbEnfants / 2 + 1;
if (nbEnfants >= 3) nbParts += 0.5M;

// revenu imposable
decimal revenu = 0.72M * salaire;

// quotient familial
decimal QF = revenu / nbParts;

// recherche de la tranche d'impots correspondant à QF
int i;
int nbTranches = limites.Length;
limites[nbTranches - 1] = QF;
i = 0;
while (QF > limites[i]) i++;
// l'impôt
int impots = (int)(coeffR[i] * revenu - coeffN[i] * nbParts);

// on affiche le résultat
Console.WriteLine("Impôt à payer : {0} euros", impots);

