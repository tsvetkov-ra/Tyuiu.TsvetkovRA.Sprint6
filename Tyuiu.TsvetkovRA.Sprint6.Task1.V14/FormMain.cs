using Tyuiu.TsvetkovRA.Sprint6.Task1.V14.Lib;
namespace Tyuiu.TsvetkovRA.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_CMV.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_CMV.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_CMV.Text = "";
                textBoxResult_CMV.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_CMV.AppendText("|     X     |   f(x)    |" + Environment.NewLine);
                textBoxResult_CMV.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,7:d}    |   {1,6:f2}  |", startValue, valueArray[i]);
                    textBoxResult_CMV.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_CMV.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 1 âûïîëíèë ñòóäåíò ãðóïïû ÏÊÒá-24-1 ×èãóðîâ Ìàêñèì Âëàäèñëàâîâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
