using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudLinqRequests
{
    internal class Students
    {
        public int Id { get; set; }
        public int Cours { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Facultet { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Cours} {Name}: {Age}, {Facultet}";
        }
    }
}
