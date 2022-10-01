using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkingApp
{
    public partial class Parking : Form
    {
        int i = 20; //park yeri sayi
        int j = 0; //progress bar'in deyeri
   
      
        Random eded = new Random();
        
        public Parking()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            i--;
            j += 5;
            if (i > 0)
            {
                int n = eded.Next(1, 22);
                numbers.Text = n.ToString();
               /* if (listBox1.Items.Count > 0)
                {
                    for(int s = 0; s < listBox1.Items.Count; s++)
                    {
                        if (numbers.Text == listBox1.Items[s].ToString())
                            MessageBox.Show("Bu avtomobil qarajdadir");
                    }
                }
                else*/
                    listBox1.Items.Add(numbers.Text);


                emptyNumberOfPlaces.Text = Convert.ToString(i);
            }
            if(j <= 100)
                progressBar1.Value = j;
            if (i <= 0)
            { 
                emptyNumberOfPlaces.Text = Convert.ToString(0);
                MessageBox.Show("Boş yer yoxdur.");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            i++;
            j -= 5;
            int m = eded.Next(1, 22);
            if (i <= 20)
            {
                numbers.Text = m.ToString();
                for(int y = 0; y < listBox1.Items.Count; y++)
                {
                    if(numbers.Text == listBox1.Items[y].ToString())
                    {
                        listBox1.Items.RemoveAt(y);
                    }
                }
            }
            emptyNumberOfPlaces.Text = Convert.ToString(i);
            if (j >= 0)
                progressBar1.Value = j;
            if (i >= 20)
            {
                emptyNumberOfPlaces.Text = Convert.ToString(20);
                MessageBox.Show("Bütün yerlər boşdur.");
                i = 20;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Parking_Load(object sender, EventArgs e)
        {

        }
    }
}
