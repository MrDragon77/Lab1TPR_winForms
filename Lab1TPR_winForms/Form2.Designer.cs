namespace Lab1TPR_winForms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView_strategy = new DataGridView();
            dataGridView_dohod = new DataGridView();
            numericUpDown_tableID = new NumericUpDown();
            button_SaveChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_strategy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dohod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_tableID).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 46);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "Таблица вероятностей";
            // 
            // dataGridView_strategy
            // 
            dataGridView_strategy.AllowUserToAddRows = false;
            dataGridView_strategy.AllowUserToDeleteRows = false;
            dataGridView_strategy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_strategy.Location = new Point(60, 72);
            dataGridView_strategy.Margin = new Padding(3, 2, 3, 2);
            dataGridView_strategy.Name = "dataGridView_strategy";
            dataGridView_strategy.RowHeadersWidth = 51;
            dataGridView_strategy.RowTemplate.Height = 29;
            dataGridView_strategy.Size = new Size(612, 136);
            dataGridView_strategy.TabIndex = 1;
            dataGridView_strategy.SelectionChanged += dataGridView_strategy_SelectionChanged;
            // 
            // dataGridView_dohod
            // 
            dataGridView_dohod.AllowUserToAddRows = false;
            dataGridView_dohod.AllowUserToDeleteRows = false;
            dataGridView_dohod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_dohod.Location = new Point(60, 257);
            dataGridView_dohod.Margin = new Padding(3, 2, 3, 2);
            dataGridView_dohod.Name = "dataGridView_dohod";
            dataGridView_dohod.RowHeadersWidth = 51;
            dataGridView_dohod.RowTemplate.Height = 29;
            dataGridView_dohod.Size = new Size(612, 131);
            dataGridView_dohod.TabIndex = 2;
            dataGridView_dohod.SelectionChanged += dataGridView_dohod_SelectionChanged;
            // 
            // numericUpDown_tableID
            // 
            numericUpDown_tableID.Location = new Point(500, 41);
            numericUpDown_tableID.Margin = new Padding(3, 2, 3, 2);
            numericUpDown_tableID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_tableID.Name = "numericUpDown_tableID";
            numericUpDown_tableID.Size = new Size(162, 23);
            numericUpDown_tableID.TabIndex = 3;
            numericUpDown_tableID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_tableID.ValueChanged += numericUpDown_tableID_ValueChanged;
            // 
            // button_SaveChanges
            // 
            button_SaveChanges.Location = new Point(528, 403);
            button_SaveChanges.Margin = new Padding(3, 2, 3, 2);
            button_SaveChanges.Name = "button_SaveChanges";
            button_SaveChanges.Size = new Size(176, 22);
            button_SaveChanges.TabIndex = 4;
            button_SaveChanges.Text = "Сохранить изменения";
            button_SaveChanges.UseVisualStyleBackColor = true;
            button_SaveChanges.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 446);
            Controls.Add(button_SaveChanges);
            Controls.Add(numericUpDown_tableID);
            Controls.Add(dataGridView_dohod);
            Controls.Add(dataGridView_strategy);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Редактирование матрицы вероятностей";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_strategy).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dohod).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_tableID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView_strategy;
        private DataGridView dataGridView_dohod;
        private NumericUpDown numericUpDown_tableID;
        private Button button_SaveChanges;
    }
}