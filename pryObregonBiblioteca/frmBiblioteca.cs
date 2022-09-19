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
        public frmBiblioteca()
        {
            InitializeComponent();
        }

        private void frmBiblioteca_Load(object sender, EventArgs e)
        {

            StreamReader Readbook = new StreamReader("./Libro.txt");

            string[] vecLibros = new string[20];

            int i = 0; //índice

            while (!Readbook.EndOfStream)
            {
                //lee los nombres de los libros escritos en el .txt

                vecLibros[i] = Readbook.ReadLine();

                lstNombreLibro.Items.Add(vecLibros[i]);

                i++;

            }
            Readbook.Close();
        }
    }
}
