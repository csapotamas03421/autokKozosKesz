using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autokKözös
{
    internal class Auto
    {
        public int Id {  get; set; }
        public string Rendszám { get; set; }
        public string Márka { get; set; }
        public string Model { get; set; }
        public int Évjárat { get; set; }
        public string Üzemanyag { get; set; }
        public  int Kilométer{ get; set; }
        public Auto(string line)
        {
            try
            {
                string[] sz = line.Split(';');
                this.Id = int.Parse(sz[0]);
                this.Rendszám = sz[1];
                this.Márka = sz[2];
                this.Model = sz[3];
                this.Évjárat = int.Parse(sz[4]);
                this.Üzemanyag = sz[5];
                this.Kilométer = int.Parse(sz[6]);
            }
            catch (Exception)
            {
                this.Rendszám = "HIBA";
            }
        }
    }
}
