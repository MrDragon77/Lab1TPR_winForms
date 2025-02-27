using System.Data;

namespace Lab1TPR_winForms
{
    public partial class Form1 : Form
    {
        DataSet dataset;
        bool datasetCreated = false;
        int savedStrategyNum = 0;
        int savedConditionNum = 0;
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
            bool isNeedToCreateDataset = false;
            if (!datasetCreated)
            {
                isNeedToCreateDataset = true;
            }
            else
            {
                if (savedStrategyNum != Int32.Parse(textBox_strategyNum.Text) || savedConditionNum != Int32.Parse(textBox_conditionNum.Text))
                {
                    DialogResult result = MessageBox.Show("В кеше уже есть сохраненная матрица. \nДа - загрузить ее из кеша.\n Нет - Создать новую матрицу", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        textBox_strategyNum.Text = savedStrategyNum.ToString();
                        textBox_conditionNum.Text = savedConditionNum.ToString();
                        isNeedToCreateDataset = false;
                    }
                    else if (result == DialogResult.No)
                    {
                        isNeedToCreateDataset = true;
                    }
                }
            }

            if (isNeedToCreateDataset)
            {
                int strategyNum = Int32.Parse(textBox_strategyNum.Text);
                int conditionNum = Int32.Parse(textBox_conditionNum.Text);
                savedStrategyNum = strategyNum;
                savedConditionNum = conditionNum;
                dataset = new DataSet();
                for (int i = 1; i <= strategyNum; i++)
                {
                    DataTable strategy = new DataTable("s" + i.ToString());
                    for (int j = 0; j < conditionNum; j++)
                    {
                        strategy.Columns.Add("");
                        strategy.Rows.Add("");
                    }

                    DataTable dohod = new DataTable("d" + i.ToString());
                    for (int j = 0; j < conditionNum; j++)
                    {
                        dohod.Columns.Add("");
                        dohod.Rows.Add("");
                    }

                    dataset.Tables.Add(strategy);
                    dataset.Tables.Add(dohod);
                }
                datasetCreated = true;
            }
            //int tablesNumerator = 1;
            using (Form2 form2 = new Form2(dataset, savedStrategyNum))
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
            if (File.Exists(saveName))
            {
                MessageBox.Show("Файл с таким именем уже существует");
            }
            else
            {
                DataTable stateTable = new DataTable("state"); //название технической таблицы state
                stateTable.Columns.Add("strategyNum", typeof(int));
                stateTable.Columns.Add("conditionNum", typeof(int));
                stateTable.Columns.Add("stepNum", typeof(int));
                stateTable.Rows.Add(savedStrategyNum, savedConditionNum, Int32.Parse(textBox_stepNum.Text));
                dataset.Tables.Add(stateTable);
                dataset.WriteXml(saveName);
                MessageBox.Show("Файл сохранен");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string openName = textBox_saveName.Text + ".xml";
            if (File.Exists(openName))
            {
                dataset = new DataSet();
                dataset.ReadXml(openName);
                DataTable stateTable = dataset.Tables["state"];
                textBox_strategyNum.Text = stateTable.Rows[0]["strategyNum"].ToString();
                savedStrategyNum = Int32.Parse(stateTable.Rows[0]["strategyNum"].ToString());
                textBox_conditionNum.Text = stateTable.Rows[0]["conditionNum"].ToString();
                savedConditionNum = Int32.Parse(stateTable.Rows[0]["conditionNum"].ToString());
                textBox_stepNum.Text = stateTable.Rows[0]["stepNum"].ToString();
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