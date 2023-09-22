using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Model
{
    public class UserException : Exception
    {
        public string Ttile { get; set; }   

        public UserException(string title, string message) : base(message)
        {
            Ttile = title;
        }
    }
}
