namespace Integral2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.formA = new System.Windows.Forms.TextBox();
            this.formB = new System.Windows.Forms.TextBox();
            this.formN = new System.Windows.Forms.TextBox();
            this.formType = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mainTable = new System.Windows.Forms.DataGridView();
            this.methodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discrepancy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Интегрирование";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выбор уравнения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "b:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "n:";
            // 
            // formA
            // 
            this.formA.Location = new System.Drawing.Point(38, 75);
            this.formA.Name = "formA";
            this.formA.Size = new System.Drawing.Size(100, 20);
            this.formA.TabIndex = 5;
            // 
            // formB
            // 
            this.formB.Location = new System.Drawing.Point(38, 100);
            this.formB.Name = "formB";
            this.formB.Size = new System.Drawing.Size(100, 20);
            this.formB.TabIndex = 6;
            // 
            // formN
            // 
            this.formN.Location = new System.Drawing.Point(37, 126);
            this.formN.Name = "formN";
            this.formN.Size = new System.Drawing.Size(100, 20);
            this.formN.TabIndex = 7;
            // 
            // formType
            // 
            this.formType.FormattingEnabled = true;
            this.formType.Items.AddRange(new object[] {
            "1 / ( 5-3*cos(x) )",
            "1 / ( ( 1+x^2 )^2 )",
            "Заданная таблица"});
            this.formType.Location = new System.Drawing.Point(160, 50);
            this.formType.Name = "formType";
            this.formType.Size = new System.Drawing.Size(121, 21);
            this.formType.TabIndex = 8;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(185, 124);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 9;
            this.start.Text = "Рассчет";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(169, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Результаты решения";
            // 
            // mainTable
            // 
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.methodName,
            this.result,
            this.discrepancy});
            this.mainTable.Location = new System.Drawing.Point(4, 201);
            this.mainTable.Name = "mainTable";
            this.mainTable.Size = new System.Drawing.Size(444, 237);
            this.mainTable.TabIndex = 21;
            // 
            // methodName
            // 
            this.methodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.methodName.HeaderText = "Название метода";
            this.methodName.Name = "methodName";
            this.methodName.ReadOnly = true;
            this.methodName.Width = 112;
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.result.HeaderText = "Результат";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Width = 84;
            // 
            // discrepancy
            // 
            this.discrepancy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.discrepancy.HeaderText = "Невязка";
            this.discrepancy.Name = "discrepancy";
            this.discrepancy.ReadOnly = true;
            this.discrepancy.Width = 76;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.start);
            this.Controls.Add(this.formType);
            this.Controls.Add(this.formN);
            this.Controls.Add(this.formB);
            this.Controls.Add(this.formA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox formA;
        private System.Windows.Forms.TextBox formB;
        private System.Windows.Forms.TextBox formN;
        private System.Windows.Forms.ComboBox formType;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView mainTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn discrepancy;
    }
}

