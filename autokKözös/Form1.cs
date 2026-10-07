using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace autokKözös
{
    public partial class Form1 : Form
    {
        static List<Auto> autok = new List<Auto>();

        static List<Költség> koltsegek = new List<Költség>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr1 = new StreamReader("autok.csv", Encoding.UTF8);
            while (!sr1.EndOfStream)
            {
                Auto tmp = new Auto(sr1.ReadLine());
                if(tmp.Rendszám != "HIBA") autok.Add(tmp);
            }
            sr1.Close();

            StreamReader sr2 = new StreamReader("koltsegek.csv", Encoding.UTF8);
            while (!sr2.EndOfStream)
            {
                Költség tmp = new Költség(sr2.ReadLine());
                if (tmp.Megnevezés != "HIBA") koltsegek.Add(tmp);
            }
            sr2.Close();

            dGAutok.DataSource = autok ;
        }

        private void dGAutok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sor = e.RowIndex;
            int auto = autok[sor].Id;
            List<Költség> tmp = new List<Költség> ();
            foreach (var item in koltsegek)
                if (item.AutoId == auto) tmp.Add(item);
            //List <Költség> tmp = koltsegek.Where(a => a.AutoId == auto).ToList();
            //dGWkoltsegek.DataSource = tmp ;
            dGWkoltsegek.DataSource = tmp.Select(a => new { a.Dátum, a.Kategória, a.Megnevezés, a.Összeg }).ToList() ;
        }
    }
}
