using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgendaTelefonica.Classes
{   
    public static class Auxiliar
    {
        public static bool VerificaTelefone(string telefone)
        {
            Regex regex = new Regex(@"(\(?\d{2}\)?\s)?(\d{4,5}\-?\d{4})");
            if (regex.IsMatch(telefone))
                return true;
            return false;
        }
    }
}
