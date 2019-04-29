namespace Arrays1
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
            this.textBoxSizeM = new System.Windows.Forms.TextBox();
            this.labelMas = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonRandGen = new System.Windows.Forms.Button();
            this.dataGridViewMas = new System.Windows.Forms.DataGridView();
            this.labelSumNeg = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMaxIndex = new System.Windows.Forms.Label();
            this.labelMaxM = new System.Windows.Forms.Label();
            this.labelIntDigit = new System.Windows.Forms.Label();
            this.labelSumIndPositive = new System.Windows.Forms.Label();
            this.textBoxSumNeg = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMaxIndex = new System.Windows.Forms.TextBox();
            this.textBoxMaxM = new System.Windows.Forms.TextBox();
            this.textBoxIntDigit = new System.Windows.Forms.TextBox();
            this.textBoxSumIndPositive = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSizeM
            // 
            this.textBoxSizeM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSizeM.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSizeM.Location = new System.Drawing.Point(281, 65);
            this.textBoxSizeM.Name = "textBoxSizeM";
            this.textBoxSizeM.Size = new System.Drawing.Size(100, 32);
            this.textBoxSizeM.TabIndex = 0;
            // 
            // labelMas
            // 
            this.labelMas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMas.AutoSize = true;
            this.labelMas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMas.Location = new System.Drawing.Point(39, 69);
            this.labelMas.Name = "labelMas";
            this.labelMas.Size = new System.Drawing.Size(236, 25);
            this.labelMas.TabIndex = 1;
            this.labelMas.Text = "Кількіть елементів масиву=";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(412, 64);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(105, 32);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Створити";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonRandGen
            // 
            this.buttonRandGen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRandGen.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandGen.Location = new System.Drawing.Point(523, 64);
            this.buttonRandGen.Name = "buttonRandGen";
            this.buttonRandGen.Size = new System.Drawing.Size(96, 32);
            this.buttonRandGen.TabIndex = 3;
            this.buttonRandGen.Text = "Заповнити";
            this.buttonRandGen.UseVisualStyleBackColor = true;
            this.buttonRandGen.Visible = false;
            this.buttonRandGen.Click += new System.EventHandler(this.buttonRandGen_Click);
            // 
            // dataGridViewMas
            // 
            this.dataGridViewMas.AllowUserToAddRows = false;
            this.dataGridViewMas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMas.Location = new System.Drawing.Point(40, 136);
            this.dataGridViewMas.Name = "dataGridViewMas";
            this.dataGridViewMas.Size = new System.Drawing.Size(567, 85);
            this.dataGridViewMas.TabIndex = 4;
            // 
            // labelSumNeg
            // 
            this.labelSumNeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumNeg.AutoSize = true;
            this.labelSumNeg.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumNeg.Location = new System.Drawing.Point(39, 276);
            this.labelSumNeg.Name = "labelSumNeg";
            this.labelSumNeg.Size = new System.Drawing.Size(234, 25);
            this.labelSumNeg.TabIndex = 5;
            this.labelSumNeg.Text = "Сума від’ємних елементів=";
            // 
            // labelMax
            // 
            this.labelMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMax.Location = new System.Drawing.Point(39, 314);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(107, 25);
            this.labelMax.TabIndex = 6;
            this.labelMax.Text = "Максимум=";
            // 
            // labelMaxIndex
            // 
            this.labelMaxIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaxIndex.AutoSize = true;
            this.labelMaxIndex.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxIndex.Location = new System.Drawing.Point(39, 352);
            this.labelMaxIndex.Name = "labelMaxIndex";
            this.labelMaxIndex.Size = new System.Drawing.Size(170, 25);
            this.labelMaxIndex.TabIndex = 7;
            this.labelMaxIndex.Text = "Індекс максимума=";
            // 
            // labelMaxM
            // 
            this.labelMaxM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaxM.AutoSize = true;
            this.labelMaxM.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxM.Location = new System.Drawing.Point(39, 390);
            this.labelMaxM.Name = "labelMaxM";
            this.labelMaxM.Size = new System.Drawing.Size(208, 25);
            this.labelMaxM.TabIndex = 8;
            this.labelMaxM.Text = "Максимум за модулем=";
            // 
            // labelIntDigit
            // 
            this.labelIntDigit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIntDigit.AutoSize = true;
            this.labelIntDigit.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIntDigit.Location = new System.Drawing.Point(39, 466);
            this.labelIntDigit.Name = "labelIntDigit";
            this.labelIntDigit.Size = new System.Drawing.Size(193, 25);
            this.labelIntDigit.TabIndex = 9;
            this.labelIntDigit.Text = "Кількість цілих чисел=";
            // 
            // labelSumIndPositive
            // 
            this.labelSumIndPositive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumIndPositive.AutoSize = true;
            this.labelSumIndPositive.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumIndPositive.Location = new System.Drawing.Point(39, 428);
            this.labelSumIndPositive.Name = "labelSumIndPositive";
            this.labelSumIndPositive.Size = new System.Drawing.Size(209, 25);
            this.labelSumIndPositive.TabIndex = 10;
            this.labelSumIndPositive.Text = "Сума індексів додатніх=";
            // 
            // textBoxSumNeg
            // 
            this.textBoxSumNeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSumNeg.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumNeg.Location = new System.Drawing.Point(279, 273);
            this.textBoxSumNeg.Name = "textBoxSumNeg";
            this.textBoxSumNeg.Size = new System.Drawing.Size(100, 32);
            this.textBoxSumNeg.TabIndex = 11;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMax.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMax.Location = new System.Drawing.Point(279, 311);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 32);
            this.textBoxMax.TabIndex = 12;
            // 
            // textBoxMaxIndex
            // 
            this.textBoxMaxIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMaxIndex.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxIndex.Location = new System.Drawing.Point(279, 349);
            this.textBoxMaxIndex.Name = "textBoxMaxIndex";
            this.textBoxMaxIndex.Size = new System.Drawing.Size(100, 32);
            this.textBoxMaxIndex.TabIndex = 13;
            // 
            // textBoxMaxM
            // 
            this.textBoxMaxM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMaxM.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxM.Location = new System.Drawing.Point(279, 387);
            this.textBoxMaxM.Name = "textBoxMaxM";
            this.textBoxMaxM.Size = new System.Drawing.Size(100, 32);
            this.textBoxMaxM.TabIndex = 14;
            // 
            // textBoxIntDigit
            // 
            this.textBoxIntDigit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIntDigit.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIntDigit.Location = new System.Drawing.Point(279, 463);
            this.textBoxIntDigit.Name = "textBoxIntDigit";
            this.textBoxIntDigit.Size = new System.Drawing.Size(100, 32);
            this.textBoxIntDigit.TabIndex = 15;
            // 
            // textBoxSumIndPositive
            // 
            this.textBoxSumIndPositive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSumIndPositive.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumIndPositive.Location = new System.Drawing.Point(279, 425);
            this.textBoxSumIndPositive.Name = "textBoxSumIndPositive";
            this.textBoxSumIndPositive.Size = new System.Drawing.Size(100, 32);
            this.textBoxSumIndPositive.TabIndex = 16;
            // 
            // buttonCount
            // 
            this.buttonCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCount.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCount.Location = new System.Drawing.Point(142, 235);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(375, 32);
            this.buttonCount.TabIndex = 17;
            this.buttonCount.Text = "Підрахувати";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 511);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxSumIndPositive);
            this.Controls.Add(this.textBoxIntDigit);
            this.Controls.Add(this.textBoxMaxM);
            this.Controls.Add(this.textBoxMaxIndex);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxSumNeg);
            this.Controls.Add(this.labelSumIndPositive);
            this.Controls.Add(this.labelIntDigit);
            this.Controls.Add(this.labelMaxM);
            this.Controls.Add(this.labelMaxIndex);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelSumNeg);
            this.Controls.Add(this.dataGridViewMas);
            this.Controls.Add(this.buttonRandGen);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelMas);
            this.Controls.Add(this.textBoxSizeM);
            this.MaximumSize = new System.Drawing.Size(862, 550);
            this.MinimumSize = new System.Drawing.Size(662, 550);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSizeM;
        private System.Windows.Forms.Label labelMas;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonRandGen;
        private System.Windows.Forms.DataGridView dataGridViewMas;
        private System.Windows.Forms.Label labelSumNeg;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMaxIndex;
        private System.Windows.Forms.Label labelMaxM;
        private System.Windows.Forms.Label labelIntDigit;
        private System.Windows.Forms.Label labelSumIndPositive;
        private System.Windows.Forms.TextBox textBoxSumNeg;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxMaxIndex;
        private System.Windows.Forms.TextBox textBoxMaxM;
        private System.Windows.Forms.TextBox textBoxIntDigit;
        private System.Windows.Forms.TextBox textBoxSumIndPositive;
        private System.Windows.Forms.Button buttonCount;
    }
}

