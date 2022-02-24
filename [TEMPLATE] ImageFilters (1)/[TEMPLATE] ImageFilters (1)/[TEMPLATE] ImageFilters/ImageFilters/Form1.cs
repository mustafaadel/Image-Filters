using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZGraphTools;

namespace ImageFilters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[,] ImageMatrix;
        string OpenedFilePath;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the browsed image and display it
                OpenedFilePath = openFileDialog1.FileName;
                ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(ImageMatrix, notFilteredPicture);

            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            label3.Text = "";
            if (OpenedFilePath == null)
                return;
            ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
            string Text = textBox1.Text;
            string Text_Sort = sortTypeComboBox.Text;
            string Text_Filter = filterationTypeComboBox.Text;
            string Text_Trim = Tvalue.Text;
            if( Text_Trim.Length == '0')
            {
                Text_Trim = "1";
            }
            int t = Text_Trim[0] - '0';
            //int t = int.Parse(Text_Trim);
            if (Text_Sort.Length == 0)
                Text_Sort = "0";
            int Sort = Text_Sort[0] - '0';
            if (Text_Filter.Length == 0)
                Text_Filter = "1";
            int Filter = Text_Filter[0] - '0';
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] >= '0' && Text[i] <= '9')
                    continue;
                else
                    return;
            }
            if (Text.Length == 0)
                return;
            int Max_Size = int.Parse(Text);
            // Time calculation 
            int Start=System.Environment.TickCount;
            ImageOperations.ImageFilter(ImageMatrix, Max_Size, Sort, Filter, t);
            int End = System.Environment.TickCount;
            ImageOperations.DisplayImage(ImageMatrix, filtredPicture);
            double Time=End-Start;
            Time /= 1000;
            label3.Text = (Time).ToString();
            label3.Text += " s";

        }


        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
          private void btnZGraphAlpha_Click(object sender, EventArgs e)
        {
            int Max_Size = int.Parse(textBox1.Text);
            int t = int.Parse(Tvalue.Text);
            int Array_size = Max_Size / 2;
            double[] x_axis = new double[Array_size];
            double[] y_axis_counting = new double[Array_size]; 
            double[] y_axis_k = new double[Array_size];
            int xcnt = 0;
            for (int i = 3; i < Max_Size; i+=2)
            {
                x_axis[xcnt] = i;
                double start_k = System.Environment.TickCount;
                ImageOperations.ImageFilter(ImageMatrix,Max_Size,3,1,t);
                double end_k = System.Environment.TickCount;
                double alpha_k = end_k - start_k;
                alpha_k /= 1000;
                y_axis_k[xcnt] = alpha_k;
                double start_counting = System.Environment.TickCount;
                ImageOperations.ImageFilter(ImageMatrix, Max_Size,2,1,t);
                double end_counting = System.Environment.TickCount;
                double alpha_counting = end_counting - start_counting;
                alpha_counting/= 1000;
                y_axis_counting[xcnt] = alpha_counting;
                xcnt++;
            }
              
            //Create a graph and add two curves to it
            ZGraphForm ZGF = new ZGraphForm("Alpha Filter", "Window Size", "Time");
            ZGF.add_curve("Counting Sort", x_axis, y_axis_counting, Color.Red);
            ZGF.add_curve("Kth element", x_axis, y_axis_k, Color.Blue);
            ZGF.Show();
        }
        private void btnZGraphAdaptive_Click(object sender, EventArgs e)
        {
            int Max_Size = int.Parse(textBox1.Text);
            int Array_size = Max_Size / 2;
            double[] x_axis = new double[Array_size];
            double[] y_axis_quick = new double[Array_size];
            double[] y_axis_counting = new double[Array_size];
            int xcnt = 0;
            for (int i = 3; i < Max_Size; i+=2)
            {
                x_axis[xcnt] = i;
                double start_quick = System.Environment.TickCount;
                ImageOperations.ImageFilter(ImageMatrix,Max_Size,1,2,0);
                double end_quick = System.Environment.TickCount;
                double adaptive_quick = end_quick - start_quick;
                adaptive_quick /= 1000;
                y_axis_quick[xcnt] = adaptive_quick;
                double start_counting = System.Environment.TickCount;
                ImageOperations.ImageFilter(ImageMatrix, Max_Size,2,2,0);
                double end_counting = System.Environment.TickCount;
                double adaptive_counting = end_counting - start_counting;
                adaptive_counting/= 1000;
                y_axis_counting[xcnt] = adaptive_counting;
                xcnt++;
            }
            ZGraphForm ZGF = new ZGraphForm("Adaptive Median Filter", "Window Size", "Time");
            ZGF.add_curve("Adaptive Quick Sort", x_axis, y_axis_quick ,Color.Red);
            ZGF.add_curve("Adaptive Counting Sort", x_axis, y_axis_counting, Color.Blue);
            ZGF.Show();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}