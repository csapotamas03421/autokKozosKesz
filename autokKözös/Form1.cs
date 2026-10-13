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

        string aid;
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
            panelKoltseg.Visible = false;
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
            if (e.RowIndex == -1) return;

            int sor = e.RowIndex;

            panelKoltseg.Visible = true;
            dGAutok.Enabled = false;
            dGWkoltsegek.Enabled = false;

            kRendszam.Text = autok[sor].Rendszám;
            aid = autok[sor].Id.ToString();
            kKategoria.SelectedIndex = 0;



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
            try
            {
                int evjarat = int.Parse(txbEvjarat.Text);
                if (evjarat < 1900 || evjarat > DateTime.Now.Year) 
                {
                    MessageBox.Show("Az évjárat nem megfelelő!");
                    return;
                }
              
            }
            catch (Exception)
            {
                MessageBox.Show("Az évjárat nem megfelelő!");
                return;
            }



            try
            {

                int km = int.Parse(txbKm.Text);
                if (km < 0)
                {
                    MessageBox.Show("A km nem megfelelő!");
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("A km nem megfelelő!");
                return;
            }



            if (autok.Any(x => x.Rendszám == txbRendszam.Text))
            {
                MessageBox.Show("A rendszám már szerepel a nyilvántartásba!");
                return;
            }

            

            int maxId = autok.Max(x => x.Id) + 1;
            StreamWriter sw = new StreamWriter("autok.csv", true, Encoding.UTF8);
            string tmp = $"{maxId.ToString()}";
            sw.WriteLine($"\n {tmp};{txbRendszam.Text};{txbMarka.Text};{txbModel.Text};{txbEvjarat.Text};{txbUzemanyag.Text};{txbKm.Text}");
            sw.Close();

            panelUjAuto.Visible = false;

            string ujSorAuto = $"{maxId.ToString()};{txbRendszam.Text};{txbMarka.Text};{txbModel.Text};{txbEvjarat.Text};{txbUzemanyag.Text};{txbKm.Text}";
       

            autok.Add( new Auto(ujSorAuto));

            foreach (Control c in panelUjAuto.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
      
            dGAutok.DataSource = false;
            dGAutok.DataSource = autok;
            dGAutok.Enabled = true;
            dGWkoltsegek.Enabled = true;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelKoltseg.Visible = false;
            dGAutok.Enabled = true;
            dGWkoltsegek.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kÖsszeg;
            try
            {
                kÖsszeg = int.Parse(kOsszeg.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Rossz összeg.");
                return;
            }
            if (kÖsszeg < 0)
            {
                MessageBox.Show("Rossz összeg.");
                return;
            }

            int minKm;
            try
            {
                minKm = koltsegek.Where(x => x.AutoId == int.Parse(aid)).ToList().Min(x => x.AutoId);
            }
            catch (Exception)
            {
                //minKm = autok[int.Parse(aid)].Kilométer;
                minKm = autok.First(x => x.Id == int.Parse(aid)).Kilométer;
            }


            int nKm;
            try
            {
                if(int.Parse(kKm.Text) < minKm)
                {
                    MessageBox.Show("Rossz km.");
                    return;
                }
                //nKm = int.Parse(kKm.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Rossz km.");
                return;
            }
            /*
            if (kÖsszeg < minKm)
            {
                MessageBox.Show("Rossz km.");
                return;
            }
            */

            string tmp = $"" +
                $"{(koltsegek.Max(x => x.Id) + 1).ToString()};" +
                $"{aid};" +
                $"{kDatum.Value.ToString("yyyy.MM.dd.")};" +
                $"{kKategoria.SelectedItem};" +
                $"{kMegnevezes.Text};" +
                $"{kOsszeg.Text};" +
                $"{kKm.Text};";

            StreamWriter sw = new StreamWriter("koltsegek.csv", true, Encoding.UTF8);
            sw.WriteLine("\n" + tmp);
            sw.Close();
            koltsegek.Add(new Költség(tmp));

            dGWkoltsegek.DataSource = false;
            dGWkoltsegek.DataSource = tmp;

            //rendszam.Clear();
            kKategoria.SelectedIndex = 0;
            kOsszeg.Clear();
            kKm.Clear();
            kMegnevezes.Clear();

            panelKoltseg.Visible = false;
            dGAutok.Enabled = true;
            dGWkoltsegek.Enabled = true;
            

        }
    }
}
