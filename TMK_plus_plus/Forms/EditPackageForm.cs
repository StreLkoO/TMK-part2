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
    public partial class EditPackageForm : Form
    {
        private BindingSource bsPackage = new();
        public EditPackageForm()
        {
            InitializeComponent();
            SetBindings();
        }
        public PipePackage CurrentPackage
        {
            get => (PipePackage)bsPackage.Current;
            set => bsPackage.Add(value);
        }

        private void SetBindings()
        {
            TextBoxNumber.DataBindings.Add("Text", bsPackage, nameof(PipePackage.Number),
                true, DataSourceUpdateMode.OnPropertyChanged);
            DateTimePicker.DataBindings.Add("Text", bsPackage, nameof(PipePackage.DateCreate),
                true, DataSourceUpdateMode.OnPropertyChanged);

            errorProvider1.DataSource = bsPackage;

            bsPackage.CurrentItemChanged += bsPackageCurrentItemChanged;
        }

        private void bsPackageCurrentItemChanged(object sender, EventArgs e)
        {
            string error = String.Empty;
            foreach (var prop in CurrentPackage.GetType().GetProperties())
            {
                error += CurrentPackage[prop.Name];
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
    }
}
