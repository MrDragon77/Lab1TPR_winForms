namespace Lab1TPR_winForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button_StartModelling = new Button();
            textBox_strategyNum = new TextBox();
            textBox_conditionNum = new TextBox();
            label2 = new Label();
            textBox_stepNum = new TextBox();
            label3 = new Label();
            button_EditMatrix = new Button();
            button_LoadFromFile = new Button();
            button_SaveToFile = new Button();
            textBox_saveName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 36);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 0;
            label1.Text = "Количество стратегий";
            // 
            // button_StartModelling
            // 
            button_StartModelling.Location = new Point(448, 270);
            button_StartModelling.Margin = new Padding(3, 2, 3, 2);
            button_StartModelling.Name = "button_StartModelling";
            button_StartModelling.Size = new Size(189, 33);
            button_StartModelling.TabIndex = 1;
            button_StartModelling.Text = "Начать моделирование";
            button_StartModelling.UseVisualStyleBackColor = true;
            // 
            // textBox_strategyNum
            // 
            textBox_strategyNum.Location = new Point(187, 34);
            textBox_strategyNum.Margin = new Padding(3, 2, 3, 2);
            textBox_strategyNum.Name = "textBox_strategyNum";
            textBox_strategyNum.Size = new Size(110, 23);
            textBox_strategyNum.TabIndex = 2;
            // 
            // textBox_conditionNum
            // 
            textBox_conditionNum.Location = new Point(187, 86);
            textBox_conditionNum.Margin = new Padding(3, 2, 3, 2);
            textBox_conditionNum.Name = "textBox_conditionNum";
            textBox_conditionNum.Size = new Size(110, 23);
            textBox_conditionNum.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 88);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 3;
            label2.Text = "Количество состояний";
            // 
            // textBox_stepNum
            // 
            textBox_stepNum.Location = new Point(226, 276);
            textBox_stepNum.Margin = new Padding(3, 2, 3, 2);
            textBox_stepNum.Name = "textBox_stepNum";
            textBox_stepNum.Size = new Size(110, 23);
            textBox_stepNum.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 278);
            label3.Name = "label3";
            label3.Size = new Size(201, 15);
            label3.TabIndex = 5;
            label3.Text = "Количество шагов моделирования";
            // 
            // button_EditMatrix
            // 
            button_EditMatrix.Location = new Point(54, 153);
            button_EditMatrix.Margin = new Padding(3, 2, 3, 2);
            button_EditMatrix.Name = "button_EditMatrix";
            button_EditMatrix.Size = new Size(257, 35);
            button_EditMatrix.TabIndex = 7;
            button_EditMatrix.Text = "Редактировать матрицу вероятностей";
            button_EditMatrix.UseVisualStyleBackColor = true;
            button_EditMatrix.Click += button2_Click;
            // 
            // button_LoadFromFile
            // 
            button_LoadFromFile.Location = new Point(448, 58);
            button_LoadFromFile.Margin = new Padding(3, 2, 3, 2);
            button_LoadFromFile.Name = "button_LoadFromFile";
            button_LoadFromFile.Size = new Size(131, 40);
            button_LoadFromFile.TabIndex = 8;
            button_LoadFromFile.Text = "Загрузка данных из файла";
            button_LoadFromFile.UseVisualStyleBackColor = true;
            button_LoadFromFile.Click += button3_Click;
            // 
            // button_SaveToFile
            // 
            button_SaveToFile.Location = new Point(584, 58);
            button_SaveToFile.Margin = new Padding(3, 2, 3, 2);
            button_SaveToFile.Name = "button_SaveToFile";
            button_SaveToFile.Size = new Size(121, 40);
            button_SaveToFile.TabIndex = 9;
            button_SaveToFile.Text = "Сохранить данные в файл";
            button_SaveToFile.UseVisualStyleBackColor = true;
            button_SaveToFile.Click += button4_Click;
            // 
            // textBox_saveName
            // 
            textBox_saveName.Location = new Point(448, 34);
            textBox_saveName.Margin = new Padding(3, 2, 3, 2);
            textBox_saveName.Name = "textBox_saveName";
            textBox_saveName.Size = new Size(258, 23);
            textBox_saveName.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 428);
            Controls.Add(textBox_saveName);
            Controls.Add(button_SaveToFile);
            Controls.Add(button_LoadFromFile);
            Controls.Add(button_EditMatrix);
            Controls.Add(textBox_stepNum);
            Controls.Add(label3);
            Controls.Add(textBox_conditionNum);
            Controls.Add(label2);
            Controls.Add(textBox_strategyNum);
            Controls.Add(button_StartModelling);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Ввод параметров модуляции";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_StartModelling;
        private TextBox textBox_strategyNum;
        private TextBox textBox_conditionNum;
        private Label label2;
        private TextBox textBox_stepNum;
        private Label label3;
        private Button button_EditMatrix;
        private Button button_LoadFromFile;
        private Button button_SaveToFile;
        private TextBox textBox_saveName;
    }
}