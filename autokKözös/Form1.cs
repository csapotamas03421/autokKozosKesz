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
    public partial class Autók : Form
    {
        static List<Auto> autok = new List<Auto>();

        static List<Költség> koltsegek = new List<Költség>();
        public Autók()
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
            panelUjAuto.Visible = false;
        }

        private void dGAutok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1) return;
            int sor = e.RowIndex;
            int auto = autok[sor].Id;
            List<Költség> tmp = new List<Költség> ();
            foreach (var item in koltsegek) 
            {
                if (item.AutoId == auto) tmp.Add(item);
            }
            //List <Költség> tmp = koltsegek.Where(a => a.AutoId == auto).ToList();
            //dGWkoltsegek.DataSource = tmp ;
            autokoltsegek.Text = autok[sor].Rendszám + " költségei";
            dGWkoltsegek.RowHeadersVisible = false;
            dGWkoltsegek.DataSource = tmp.Select(a => new { a.Dátum, a.Kategória, a.Megnevezés, a.Összeg }).ToList() ;
        }
        private void dGAutok_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dGAutok_HeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //uj auto
            panelUjAuto.Visible = true;
            dGAutok.Enabled = false;
            dGWkoltsegek.Enabled = false;
        }

        private void btnUjMegsem_Click(object sender, EventArgs e)
        {
            panelUjAuto.Visible = false;
            dGAutok.Enabled = true;
            dGWkoltsegek.Enabled = true;
        }

        private void btnUjMentes_Click(object sender, EventArgs e)
        {
            if(txbEvjarat.Text == "" ||
                txbKm.Text == "" ||
                txbRendszam.Text == "" ||
                txbMarka.Text == "" ||
                txbModel.Text == "" ||
                txbUzemanyag.Text == "")
            {
                MessageBox.Show("Minden mező kitöltése kötelező!");
                return;
            }
            if(int.Parse(txbEvjarat.Text) <1900 || int.Parse(txbEvjarat.Text) >2026)
            {
                MessageBox.Show("Az évjárat nem megfelelő!");
                return;
            }
        }
    }
}
