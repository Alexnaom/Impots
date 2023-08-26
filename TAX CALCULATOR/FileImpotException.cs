﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAX_CALCULATOR
{
    class FileImpotException : Exception
        {
 // codes d'erreur
 [Flags]
 public enum CodeErreurs { Acces = 1, Ligne = 2, Champ1 = 4, Champ2 = 8, Champ3 = 16 };

 // code d'erreur
 public CodeErreurs Code { get; set; }

 // constructeurs
 public FileImpotException()
            {
                }
 public FileImpotException(string message)
 : base(message) {
 }
 public FileImpotException(string message, Exception e)
 : base(message, e) {
 }
 }
    }

