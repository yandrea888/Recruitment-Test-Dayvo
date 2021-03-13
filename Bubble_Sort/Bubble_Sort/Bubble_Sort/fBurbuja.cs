using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_Sort
{
    public partial class fBurbuja : Form
    {
        public fBurbuja()
        {
            InitializeComponent();
        }

        private void fBurbuja_Load(object sender, EventArgs e)
        {

        }
        void bubbleSort(int[] vector)
        {
            int aux = 0;

            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = 0; j < vector.Length - 1; j++)

                {
                    if (vector[j] > vector[j + 1])  
                            {
                                aux = vector[j];
                                vector[j] = vector[j + 1];
                                vector[j + 1] = aux;
                            }

                }

            }

            textBox1.Text += "neat vector" + Environment.NewLine;

            foreach (int elements in vector) 
            {
                textBox1.Text += elements + Environment.NewLine;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vector = { 8, 2, 4, 1, 0, 6, 9, 3, 7, 5 };

            textBox1.Text = "messy vector" + Environment.NewLine;

            foreach (int element in vector) 
                {
                    textBox1.Text += element + Environment.NewLine;
                }

            bubbleSort(vector);
        }
    }

}

        
