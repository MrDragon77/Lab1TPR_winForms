using System.Data;

namespace Lab1TPR_winForms
{
    public partial class Form1 : Form
    {
        DataSet dataset;
        bool datasetCreated = false;
        int savedStrategyNums = 0;
        public Form1()
        {
            InitializeComponent();
            dataset = new DataSet();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //|| savedStrategyNums != Int32.Parse(textBox_strategyNum.Text)
            if (!datasetCreated)
            {
                //if(savedStrategyNums != Int32.Parse(textBox_strategyNum.Text))
                //{
                //    MessageForm messageForm = new MessageForm("Вы уверены что хотите удалить ")
                //}
                int strategyNum = Int32.Parse(textBox_strategyNum.Text);
                dataset = new DataSet();
                for (int i = 1; i <= strategyNum; i++)
                {
                    DataTable strategy = new DataTable("s" + i.ToString());
                    for (int j = 0; j < 3; j++)
                    {
                        strategy.Columns.Add("");
                    }

                    DataTable dohod = new DataTable("d" + i.ToString());
                    for (int j = 0; j < 3; j++)
                    {
                        dohod.Columns.Add("");
                    }

                    dataset.Tables.Add(strategy);
                    dataset.Tables.Add(dohod);
                }
                datasetCreated = true;
            }
            //int tablesNumerator = 1;
            using (Form2 form2 = new Form2(dataset))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    dataset = form2.datasetTemp;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string saveName = textBox_saveName.Text + ".xml";
            dataset.WriteXml(saveName);
            MessageBox.Show("Файл сохранен");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string openName = textBox_saveName.Text + ".xml";
            if (File.Exists(openName))
            {
                dataset = new DataSet();
                dataset.ReadXml(openName);
                MessageBox.Show("Файл загружен");
                datasetCreated = true;
            }
            else
            {
                MessageBox.Show("Файла с таким именем нет");
            }

        }
    }
}