using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaPruebaWPF
{
    public static class Efectos
    {
        public static void Capitalizar(ref string frase)
        {
            frase = frase.ToLower();
            frase = string.Join(" ", frase.Split(' ').Select(word => { word=word.Trim(); return char.ToUpper(word[0]) + word.Substring(1); })).Trim();
        }
    }
}
