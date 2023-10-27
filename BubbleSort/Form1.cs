using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BubbleSort
{
    public partial class Form1 : Form
    {
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

          
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
               
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        public static class Globals
        {
          public static int n = 100;
          public static int[] data = new int[n];
        }
        
        public void randomize()
        {
            var rand = new Random();
            //int[] data = new int[Globals.n];
            chart1.Series["random array"].Points.Clear();

            for (int i = 0; i < Globals.n; i++)
            {
                Globals.data[i] = rand.Next(0, 100);
                chart1.Series["random array"].Points.AddXY(i + 1, Globals.data[i]);
                wait(1);
                //updateChart();

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int n = Globals.n;
            var rand = new Random();
            int[] data = new int[Globals.n];
            chart1.Series.Clear();
            chart1.Series.Add("random array");
            randomize();
        }
        
        private void updateChart()
        {
            for (int i =0;i<Globals.n;i++)
            {
                chart1.Series["random array"].Points[i].YValues[0] = Globals.data[i];
            }
            chart1.Invalidate();
        }

        private void bubbleSort()
        {
            int n = Globals.n;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (Globals.data[j] > Globals.data[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = Globals.data[j];
                        Globals.data[j] = Globals.data[j + 1];
                        Globals.data[j + 1] = temp;
                        wait(1);
                        updateChart();

                    }
                   
                    //System.Threading.Thread.Sleep(1);
                    
                }

            }
            
        }

        private void selectionSort()
        {
            int n = Globals.n;

            for(int i = 0;i<n-1;i++)
            {
                int min_index = i;
               // int j = i + 1;
                for(int j = i+1;j<n;j++)
                {
                    if(Globals.data[j]<Globals.data[min_index])
                    {
                        min_index = j;
                        wait(1);
                        updateChart();
                    }
                }
                int tempInt = Globals.data[min_index];
                Globals.data[min_index] = Globals.data[i];
                Globals.data[i] = tempInt;

               // updateChart();
                     
            }
            updateChart();
        }

        private void merge(int[] Arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for(i = 0;i<n1;i++)
            {
                L[i] = Arr[l + i];
            }
            
            for(j = 0;j<n2;j++)
            {
                R[j] = Arr[m+j+1];
            }
            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    Arr[k] = L[i];
                    i++;
                }
                else
                {
                    Arr[k] = R[j];
                    j++;
                }
                k++;
                wait(1);
                updateChart();
            }
            while (i < n1)
            {
                Arr[k] = L[i];
                i++;
                k++;
            }
            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                Arr[k] = R[j];
                j++;
                k++;
            }
        }
        void mergeSort(int[] Arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle
                // point
                int m = l + (r - l) / 2;

                // Sort first and
                // second halves
                mergeSort(Arr, l, m);
                mergeSort(Arr, m + 1, r);

                // Merge the sorted halves
                merge(Arr, l, m, r);


            }
        }

        void insertionSort()
        {
            int n = Globals.n;
            for (int i = 1; i < n; ++i)
            {
                int key = Globals.data[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && Globals.data[j] > key)
                {
                    Globals.data[j + 1] = Globals.data[j];
                    j = j - 1;
                }
                Globals.data[j + 1] = key;
                wait(1);
                updateChart();
            }
        }

        static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


        int partition(int[] arr, int low, int high)
        {


            int pivot = arr[high];


            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {


                if (arr[j] < pivot)
                {


                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            wait(1);
            updateChart();
            return (i + 1);
            
        }


        void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {


                int pi = partition(arr, low, high);

                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
                updateChart();
            }
        }

        private void Randomize_Click(object sender, EventArgs e)
        {
            randomize();
        }

        private void bubbleSortButton_Click(object sender, EventArgs e)
        {
            bubbleSort();
        }

        private void selectionSortButton_Click(object sender, EventArgs e)
        {
            selectionSort();
        }

        private void mergeSortButton_Click(object sender, EventArgs e)
        {
            mergeSort(Globals.data, 0, Globals.n - 1);
            //mergeSort();
            updateChart();

        }

        private void insertionSortButton_Click(object sender, EventArgs e)
        {
            insertionSort();
            updateChart();

        }

        private void quickSortButton_Click(object sender, EventArgs e)
        {
            quickSort(Globals.data, 0, Globals.n - 1);
            wait(1);
            updateChart();
        }
    }
}
