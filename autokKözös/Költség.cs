using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autokKözös
{
    internal class Költség
    {
        public int Id { get; set; }
        public int AutoId { get; set; }
        public DateTime Dátum { get; set; }
        public string Kategória { get; set; }
        public string Megnevezés { get; set; }
        public decimal Összeg { get; set; }
        public int Kilométer { get; set; }
        public Költség(string line) 
        {
            try
            {
                string[] sz = line.Split(';');
                this.Id = int.Parse(sz[0]);
                this.AutoId = int.Parse(sz[1]);
                this.Dátum = DateTime.Parse(sz[2]);
                this.Kategória = sz[3];
                this.Megnevezés = sz[4];
                this.Összeg = decimal.Parse(sz[5]);
                this.Kilométer = int.Parse(sz[6]);
            }
            catch (Exception)
            {
                this.Megnevezés = "HIBA";
            }

        }
    }
}
