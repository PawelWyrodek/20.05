using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postaciekoniec
{
    public partial class Form1 : Form
    {
        static public void Main(String[] args)
        {
            List<Postac> postacie = new List<Postac>();
            postacie.Add(new Wojownik("Gerald", "150"));
            postacie.Add(new Mag("Merlin", "100"));
            postacie.Add(new Rolnik("Blazej", "50"));

            foreach (Postac postac in postacie)
            {
                Console.WriteLine(postac.PrzedstawSie());
            }

            Console.Read();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonWojownik_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
