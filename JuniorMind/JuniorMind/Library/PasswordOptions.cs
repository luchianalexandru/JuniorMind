using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public struct PasswordOptions
    {
        public int Length { get; set; }
        public int UpperCase { get; set; }
        public int Numbers { get; set; }
        public int Symbols { get; set; }
        public bool Ambiguous { get; set; }
        public bool Similar { get; set; }
    }
}

