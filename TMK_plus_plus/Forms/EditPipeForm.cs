using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMK_plus_plus.Classes;

namespace TMK_plus_plus.Forms
{
    public partial class EditPipeForm : Form
    {
        private BindingSource bsPipe = new();


        public EditPipeForm()
        {
            InitializeComponent();
            SetBindings();
        }

        public Pipe CurrentPipe
        {
            get => (Pipe)bsPipe.Current;
            set => bsPipe.Add(value);
        }

        private void SetBindings()
        {
            TextBoxNumber.DataBindings.Add("Text", bsPipe, nameof(Pipe.Number),
                true, DataSourceUpdateMode.OnPropertyChanged);
            CheckBoxIsOk.DataBindings.Add("Checked", bsPipe, nameof(Pipe.IsOk),
                true, DataSourceUpdateMode.OnPropertyChanged);
            ComboBoxSteelGrade.DataBindings.Add("Text", bsPipe, nameof(Pipe.SteelGrade),
                true, DataSourceUpdateMode.OnPropertyChanged);
            TextBoxLenght.DataBindings.Add("Text", bsPipe, nameof(Pipe.Lenght),
                true, DataSourceUpdateMode.OnPropertyChanged);
            TextBoxRadius.DataBindings.Add("Text", bsPipe, nameof(Pipe.Radius),
                true, DataSourceUpdateMode.OnPropertyChanged);
            TextBoxWeight.DataBindings.Add("Text", bsPipe, nameof(Pipe.Weight),
                true, DataSourceUpdateMode.OnPropertyChanged);

            errorProvider1.DataSource = bsPipe;

            bsPipe.CurrentItemChanged += bsPipe_CurrentItemChanged;

        }

        private void bsPipe_CurrentItemChanged(object? sender, EventArgs e)
        {
            string error = String.Empty;
            foreach (var prop in CurrentPipe.GetType().GetProperties())
            {
                error += CurrentPipe[prop.Name];
            }
            ButtonOk.Enabled = String.IsNullOrEmpty(error);
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void EditPipeForm_Load(object sender, EventArgs e)
        {
            ComboBoxSteelGrade.DataSource = Program.SteelGrades;
        }
    }
}
