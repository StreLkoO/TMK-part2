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
            this.ColumnPipePackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonAddPipe = new System.Windows.Forms.Button();
            this.ButtonChangePipe = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxIsOkFilter = new System.Windows.Forms.ComboBox();
            this.ComboBoxSteelGradeFilter = new System.Windows.Forms.ComboBox();
            this.TextBoxNumberFilter = new System.Windows.Forms.TextBox();
            this.TextBoxRadiusFilter = new System.Windows.Forms.TextBox();
            this.TextBoxLenghtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxWeightFilter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ButtonDeletePackage = new System.Windows.Forms.Button();
            this.ButtonChangePackage = new System.Windows.Forms.Button();
            this.ButtonAddPackage = new System.Windows.Forms.Button();
            this.DataGridViewPackage = new System.Windows.Forms.DataGridView();
            this.ColumnPackageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonAddToPackage = new System.Windows.Forms.Button();
            this.ButtonDeleteFromPackage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPipes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPackage)).BeginInit();
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
            this.ColumnWeight,
            this.ColumnPipePackage});
            this.DataGridViewPipes.Location = new System.Drawing.Point(6, 17);
            this.DataGridViewPipes.MultiSelect = false;
            this.DataGridViewPipes.Name = "DataGridViewPipes";
            this.DataGridViewPipes.ReadOnly = true;
            this.DataGridViewPipes.RowHeadersVisible = false;
            this.DataGridViewPipes.RowHeadersWidth = 51;
            this.DataGridViewPipes.RowTemplate.Height = 25;
            this.DataGridViewPipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPipes.Size = new System.Drawing.Size(736, 304);
            this.DataGridViewPipes.TabIndex = 0;
            this.DataGridViewPipes.TabStop = false;
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
            // ColumnPipePackage
            // 
            this.ColumnPipePackage.HeaderText = "Пакет";
            this.ColumnPipePackage.Name = "ColumnPipePackage";
            this.ColumnPipePackage.ReadOnly = true;
            this.ColumnPipePackage.Visible = false;
            // 
            // ButtonAddPipe
            // 
            this.ButtonAddPipe.Location = new System.Drawing.Point(6, 342);
            this.ButtonAddPipe.Name = "ButtonAddPipe";
            this.ButtonAddPipe.Size = new System.Drawing.Size(157, 34);
            this.ButtonAddPipe.TabIndex = 0;
            this.ButtonAddPipe.Text = "Добавить новую трубу";
            this.ButtonAddPipe.UseVisualStyleBackColor = true;
            this.ButtonAddPipe.Click += new System.EventHandler(this.ButtonAddPipe_Click);
            // 
            // ButtonChangePipe
            // 
            this.ButtonChangePipe.Location = new System.Drawing.Point(195, 342);
            this.ButtonChangePipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonChangePipe.Name = "ButtonChangePipe";
            this.ButtonChangePipe.Size = new System.Drawing.Size(157, 34);
            this.ButtonChangePipe.TabIndex = 1;
            this.ButtonChangePipe.Text = "Изменить выбранную";
            this.ButtonChangePipe.UseVisualStyleBackColor = true;
            this.ButtonChangePipe.Click += new System.EventHandler(this.ButtonChangePipe_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(383, 342);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(157, 34);
            this.ButtonDelete.TabIndex = 2;
            this.ButtonDelete.Text = "Удалить выбранную";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 324);
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
            this.ComboBoxIsOkFilter.Location = new System.Drawing.Point(116, 51);
            this.ComboBoxIsOkFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxIsOkFilter.Name = "ComboBoxIsOkFilter";
            this.ComboBoxIsOkFilter.Size = new System.Drawing.Size(79, 23);
            this.ComboBoxIsOkFilter.TabIndex = 4;
            // 
            // ComboBoxSteelGradeFilter
            // 
            this.ComboBoxSteelGradeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSteelGradeFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxSteelGradeFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxSteelGradeFilter.FormattingEnabled = true;
            this.ComboBoxSteelGradeFilter.Location = new System.Drawing.Point(251, 51);
            this.ComboBoxSteelGradeFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxSteelGradeFilter.Name = "ComboBoxSteelGradeFilter";
            this.ComboBoxSteelGradeFilter.Size = new System.Drawing.Size(79, 23);
            this.ComboBoxSteelGradeFilter.TabIndex = 5;
            // 
            // TextBoxNumberFilter
            // 
            this.TextBoxNumberFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNumberFilter.Location = new System.Drawing.Point(6, 51);
            this.TextBoxNumberFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxNumberFilter.Name = "TextBoxNumberFilter";
            this.TextBoxNumberFilter.Size = new System.Drawing.Size(79, 23);
            this.TextBoxNumberFilter.TabIndex = 3;
            // 
            // TextBoxRadiusFilter
            // 
            this.TextBoxRadiusFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxRadiusFilter.Location = new System.Drawing.Point(501, 51);
            this.TextBoxRadiusFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxRadiusFilter.Name = "TextBoxRadiusFilter";
            this.TextBoxRadiusFilter.Size = new System.Drawing.Size(79, 23);
            this.TextBoxRadiusFilter.TabIndex = 7;
            // 
            // TextBoxLenghtFilter
            // 
            this.TextBoxLenghtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLenghtFilter.Location = new System.Drawing.Point(377, 51);
            this.TextBoxLenghtFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxLenghtFilter.Name = "TextBoxLenghtFilter";
            this.TextBoxLenghtFilter.Size = new System.Drawing.Size(79, 23);
            this.TextBoxLenghtFilter.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Можно использовать";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Марка стали";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Длина >";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Радиус >";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(641, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Вес <";
            // 
            // TextBoxWeightFilter
            // 
            this.TextBoxWeightFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxWeightFilter.Location = new System.Drawing.Point(620, 51);
            this.TextBoxWeightFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxWeightFilter.Name = "TextBoxWeightFilter";
            this.TextBoxWeightFilter.Size = new System.Drawing.Size(79, 23);
            this.TextBoxWeightFilter.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBoxWeightFilter);
            this.groupBox1.Controls.Add(this.ComboBoxIsOkFilter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ComboBoxSteelGradeFilter);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TextBoxNumberFilter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextBoxRadiusFilter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextBoxLenghtFilter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 93);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridViewPipes);
            this.groupBox2.Controls.Add(this.ButtonChangePipe);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ButtonAddPipe);
            this.groupBox2.Controls.Add(this.ButtonDelete);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 481);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Трубы";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ButtonDeletePackage);
            this.groupBox3.Controls.Add(this.ButtonChangePackage);
            this.groupBox3.Controls.Add(this.ButtonAddPackage);
            this.groupBox3.Controls.Add(this.DataGridViewPackage);
            this.groupBox3.Location = new System.Drawing.Point(874, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 475);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пакеты";
            // 
            // ButtonDeletePackage
            // 
            this.ButtonDeletePackage.Location = new System.Drawing.Point(20, 426);
            this.ButtonDeletePackage.Name = "ButtonDeletePackage";
            this.ButtonDeletePackage.Size = new System.Drawing.Size(157, 34);
            this.ButtonDeletePackage.TabIndex = 3;
            this.ButtonDeletePackage.Text = "Удалить выбранный";
            this.ButtonDeletePackage.UseVisualStyleBackColor = true;
            this.ButtonDeletePackage.Click += new System.EventHandler(this.ButtonDeletePackage_Click);
            // 
            // ButtonChangePackage
            // 
            this.ButtonChangePackage.Location = new System.Drawing.Point(20, 382);
            this.ButtonChangePackage.Name = "ButtonChangePackage";
            this.ButtonChangePackage.Size = new System.Drawing.Size(157, 34);
            this.ButtonChangePackage.TabIndex = 2;
            this.ButtonChangePackage.Text = "Изменить выбранный";
            this.ButtonChangePackage.UseVisualStyleBackColor = true;
            this.ButtonChangePackage.Click += new System.EventHandler(this.ButtonChangePackage_Click);
            // 
            // ButtonAddPackage
            // 
            this.ButtonAddPackage.Location = new System.Drawing.Point(20, 342);
            this.ButtonAddPackage.Name = "ButtonAddPackage";
            this.ButtonAddPackage.Size = new System.Drawing.Size(157, 34);
            this.ButtonAddPackage.TabIndex = 1;
            this.ButtonAddPackage.Text = "Добавить новый пакет";
            this.ButtonAddPackage.UseVisualStyleBackColor = true;
            this.ButtonAddPackage.Click += new System.EventHandler(this.ButtonAddPackage_Click);
            // 
            // DataGridViewPackage
            // 
            this.DataGridViewPackage.AllowUserToAddRows = false;
            this.DataGridViewPackage.AllowUserToDeleteRows = false;
            this.DataGridViewPackage.AllowUserToResizeColumns = false;
            this.DataGridViewPackage.AllowUserToResizeRows = false;
            this.DataGridViewPackage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridViewPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewPackage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPackageNumber,
            this.ColumnDate});
            this.DataGridViewPackage.Location = new System.Drawing.Point(6, 17);
            this.DataGridViewPackage.Name = "DataGridViewPackage";
            this.DataGridViewPackage.ReadOnly = true;
            this.DataGridViewPackage.RowHeadersVisible = false;
            this.DataGridViewPackage.RowTemplate.Height = 25;
            this.DataGridViewPackage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPackage.Size = new System.Drawing.Size(183, 304);
            this.DataGridViewPackage.TabIndex = 0;
            this.DataGridViewPackage.SelectionChanged += new System.EventHandler(this.DataGridViewPackage_SelectionChanged);
            // 
            // ColumnPackageNumber
            // 
            this.ColumnPackageNumber.HeaderText = "Номер";
            this.ColumnPackageNumber.Name = "ColumnPackageNumber";
            this.ColumnPackageNumber.ReadOnly = true;
            this.ColumnPackageNumber.Width = 70;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата создания";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 110;
            // 
            // ButtonAddToPackage
            // 
            this.ButtonAddToPackage.Location = new System.Drawing.Point(769, 110);
            this.ButtonAddToPackage.Name = "ButtonAddToPackage";
            this.ButtonAddToPackage.Size = new System.Drawing.Size(99, 44);
            this.ButtonAddToPackage.TabIndex = 20;
            this.ButtonAddToPackage.Text = "Добавить трубу в пакет";
            this.ButtonAddToPackage.UseVisualStyleBackColor = true;
            this.ButtonAddToPackage.Click += new System.EventHandler(this.ButtonAddToPackage_Click);
            // 
            // ButtonDeleteFromPackage
            // 
            this.ButtonDeleteFromPackage.Location = new System.Drawing.Point(769, 174);
            this.ButtonDeleteFromPackage.Name = "ButtonDeleteFromPackage";
            this.ButtonDeleteFromPackage.Size = new System.Drawing.Size(99, 44);
            this.ButtonDeleteFromPackage.TabIndex = 21;
            this.ButtonDeleteFromPackage.Text = "Удалить трубу из пакета";
            this.ButtonDeleteFromPackage.UseVisualStyleBackColor = true;
            this.ButtonDeleteFromPackage.Click += new System.EventHandler(this.ButtonDeleteFromPackage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 501);
            this.Controls.Add(this.ButtonDeleteFromPackage);
            this.Controls.Add(this.ButtonAddToPackage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "ТМК++";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPipes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPackage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DataGridViewPipes;
        private Button ButtonAddPipe;
        private Button ButtonChangePipe;
        private Button ButtonDelete;
        private Label label1;
        private ComboBox ComboBoxIsOkFilter;
        private ComboBox ComboBoxSteelGradeFilter;
        private TextBox TextBoxNumberFilter;
        private TextBox TextBoxRadiusFilter;
        private TextBox TextBoxLenghtFilter;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TextBoxWeightFilter;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView DataGridViewPackage;
        private Button ButtonChangePackage;
        private Button ButtonAddPackage;
        private Button ButtonDeletePackage;
        private DataGridViewTextBoxColumn ColumnPackageNumber;
        private DataGridViewTextBoxColumn ColumnDate;
        private Button ButtonAddToPackage;
        private Button ButtonDeleteFromPackage;
        private DataGridViewTextBoxColumn ColumnNumber;
        private DataGridViewCheckBoxColumn ColumnIsOk;
        private DataGridViewTextBoxColumn ColumnSteelGrade;
        private DataGridViewTextBoxColumn ColumnLenght;
        private DataGridViewTextBoxColumn ColumnRadius;
        private DataGridViewTextBoxColumn ColumnWeight;
        private DataGridViewTextBoxColumn ColumnPipePackage;
    }
}