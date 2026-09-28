using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feladatok
{
    public partial class Regisztracio : Form
    {
        public Regisztracio()
        {
            InitializeComponent();
            dtpSzuletes.MaxDate = DateTime.Today;
            dtpSzuletes.MinDate = new DateTime(1926, 01, 01);
            lblEredmeny.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblEredmeny.Text = string.Empty;
            bool jo = true;
            if (string.IsNullOrEmpty(txtNev.Text))
            {
                errorProvider1.SetError(txtNev, "A név megadása kötelező!");
                jo = false;
            }

            if (!txtNev.Text.All(char.IsLetter))
            {
                errorProvider1.SetError(txtNev, "A név csak betűkből állhat!");
                jo = false;
            }

            if (!txtEmail.Text.Contains("@") || (!txtEmail.Text.Contains(".")))
            {
                errorProvider1.SetError(txtEmail, "Az email címnek tartalmaznia kell '@' és '.' karaktert!");
                jo = false;
            }

            if (!mtxtTelefon.MaskCompleted)
            {
                errorProvider1.SetError(mtxtTelefon, "Nem megfelelő telefonszám!");
                jo = false;
            }
            if (jo)
            {
                //MessageBox.Show("Sikeres regisztráció!");

                lblEredmeny.Text= $"Sikeres regisztráció!\nNév: {txtNev.Text}\nEmail: {txtEmail.Text}\nTelefonszám: {mtxtTelefon.Text}\n" +
                    $"Életkor: {DateTime.Today.Year-dtpSzuletes.Value.Year}";

            }
        }
    }
}
