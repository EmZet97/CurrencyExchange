using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TO_lab002
{
    public partial class Waluty : Form
    {
        Repository repository;
        bool ready = false;
        public Waluty()
        {
            InitializeComponent();

            //Connection
            Connection conn = new Connection("http://www.nbp.pl/kursy/xml/lasta.xml");
            string txt = conn.GetResource();
            if (txt == null)
            {
                label2.Text = "Błąd połączenia";
                return;
            }


            XMLParser parser = new XMLParser(txt);
            
            parser.Parse(out repository);
            foreach (Currency c in repository.Currencies)
            {
                Console.WriteLine(c.GetName() + "( " + c.GetCode() + " ) = " + c.GetValue());
                comboBoxFromCurrency.Items.Add(c.GetName() + " [" + c.GetValue() + "]");
                comboBoxToCurrecy.Items.Add(c.GetName() + " [" + c.GetValue() + "]");

            }
            if(repository.Date != null)
            {
                label2.Text = "Data publikacji:" + repository.Date;
            }
            else
            {
                label2.Text = "";
            }
            comboBoxFromCurrency.SelectedIndex = 7;
            comboBoxToCurrecy.SelectedIndex = 1;

            ready = true;
            ConvertAndWrite();
        }

        private void ComboBoxFromCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertAndWrite();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            ConvertAndWrite();
        }

        private void ComboBoxToCurrecy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertAndWrite();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ConvertAndWrite();
        }

        private void ConvertAndWrite()
        {
            if (!ready)
                return;
            int value1 = comboBoxFromCurrency.SelectedIndex;
            int value2 = comboBoxToCurrecy.SelectedIndex;
            decimal value = numericUpDown1.Value;
            decimal exc = Exchange.CurrencyConverter(value, from_val: repository.Currencies[value1], to_val: repository.Currencies[value2]);
            string text = String.Format("{0:0.00}", exc);
            textBox1.Text = text;

        }
    }
}
