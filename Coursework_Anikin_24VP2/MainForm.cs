using System;
using System.Drawing;
using System.Windows.Forms;

namespace Coursework_Anikin_24VP2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static int SelectionSort(int[] arr, int N)
        {
            int StartTime = Environment.TickCount;
            for (int i = N - 1; i > 0; i--)
            {
                int maxIndex = i;
                for (int j = 0; j <= i; j++)
                    if (arr[j] > arr[maxIndex]) maxIndex = j;

                int temp = arr[i];
                arr[i] = arr[maxIndex];
                arr[maxIndex] = temp;
            }
            int ResultTime = Environment.TickCount - StartTime;
            return ResultTime;
        }

        private static int SelectionSortWithMaxMin(int[] arr, int N)
        {
            int StartTime = Environment.TickCount;
            for (int i = 0, j = N - 1; i < j; i++, j--)
            {
                int maxIndex = i;
                int minIndex = i;
                for (int k = i; k <= j; k++)
                {
                    if (arr[k] > arr[maxIndex]) maxIndex = k;
                    if (arr[k] < arr[minIndex]) minIndex = k;
                }

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;

                if (maxIndex == i) maxIndex = minIndex;

                temp = arr[j];
                arr[j] = arr[maxIndex];
                arr[maxIndex] = temp;
            }
            int ResultTime = Environment.TickCount - StartTime;
            return ResultTime;
        }

        private static int InsertionSort(int[] arr, int N)
        {
            int StartTime = Environment.TickCount;
            int minIndex = 0;
            for (int i = 1; i < N; i++)
            {
                if (arr[i] < arr[minIndex])
                    minIndex = i;
            }

            int temp = arr[0];
            arr[0] = arr[minIndex];
            arr[minIndex] = temp;

            for (int i = 2; i < N; i++)
            {
                int x = arr[i];
                int j = i - 1;
                while (arr[j] > x)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = x;
            }

            int ResultTime = Environment.TickCount - StartTime;
            return ResultTime;
        }

        private void Sort(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(SizeUpDown.Value);
                if (size <= 0)
                    throw new Exception("Ошибка: не задана размерность массива!");
                if (size < 10)
                    throw new Exception("Ошибка: слишком маленькая размерность массива для анализа!");

                int[] UnsortedArray = new int[size];

                Random rand = new Random();

                if (RadioBtn1.Checked)
                {
                    for (int i = 0; i < size; i++)
                    {
                        UnsortedArray[i] = rand.Next(0, size);
                    }
                }
                else if (RadioBtn2.Checked)
                {
                    UnsortedArray[0] = rand.Next(0, 5);
                    for (int i = 1; i < size; i++)
                    {
                        UnsortedArray[i] = UnsortedArray[i - 1] + rand.Next(0, 5);
                    }
                }
                else if (RadioBtn3.Checked)
                {
                    UnsortedArray[size - 1] = rand.Next(0, 5);
                    for (int i = size - 2; i >= 0; i--)
                    {
                        UnsortedArray[i] = UnsortedArray[i + 1] + rand.Next(0, 5);
                    }
                }
                else if (RadioBtn4.Checked)
                {
                    int perOrd = Convert.ToInt32(PercentUpDown.Value);
                    if (perOrd < 0 || perOrd > 100)
                        throw new Exception("Ошибка: процент упорядоченности должен быть от 0 до 100!");

                    int orderCount = (size * perOrd) / 100;

                    UnsortedArray[0] = rand.Next(0, 5);
                    for (int i = 1; i < orderCount; i++)
                    {
                        UnsortedArray[i] = UnsortedArray[i - 1] + rand.Next(0, 5);
                    }

                    for (int i = orderCount; i < size; i++)
                    {
                        UnsortedArray[i] = rand.Next(0, size);
                    }
                }
                else
                {
                    throw new Exception("Ошибка: выберите тип упорядоченности массива!");
                }

                Table.Rows.Clear();
                foreach (var s in Chart.Series) s.Points.Clear();

                int rowSel = Table.Rows.Add("Прямым выбором");
                int rowMaxMin = Table.Rows.Add("Прямым выбором (макс. и мин.)");
                int rowIns = Table.Rows.Add("Прямым включением с мин. барьером");

                for (int p = 1; p <= 10; p++)
                {
                    int currentSize = size * p / 10;

                    int[] arr1 = new int[currentSize];
                    int[] arr2 = new int[currentSize];
                    int[] arr3 = new int[currentSize];

                    Array.Copy(UnsortedArray, arr1, currentSize);
                    Array.Copy(UnsortedArray, arr2, currentSize);
                    Array.Copy(UnsortedArray, arr3, currentSize);

                    int time1 = SelectionSort(arr1, currentSize);
                    int time2 = SelectionSortWithMaxMin(arr2, currentSize);
                    int time3 = InsertionSort(arr3, currentSize);

                    Table.Rows[rowSel].Cells[p].Value = time1;
                    Table.Rows[rowMaxMin].Cells[p].Value = time2;
                    Table.Rows[rowIns].Cells[p].Value = time3;

                    Chart.Series[0].Points.AddXY(currentSize, time1);
                    Chart.Series[1].Points.AddXY(currentSize, time2);
                    Chart.Series[2].Points.AddXY(currentSize, time3);
                }

                double minX = Chart.Series[0].Points[0].XValue;
                double maxX = Chart.Series[0].Points[Chart.Series[0].Points.Count - 1].XValue;

                Chart.ChartAreas[0].AxisX.Minimum = minX;
                Chart.ChartAreas[0].AxisX.Maximum = maxX;
                Chart.ChartAreas[0].AxisX.Interval = size / 10;

                TextBox.Text = "Сортировки выполнены.\nОшибок нет.";
                TextBox.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                TextBox.Text = ex.Message;
                TextBox.ForeColor = Color.Red;
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void PartOrderChecked(object sender, EventArgs e)
        {
            if (RadioBtn4.Checked) PercentUpDown.Enabled = true;
            else PercentUpDown.Enabled = false;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            Table.Rows.Add("Прямым выбором");
            Table.Rows.Add("Прямым выбором (макс. и мин.)");
            Table.Rows.Add("Прямым включением с мин. барьером");
        }
    }
}
