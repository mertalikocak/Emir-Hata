using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emir_Hata
{
    internal class Super
    {
        private string name;
        private DateTime start;
        private DateTime end;

        public Super(string name, DateTime start)
        {
            this.name = name;
            this.start = start;
        }

        public string Name { get => name; set => name = value; }
        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }

    }
}
