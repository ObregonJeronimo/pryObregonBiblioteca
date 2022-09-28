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

namespace pryObregonBiblioteca
{
    public partial class frmBiblioteca : Form
    {

        public string[] baseLibro = new string[21];


        public frmBiblioteca()
        {
            InitializeComponent();
        }

        int Indice = 0;
        private void frmBiblioteca_Load(object sender, EventArgs e)
        {
            StreamReader objLector = new StreamReader("./LIBRO.txt");

            int indice = 0;

            while (!objLector.EndOfStream)
            {

                baseLibro[indice] = objLector.ReadLine();


                indice++;
            }

            objLector.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            StreamReader Lector = new StreamReader("./LIBRO.txt");



            string TextoCodigo = Lector.ReadLine();




            if (Indice < baseLibro.Length && baseLibro[Indice] != null)
            {

                lstNombre.Items.Clear();
                lstNombre.Items.Add(baseLibro[Indice].Substring(3, 20));

                lstCodigo.Items.Clear();
                lstCodigo.Items.Add(baseLibro[Indice].Substring(0, 2));



                //    switch (txtCodigoEdit.Text)
                {
                    //      case "1":
                    //           txtCodigoEdit.Text = "PRENTICE HALL";
                    //       break;

                    //case "2":
                    //txtCodigoEdit.Text = "CUSPIDE";
                    //break;

                    //case "3":
                    //txtCodigoEdit.Text = "RAMA";
                    //break;

                    //case "4":
                    //txtCodigoEdit.Text = "MAC GRAW HILL";
                    //break;

                    //case "5":
                    //txtCodigoEdit.Text = "ANAY MULTIMEDIA";
                    //break;

                    //case "6":
                    //txtCodigoEdit.Text = "PEUSER";
                    //break;

                    //case "7":
                    //txtCodigoEdit.Text = "COLOMBO";
                    //break;

                }



                Indice++;
            }
            Lector.Close();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Indice--;
            if (Indice < baseLibro.Length && baseLibro[Indice] != null)
            {
                lstNombre.Items.Clear();
                lstNombre.Items.Add(baseLibro[Indice].Substring(3, 19));

            }
        }
    }
}



