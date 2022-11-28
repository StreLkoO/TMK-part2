namespace TMK_plus_plus.Forms
{
    partial class EditPipeForm
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
            this.components = new System.ComponentModel.Container();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ComboBoxSteelGrade = new System.Windows.Forms.ComboBox();
            this.TextBoxRadius = new System.Windows.Forms.TextBox();
            this.TextBoxLenght = new System.Windows.Forms.TextBox();
            this.CheckBoxIsOk = new System.Windows.Forms.CheckBox();
            this.TextBoxWeight = new System.Windows.Forms.TextBox();
            this.LabelIsOk = new System.Windows.Forms.Label();
            this.LabelSteelGrade = new System.Windows.Forms.Label();
            this.LabelLenght = new System.Windows.Forms.Label();
            this.LabelRadius = new System.Windows.Forms.Label();
            this.LabelWeight = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TextBoxNumber = new System.Windows.Forms.TextBox();
            this.LabelNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(10, 186);
            this.ButtonOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(82, 22);
            this.ButtonOk.TabIndex = 5;
            this.ButtonOk.Text = "ОК";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(170, 186);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(82, 22);
            this.ButtonCancel.TabIndex = 6;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ComboBoxSteelGrade
            // 
            this.ComboBoxSteelGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxSteelGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxSteelGrade.FormattingEnabled = true;
            this.ComboBoxSteelGrade.Location = new System.Drawing.Point(155, 60);
            this.ComboBoxSteelGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxSteelGrade.Name = "ComboBoxSteelGrade";
            this.ComboBoxSteelGrade.Size = new System.Drawing.Size(98, 23);
            this.ComboBoxSteelGrade.TabIndex = 1;
            // 
            // TextBoxRadius
            // 
            this.TextBoxRadius.Location = new System.Drawing.Point(155, 110);
            this.TextBoxRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxRadius.Name = "TextBoxRadius";
            this.TextBoxRadius.Size = new System.Drawing.Size(97, 23);
            this.TextBoxRadius.TabIndex = 3;
            // 
            // TextBoxLenght
            // 
            this.TextBoxLenght.Location = new System.Drawing.Point(155, 86);
            this.TextBoxLenght.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxLenght.Name = "TextBoxLenght";
            this.TextBoxLenght.Size = new System.Drawing.Size(97, 23);
            this.TextBoxLenght.TabIndex = 2;
            // 
            // CheckBoxIsOk
            // 
            this.CheckBoxIsOk.AutoSize = true;
            this.CheckBoxIsOk.Location = new System.Drawing.Point(236, 40);
            this.CheckBoxIsOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxIsOk.Name = "CheckBoxIsOk";
            this.CheckBoxIsOk.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxIsOk.TabIndex = 0;
            this.CheckBoxIsOk.UseVisualStyleBackColor = true;
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Location = new System.Drawing.Point(155, 135);
            this.TextBoxWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.Size = new System.Drawing.Size(97, 23);
            this.TextBoxWeight.TabIndex = 4;
            // 
            // LabelIsOk
            // 
            this.LabelIsOk.AutoSize = true;
            this.LabelIsOk.Location = new System.Drawing.Point(22, 38);
            this.LabelIsOk.Name = "LabelIsOk";
            this.LabelIsOk.Size = new System.Drawing.Size(126, 15);
            this.LabelIsOk.TabIndex = 7;
            this.LabelIsOk.Text = "Можно использовать";
            // 
            // LabelSteelGrade
            // 
            this.LabelSteelGrade.AutoSize = true;
            this.LabelSteelGrade.Location = new System.Drawing.Point(22, 62);
            this.LabelSteelGrade.Name = "LabelSteelGrade";
            this.LabelSteelGrade.Size = new System.Drawing.Size(77, 15);
            this.LabelSteelGrade.TabIndex = 8;
            this.LabelSteelGrade.Text = "Марка стали";
            // 
            // LabelLenght
            // 
            this.LabelLenght.AutoSize = true;
            this.LabelLenght.Location = new System.Drawing.Point(22, 88);
            this.LabelLenght.Name = "LabelLenght";
            this.LabelLenght.Size = new System.Drawing.Size(70, 15);
            this.LabelLenght.TabIndex = 9;
            this.LabelLenght.Text = "Длинна, см";
            // 
            // LabelRadius
            // 
            this.LabelRadius.AutoSize = true;
            this.LabelRadius.Location = new System.Drawing.Point(22, 112);
            this.LabelRadius.Name = "LabelRadius";
            this.LabelRadius.Size = new System.Drawing.Size(66, 15);
            this.LabelRadius.TabIndex = 10;
            this.LabelRadius.Text = "Радиус, см";
            // 
            // LabelWeight
            // 
            this.LabelWeight.AutoSize = true;
            this.LabelWeight.Location = new System.Drawing.Point(22, 137);
            this.LabelWeight.Name = "LabelWeight";
            this.LabelWeight.Size = new System.Drawing.Size(43, 15);
            this.LabelWeight.TabIndex = 11;
            this.LabelWeight.Text = "Вес, кг";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // TextBoxNumber
            // 
            this.TextBoxNumber.Enabled = false;
            this.TextBoxNumber.Location = new System.Drawing.Point(155, 15);
            this.TextBoxNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxNumber.Name = "TextBoxNumber";
            this.TextBoxNumber.Size = new System.Drawing.Size(97, 23);
            this.TextBoxNumber.TabIndex = 12;
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(22, 17);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(45, 15);
            this.LabelNumber.TabIndex = 13;
            this.LabelNumber.Text = "Номер";
            // 
            // EditPipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 217);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.TextBoxNumber);
            this.Controls.Add(this.LabelWeight);
            this.Controls.Add(this.LabelRadius);
            this.Controls.Add(this.LabelLenght);
            this.Controls.Add(this.LabelSteelGrade);
            this.Controls.Add(this.LabelIsOk);
            this.Controls.Add(this.TextBoxWeight);
            this.Controls.Add(this.CheckBoxIsOk);
            this.Controls.Add(this.TextBoxLenght);
            this.Controls.Add(this.TextBoxRadius);
            this.Controls.Add(this.ComboBoxSteelGrade);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditPipeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditPipeForm";
            this.Load += new System.EventHandler(this.EditPipeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonOk;
        private Button ButtonCancel;
        private ComboBox ComboBoxSteelGrade;
        private TextBox TextBoxRadius;
        private TextBox TextBoxLenght;
        private CheckBox CheckBoxIsOk;
        private TextBox TextBoxWeight;
        private Label LabelIsOk;
        private Label LabelSteelGrade;
        private Label LabelLenght;
        private Label LabelRadius;
        private Label LabelWeight;
        private ErrorProvider errorProvider1;
        private Label LabelNumber;
        private TextBox TextBoxNumber;
    }
}