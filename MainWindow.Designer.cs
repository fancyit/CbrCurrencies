namespace CBRCurrs
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.values_grid = new System.Windows.Forms.DataGridView();
            this.GetCurrencies = new System.Windows.Forms.Button();
            this.SaveTo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.values_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(175, 27);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(197, 34);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите дату: ";
            // 
            // values_grid
            // 
            this.values_grid.AllowUserToResizeRows = false;
            this.values_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.values_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.values_grid.ColumnHeadersHeight = 29;
            this.values_grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.values_grid.Location = new System.Drawing.Point(0, 165);
            this.values_grid.Name = "values_grid";
            this.values_grid.ReadOnly = true;
            this.values_grid.RowHeadersWidth = 51;
            this.values_grid.RowTemplate.Height = 24;
            this.values_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.values_grid.Size = new System.Drawing.Size(713, 388);
            this.values_grid.TabIndex = 2;
            // 
            // GetCurrencies
            // 
            this.GetCurrencies.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetCurrencies.Location = new System.Drawing.Point(378, 27);
            this.GetCurrencies.Name = "GetCurrencies";
            this.GetCurrencies.Size = new System.Drawing.Size(197, 34);
            this.GetCurrencies.TabIndex = 3;
            this.GetCurrencies.Text = "Получить курсы";
            this.GetCurrencies.UseVisualStyleBackColor = true;
            this.GetCurrencies.Click += new System.EventHandler(this.GetCurrencies_Click);
            // 
            // SaveTo
            // 
            this.SaveTo.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveTo.Location = new System.Drawing.Point(175, 66);
            this.SaveTo.Name = "SaveTo";
            this.SaveTo.Size = new System.Drawing.Size(197, 34);
            this.SaveTo.TabIndex = 5;
            this.SaveTo.Text = "Сохранить в файл";
            this.SaveTo.UseVisualStyleBackColor = true;
            this.SaveTo.Click += new System.EventHandler(this.SaveTo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дополнительно: ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(713, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveTo);
            this.Controls.Add(this.GetCurrencies);
            this.Controls.Add(this.values_grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Курс валют 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.values_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView values_grid;
        private System.Windows.Forms.Button GetCurrencies;
        private System.Windows.Forms.Button SaveTo;
        private System.Windows.Forms.Label label3;
    }
}

