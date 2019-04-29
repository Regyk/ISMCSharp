using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void buttonCreate_Click_1(object sender, EventArgs e)
        {
            dataGridViewMas.Columns.Clear();
            if (!int.TryParse(textBoxSizeM.Text, out int size))
            {
                MessageBox.Show("Значення введено не коректно");
            }
            else
            {
                dataGridViewMas.ColumnCount = size;
                dataGridViewMas.Rows.Add();
            }
            buttonRandGen.Visible = true;
        }

        private void buttonRandGen_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (!int.TryParse(textBoxSizeM.Text, out int size))
            {
                MessageBox.Show("Значення введено не коректно");
            }
            else
            {
                double[] mas = new double[size];
                for (int i = 0; i < mas.Length; i++)
                {
                    var column1 = new DataGridViewColumn();

                    mas[i] = Convert.ToDouble(rnd.Next(-1000, 1010) / 10.0);
                    dataGridViewMas[i, 0].Value = mas[i];
                }

            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSizeM.Text, out int size))
            {
                MessageBox.Show("Значення введено не коректно");
            }
            else
            {
                try
                {
                    double[] mas = new double[size];
                    for (int i = 0; i < size; i++)
                    {
                        mas[i] = Convert.ToDouble(dataGridViewMas[i, 0].Value);
                    }
                    double  SAfM = mas[0], SumSAfM = 1, counter = 0 , Sum1neg2pos=0;
                    bool flag1 = false ;
                    int Second = 0, First = 0,FNeg=0, SPos=0;
                    for (int i = 0; i < mas.Length; i++)
                    {
                        if (SAfM >= mas[i])
                        {
                            SumSAfM = 1;
                            SAfM = mas[i];
                        }
                        else if (SAfM < mas[i])
                        {
                            SumSAfM = SumSAfM * mas[i];
                        }
                    }

                    for (int i = 0; i < mas.Length; i++)
                    {
                        if(mas[i]<0 && flag1==false)
                        {
                            FNeg = i;
                            flag1 = true;
                        }
                        if (mas[i] > 0)
                        {
                            if(counter == 1)
                            {
                                SPos = i;

                            }
                            counter++;
                        }
                    }
                    if(FNeg<SPos)
                    {
                        First = FNeg;
                        Second = SPos;
                    }
                    else
                    {
                        First = SPos;
                        Second = FNeg;
                    }
                    First++;
                    for (int i = First; i < Second; i++)
                    {
                        Sum1neg2pos+= mas[i];    
                    }
                    if(Sum1neg2pos==1)
                    {
                        Sum1neg2pos = 0;
                    }
                    bool flag0n0 = false;
                    int First0n0 = 0, Last0n0 = 0;
                    double SumFnL0=0;
                    for (int i = 0; i < mas.Length; i++)
                    {
                        if (mas[i] == 0 && flag0n0 == false)
                        {
                            First0n0 = i;
                            flag0n0 = true;
                        }
                        if (mas[i] == 0)
                        {
                            Last0n0 = i;                           
                        }
                    }
                    if (Last0n0!=0 && First0n0!=Last0n0)
                        {
                        First0n0++;
                    for (int i = First0n0; i < Last0n0; i++)
                    {
                            SumFnL0 += mas[i];
                    }
                        } 
                    else
                    {
                        SumFnL0 = 0;
                    }
                    double maxAbs =Math.Abs(mas[0]), minAbs = Math.Abs(mas[0]), SumMaxNMinAbs=1;
                    int indMax = 0, indMin = 0, SecondInd=0, FirstInd=0;
                    for (int i = 0; i < mas.Length; i++)
                    {
                        if(maxAbs< Math.Abs(mas[i]))
                        {
                            maxAbs = Math.Abs(mas[i]);
                            indMax = i;
                        }
                        if (minAbs > Math.Abs(mas[i]))
                        {
                            minAbs = Math.Abs(mas[i]);
                            indMin = i;
                        }
                    }
                    if (indMin < indMax)
                    {
                        FirstInd = indMin;
                        SecondInd = indMax;
                    }
                    else
                    {
                        FirstInd = indMax;
                        SecondInd = indMin;
                    }
                    FirstInd++;
                    for (int i = FirstInd; i < SecondInd; i++)
                    {
                        SumMaxNMinAbs = SumMaxNMinAbs * mas[i];
                    }
                    if(FirstInd==SecondInd)
                    {
                        SumMaxNMinAbs = 0;
                    }
                    textSumAfterMin.Text = SumSAfM.ToString();
                    textBoxSum1neg2pos.Text = Sum1neg2pos.ToString();
                    textBoxSumFnL0.Text = SumFnL0.ToString();
                    textBoxSumMaxNMinAbs.Text = SumMaxNMinAbs.ToString();
                }
                catch
                {
                    MessageBox.Show("Помилка!!!");
                }
            }
        }
    }
}
