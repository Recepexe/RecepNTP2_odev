using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxlistele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private List<string> stringList = new List<string>();
        private List<int> intList = new List<int>();
        private List<float> floatList = new List<float>();
        private List<bool> boolList = new List<bool>();


        private void btnStringEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtString.Text))
            {
                stringList.Add(txtString.Text);
                txtString.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen bir metin girin.");
            }
        }

        private void btnIntEkle_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtInt.Text, out int value))
            {
                intList.Add(value);
                txtInt.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tam sayı girin.");
            }
        }

        private void btnFloatEkle_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtFloat.Text, out float value))
            {
                floatList.Add(value);
                txtFloat.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ondalık sayı girin.");
            }
        }

        private void btnBoolEkle_Click(object sender, EventArgs e)
        {

            if (radioButtonTrue.Checked)
            {
                boolList.Add(true);
            }
            else if (radioButtonFalse.Checked)
            {
                boolList.Add(false);
            }
            else
            {
                MessageBox.Show("Lütfen bir seçenek belirleyin.");
                return;
            }

        
            radioButtonTrue.Checked = false;
            radioButtonFalse.Checked = false;
        }

        private void btnStringTemizle_Click(object sender, EventArgs e)
        {

            listBoxString.Items.Clear();
            stringList.Clear();

        }

        private void btnIntTemizle_Click(object sender, EventArgs e)
        {
            listBoxInt.Items.Clear();
            intList.Clear();
        }

        private void btnFloatTemizle_Click(object sender, EventArgs e)
        {
            listBoxFloat.Items.Clear();
            floatList.Clear();
        }

        private void btnBoolTemizle_Click(object sender, EventArgs e)
        {

            listBoxBool.Items.Clear();
            boolList.Clear();
        }

        private void btnStringListele_Click(object sender, EventArgs e)
        {
            listBoxString.Items.Clear();
            foreach (var item in stringList)
            {
                listBoxString.Items.Add(item);
            }
            
            labelStringCount.Text = $"String Listesi Eleman Sayısı: {stringList.Count}";
        }

        private void btnIntListele_Click(object sender, EventArgs e)
        {

            listBoxInt.Items.Clear();
            foreach (var item in intList)
            {
                listBoxInt.Items.Add(item);
            }
            
            labelIntCount.Text = $"Int Listesi Eleman Sayısı: {intList.Count}";
        }

        private void btnFloatListele_Click(object sender, EventArgs e)
        {
            listBoxFloat.Items.Clear();
            foreach (var item in floatList)
            {
                listBoxFloat.Items.Add(item);
            }
            labelFloatCount.Text = $"Float Listesi Eleman Sayısı: {floatList.Count}";
        }

        private void btnBoolListele_Click(object sender, EventArgs e)
        {
            listBoxBool.Items.Clear();
            foreach (var item in boolList)
            {
                listBoxBool.Items.Add(item);
            }
            labelBoolCount.Text = $"Bool Listesi Eleman Sayısı: {boolList.Count}";
        }

     
    }
}
