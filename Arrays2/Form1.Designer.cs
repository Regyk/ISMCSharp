namespace Arrays2
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
            this.buttonCount = new System.Windows.Forms.Button();
            this.textBoxSumMaxNMinAbs = new System.Windows.Forms.TextBox();
            this.textBoxSumFnL0 = new System.Windows.Forms.TextBox();
            this.textBoxSum1neg2pos = new System.Windows.Forms.TextBox();
            this.textSumAfterMin = new System.Windows.Forms.TextBox();
            this.labelSumMaxNMinAbs = new System.Windows.Forms.Label();
            this.labelSumFnL0 = new System.Windows.Forms.Label();
            this.labelMax1neg2pos = new System.Windows.Forms.Label();
            this.labelSumAfterMin = new System.Windows.Forms.Label();
            this.dataGridViewMas = new System.Windows.Forms.DataGridView();
            this.buttonRandGen = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelMas = new System.Windows.Forms.Label();
            this.textBoxSizeM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCount
            // 
            this.buttonCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCount.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCount.Location = new System.Drawing.Point(213, 177);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(375, 32);
            this.buttonCount.TabIndex = 35;
            this.buttonCount.Text = "Підрахувати";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textBoxSumMaxNMinAbs
            // 
            this.textBoxSumMaxNMinAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSumMaxNMinAbs.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumMaxNMinAbs.Location = new System.Drawing.Point(547, 329);
            this.textBoxSumMaxNMinAbs.Name = "textBoxSumMaxNMinAbs";
            this.textBoxSumMaxNMinAbs.Size = new System.Drawing.Size(100, 32);
            this.textBoxSumMaxNMinAbs.TabIndex = 32;
            // 
            // textBoxSumFnL0
            // 
            this.textBoxSumFnL0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSumFnL0.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumFnL0.Location = new System.Drawing.Point(547, 291);
            this.textBoxSumFnL0.Name = "textBoxSumFnL0";
            this.textBoxSumFnL0.Size = new System.Drawing.Size(100, 32);
            this.textBoxSumFnL0.TabIndex = 31;
            // 
            // textBoxSum1neg2pos
            // 
            this.textBoxSum1neg2pos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSum1neg2pos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSum1neg2pos.Location = new System.Drawing.Point(547, 253);
            this.textBoxSum1neg2pos.Name = "textBoxSum1neg2pos";
            this.textBoxSum1neg2pos.Size = new System.Drawing.Size(100, 32);
            this.textBoxSum1neg2pos.TabIndex = 30;
            // 
            // textSumAfterMin
            // 
            this.textSumAfterMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSumAfterMin.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSumAfterMin.Location = new System.Drawing.Point(547, 215);
            this.textSumAfterMin.Name = "textSumAfterMin";
            this.textSumAfterMin.Size = new System.Drawing.Size(100, 32);
            this.textSumAfterMin.TabIndex = 29;
            // 
            // labelSumMaxNMinAbs
            // 
            this.labelSumMaxNMinAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumMaxNMinAbs.AutoSize = true;
            this.labelSumMaxNMinAbs.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumMaxNMinAbs.Location = new System.Drawing.Point(110, 336);
            this.labelSumMaxNMinAbs.Name = "labelSumMaxNMinAbs";
            this.labelSumMaxNMinAbs.Size = new System.Drawing.Size(431, 25);
            this.labelSumMaxNMinAbs.TabIndex = 26;
            this.labelSumMaxNMinAbs.Text = "Добуток між максимумом за модулем і мінімумом=";
            // 
            // labelSumFnL0
            // 
            this.labelSumFnL0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumFnL0.AutoSize = true;
            this.labelSumFnL0.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumFnL0.Location = new System.Drawing.Point(110, 298);
            this.labelSumFnL0.Name = "labelSumFnL0";
            this.labelSumFnL0.Size = new System.Drawing.Size(270, 25);
            this.labelSumFnL0.TabIndex = 25;
            this.labelSumFnL0.Text = "Сума між першим і останнім 0=";
            // 
            // labelMax1neg2pos
            // 
            this.labelMax1neg2pos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMax1neg2pos.AutoSize = true;
            this.labelMax1neg2pos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMax1neg2pos.Location = new System.Drawing.Point(110, 260);
            this.labelMax1neg2pos.Name = "labelMax1neg2pos";
            this.labelMax1neg2pos.Size = new System.Drawing.Size(314, 25);
            this.labelMax1neg2pos.TabIndex = 24;
            this.labelMax1neg2pos.Text = "Суму між 1 від’ємним та 2 додатнім=";
            // 
            // labelSumAfterMin
            // 
            this.labelSumAfterMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumAfterMin.AutoSize = true;
            this.labelSumAfterMin.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumAfterMin.Location = new System.Drawing.Point(110, 222);
            this.labelSumAfterMin.Name = "labelSumAfterMin";
            this.labelSumAfterMin.Size = new System.Drawing.Size(335, 25);
            this.labelSumAfterMin.TabIndex = 23;
            this.labelSumAfterMin.Text = "Добуток елементів після мінімального=";
            // 
            // dataGridViewMas
            // 
            this.dataGridViewMas.AllowUserToAddRows = false;
            this.dataGridViewMas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMas.Location = new System.Drawing.Point(111, 82);
            this.dataGridViewMas.Name = "dataGridViewMas";
            this.dataGridViewMas.Size = new System.Drawing.Size(567, 85);
            this.dataGridViewMas.TabIndex = 22;
            // 
            // buttonRandGen
            // 
            this.buttonRandGen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRandGen.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandGen.Location = new System.Drawing.Point(594, 10);
            this.buttonRandGen.Name = "buttonRandGen";
            this.buttonRandGen.Size = new System.Drawing.Size(96, 32);
            this.buttonRandGen.TabIndex = 21;
            this.buttonRandGen.Text = "Заповнити";
            this.buttonRandGen.UseVisualStyleBackColor = true;
            this.buttonRandGen.Visible = false;
            this.buttonRandGen.Click += new System.EventHandler(this.buttonRandGen_Click_1);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(483, 10);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(105, 32);
            this.buttonCreate.TabIndex = 20;
            this.buttonCreate.Text = "Створити";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click_1);
            // 
            // labelMas
            // 
            this.labelMas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMas.AutoSize = true;
            this.labelMas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMas.Location = new System.Drawing.Point(110, 15);
            this.labelMas.Name = "labelMas";
            this.labelMas.Size = new System.Drawing.Size(236, 25);
            this.labelMas.TabIndex = 19;
            this.labelMas.Text = "Кількіть елементів масиву=";
            // 
            // textBoxSizeM
            // 
            this.textBoxSizeM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSizeM.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSizeM.Location = new System.Drawing.Point(352, 11);
            this.textBoxSizeM.Name = "textBoxSizeM";
            this.textBoxSizeM.Size = new System.Drawing.Size(100, 32);
            this.textBoxSizeM.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxSumMaxNMinAbs);
            this.Controls.Add(this.textBoxSumFnL0);
            this.Controls.Add(this.textBoxSum1neg2pos);
            this.Controls.Add(this.textSumAfterMin);
            this.Controls.Add(this.labelSumMaxNMinAbs);
            this.Controls.Add(this.labelSumFnL0);
            this.Controls.Add(this.labelMax1neg2pos);
            this.Controls.Add(this.labelSumAfterMin);
            this.Controls.Add(this.dataGridViewMas);
            this.Controls.Add(this.buttonRandGen);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelMas);
            this.Controls.Add(this.textBoxSizeM);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textBoxSumMaxNMinAbs;
        private System.Windows.Forms.TextBox textBoxSumFnL0;
        private System.Windows.Forms.TextBox textBoxSum1neg2pos;
        private System.Windows.Forms.TextBox textSumAfterMin;
        private System.Windows.Forms.Label labelSumMaxNMinAbs;
        private System.Windows.Forms.Label labelSumFnL0;
        private System.Windows.Forms.Label labelMax1neg2pos;
        private System.Windows.Forms.Label labelSumAfterMin;
        private System.Windows.Forms.DataGridView dataGridViewMas;
        private System.Windows.Forms.Button buttonRandGen;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelMas;
        private System.Windows.Forms.TextBox textBoxSizeM;
    }
}

