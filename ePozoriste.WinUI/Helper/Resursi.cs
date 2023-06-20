using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Resources;

namespace ePozoriste.WinUI.Helper
{
    public class Resursi
    {
        private static ResourceManager Menadzer = new ResourceManager(Kljucevi.NazivResourceFajla, Assembly.GetExecutingAssembly());

        public static string Get(string kljuc)
        {
            return Menadzer.GetString(kljuc);
        }
    }
}
