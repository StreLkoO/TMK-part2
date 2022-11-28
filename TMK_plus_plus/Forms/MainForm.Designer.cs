namespace TMK_plus_plus
{
    partial class MainForm
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
            this.DataGridViewPipes = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsOk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnSteelGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRadius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonAddPipe = new System.Windows.Forms.Button();
            this.ButtonChangePipe = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxIsOkFilter = new System.Windows.Forms.ComboBox();
            this.ComboBoxSteelGradeFilter = new System.Windows.Forms.ComboBox();
            this.TextBoxNumberFilter = new System.Windows.Forms.TextBox();
            this.TextBoxRadiusFilter = new System.Windows.Forms.TextBox();
            this.TextBoxLenghtFilter = new System.Windows.Forms.TextBox();
            this.LabelFilter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxWeightFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPipes)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewPipes
            // 
            this.DataGridViewPipes.AllowUserToAddRows = false;
            this.DataGridViewPipes.AllowUserToDeleteRows = false;
            this.DataGridViewPipes.AllowUserToResizeRows = false;
            this.DataGridViewPipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnIsOk,
            this.ColumnSteelGrade,
            this.ColumnLenght,
            this.ColumnRadius,
            this.ColumnWeight});
            this.DataGridViewPipes.Location = new System.Drawing.Point(10, 10);
            this.DataGridViewPipes.MultiSelect = false;
            this.DataGridViewPipes.Name = "DataGridViewPipes";
            this.DataGridViewPipes.ReadOnly = true;
            this.DataGridViewPipes.RowHeadersVisible = false;
            this.DataGridViewPipes.RowHeadersWidth = 51;
            this.DataGridViewPipes.RowTemplate.Height = 25;
            this.DataGridViewPipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPipes.Size = new System.Drawing.Size(736, 304);
            this.DataGridViewPipes.TabIndex = 0;
            this.DataGridViewPipes.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridViewPipes_RowPrePaint);
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnNumber.HeaderText = "Номер трубы";
            this.ColumnNumber.MinimumWidth = 6;
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 107;
            // 
            // ColumnIsOk
            // 
            this.ColumnIsOk.HeaderText = "Можно исп";
            this.ColumnIsOk.MinimumWidth = 6;
            this.ColumnIsOk.Name = "ColumnIsOk";
            this.ColumnIsOk.ReadOnly = true;
            this.ColumnIsOk.Width = 125;
            // 
            // ColumnSteelGrade
            // 
            this.ColumnSteelGrade.HeaderText = "Марка стали";
            this.ColumnSteelGrade.MinimumWidth = 6;
            this.ColumnSteelGrade.Name = "ColumnSteelGrade";
            this.ColumnSteelGrade.ReadOnly = true;
            this.ColumnSteelGrade.Width = 125;
            // 
            // ColumnLenght
            // 
            this.ColumnLenght.HeaderText = "Длина";
            this.ColumnLenght.MinimumWidth = 6;
            this.ColumnLenght.Name = "ColumnLenght";
            this.ColumnLenght.ReadOnly = true;
            this.ColumnLenght.Width = 125;
            // 
            // ColumnRadius
            // 
            this.ColumnRadius.HeaderText = "Радиус";
            this.ColumnRadius.MinimumWidth = 6;
            this.ColumnRadius.Name = "ColumnRadius";
            this.ColumnRadius.ReadOnly = true;
            this.ColumnRadius.Width = 125;
            // 
            // ColumnWeight
            // 
            this.ColumnWeight.HeaderText = "Вес";
            this.ColumnWeight.MinimumWidth = 6;
            this.ColumnWeight.Name = "ColumnWeight";
            this.ColumnWeight.ReadOnly = true;
            this.ColumnWeight.Width = 125;
            // 
            // ButtonAddPipe
            // 
            this.ButtonAddPipe.Location = new System.Drawing.Point(11, 343);
            this.ButtonAddPipe.Name = "ButtonAddPipe";
            this.ButtonAddPipe.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddPipe.TabIndex = 1;
            this.ButtonAddPipe.Text = "Добавить";
            this.ButtonAddPipe.UseVisualStyleBackColor = true;
            this.ButtonAddPipe.Click += new System.EventHandler(this.ButtonAddPipe_Click);
            // 
            // ButtonChangePipe
            // 
            this.ButtonChangePipe.Location = new System.Drawing.Point(121, 343);
            this.ButtonChangePipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonChangePipe.Name = "ButtonChangePipe";
            this.ButtonChangePipe.Size = new System.Drawing.Size(82, 22);
            this.ButtonChangePipe.TabIndex = 2;
            this.ButtonChangePipe.Text = "Изменить";
            this.ButtonChangePipe.UseVisualStyleBackColor = true;
            this.ButtonChangePipe.Click += new System.EventHandler(this.ButtonChangePipe_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(246, 343);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Всего";
            // 
            // ComboBoxIsOkFilter
            // 
            this.ComboBoxIsOkFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxIsOkFilter.FormattingEnabled = true;
            this.ComboBoxIsOkFilter.Items.AddRange(new object[] {
            "Нет",
            "Да"});
            this.ComboBoxIsOkFilter.Location = new System.Drawing.Point(851, 61);
            this.ComboBoxIsOkFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxIsOkFilter.Name = "ComboBoxIsOkFilter";
            this.ComboBoxIsOkFilter.Size = new System.Drawing.Size(100, 23);
            this.ComboBoxIsOkFilter.TabIndex = 5;
            // 
            // ComboBoxSteelGradeFilter
            // 
            this.ComboBoxSteelGradeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSteelGradeFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxSteelGradeFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxSteelGradeFilter.FormattingEnabled = true;
            this.ComboBoxSteelGradeFilter.Location = new System.Drawing.Point(851, 86);
            this.ComboBoxSteelGradeFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxSteelGradeFilter.Name = "ComboBoxSteelGradeFilter";
            this.ComboBoxSteelGradeFilter.Size = new System.Drawing.Size(100, 23);
            this.ComboBoxSteelGradeFilter.TabIndex = 6;
            // 
            // TextBoxNumberFilter
            // 
            this.TextBoxNumberFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNumberFilter.Location = new System.Drawing.Point(851, 36);
            this.TextBoxNumberFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxNumberFilter.Name = "TextBoxNumberFilter";
            this.TextBoxNumberFilter.Size = new System.Drawing.Size(100, 23);
            this.TextBoxNumberFilter.TabIndex = 7;
            // 
            // TextBoxRadiusFilter
            // 
            this.TextBoxRadiusFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxRadiusFilter.Location = new System.Drawing.Point(851, 136);
            this.TextBoxRadiusFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxRadiusFilter.Name = "TextBoxRadiusFilter";
            this.TextBoxRadiusFilter.Size = new System.Drawing.Size(100, 23);
            this.TextBoxRadiusFilter.TabIndex = 8;
            // 
            // TextBoxLenghtFilter
            // 
            this.TextBoxLenghtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLenghtFilter.Location = new System.Drawing.Point(851, 112);
            this.TextBoxLenghtFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxLenghtFilter.Name = "TextBoxLenghtFilter";
            this.TextBoxLenghtFilter.Size = new System.Drawing.Size(100, 23);
            this.TextBoxLenghtFilter.TabIndex = 9;
            // 
            // LabelFilter
            // 
            this.LabelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelFilter.Location = new System.Drawing.Point(752, 7);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(76, 25);
            this.LabelFilter.TabIndex = 10;
            this.LabelFilter.Text = "Фильтр";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(752, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Брак";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(752, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Марка стали";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(752, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Длина >";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(752, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Радиус >";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(752, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Вес <";
            // 
            // TextBoxWeightFilter
            // 
            this.TextBoxWeightFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxWeightFilter.Location = new System.Drawing.Point(851, 161);
            this.TextBoxWeightFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxWeightFilter.Name = "TextBoxWeightFilter";
            this.TextBoxWeightFilter.Size = new System.Drawing.Size(100, 23);
            this.TextBoxWeightFilter.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 464);
            this.Controls.Add(this.TextBoxWeightFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelFilter);
            this.Controls.Add(this.TextBoxLenghtFilter);
            this.Controls.Add(this.TextBoxRadiusFilter);
            this.Controls.Add(this.TextBoxNumberFilter);
            this.Controls.Add(this.ComboBoxSteelGradeFilter);
            this.Controls.Add(this.ComboBoxIsOkFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonChangePipe);
            this.Controls.Add(this.ButtonAddPipe);
            this.Controls.Add(this.DataGridViewPipes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "ТМК++";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataGridViewPipes;
        private Button ButtonAddPipe;
        private Button ButtonChangePipe;
        private Button ButtonDelete;
        private Label label1;
        private ComboBox ComboBoxIsOkFilter;
        private ComboBox ComboBoxSteelGradeFilter;
        private DataGridViewTextBoxColumn ColumnNumber;
        private DataGridViewCheckBoxColumn ColumnIsOk;
        private DataGridViewTextBoxColumn ColumnSteelGrade;
        private DataGridViewTextBoxColumn ColumnLenght;
        private DataGridViewTextBoxColumn ColumnRadius;
        private DataGridViewTextBoxColumn ColumnWeight;
        private TextBox TextBoxNumberFilter;
        private TextBox TextBoxRadiusFilter;
        private TextBox TextBoxLenghtFilter;
        private Label LabelFilter;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TextBoxWeightFilter;
    }
}