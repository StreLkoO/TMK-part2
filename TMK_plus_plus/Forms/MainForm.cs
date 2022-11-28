
using System;
using System.ComponentModel;
using System.Data;
using TMK_plus_plus.Classes;
using TMK_plus_plus.Forms;
using WindowsFormsApp1.Models;

namespace TMK_plus_plus
{
    public partial class MainForm : Form
    {
        private DataTable dt = new DataTable();
        private BindingSource bs = new();
        private readonly FilterDgv filterDgv = new FilterDgv();

        public MainForm()
        {
            InitializeComponent();
            SetBind();
        }
        private void PipeListToDataTable(List<Pipe> pipes)
        {
            dt.Clear();
            foreach (var pipe in pipes)
            {
                var row = dt.NewRow();
                row["Number"] = pipe.Number;
                row["IsOk"] = pipe.IsOk;
                row["SteelGrade"] = pipe.SteelGrade;
                row["Lenght"] = pipe.Lenght;
                row["Radius"] = pipe.Radius;
                row["Weight"] = pipe.Weight;

                dt.Rows.Add(row);
            }
        }

        private void SetBind()
        {

            dt.Columns.Add("Number", typeof(int));
            dt.Columns.Add("IsOk", typeof(bool));
            dt.Columns.Add("SteelGrade", typeof(string));
            dt.Columns.Add("Lenght", typeof(int));
            dt.Columns.Add("Radius", typeof(int));
            dt.Columns.Add("Weight", typeof(int));

            //bs.DataSource = typeof(Pipe);
            DataGridViewPipes.AutoGenerateColumns = false;
            DataGridViewPipes.DataSource = bs;

            ColumnNumber.DataPropertyName = nameof(Pipe.Number);
            ColumnIsOk.DataPropertyName = nameof(Pipe.IsOk);
            ColumnSteelGrade.DataPropertyName = nameof(Pipe.SteelGrade);
            ColumnLenght.DataPropertyName = nameof(Pipe.Lenght);
            ColumnRadius.DataPropertyName = nameof(Pipe.Radius);
            ColumnWeight.DataPropertyName = nameof(Pipe.Weight);

            var bNumber = new Binding("Text", filterDgv, nameof(FilterDgv.Number));
            bNumber.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            TextBoxNumberFilter.DataBindings.Add(bNumber);

            var bIsOk = new Binding("Text", filterDgv, nameof(FilterDgv.IsOk));
            bIsOk.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            ComboBoxIsOkFilter.DataBindings.Add(bIsOk);

            var bSG = new Binding("Text", filterDgv, nameof(FilterDgv.SteelGrade));
            bSG.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            ComboBoxSteelGradeFilter.DataBindings.Add(bSG);


            var bLenght = new Binding("Text", filterDgv, nameof(FilterDgv.Lenght));
            bLenght.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            TextBoxLenghtFilter.DataBindings.Add(bLenght);

            var bRadius = new Binding("Text", filterDgv, nameof(FilterDgv.Radius));
            bRadius.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            TextBoxRadiusFilter.DataBindings.Add(bRadius);

            var bWeight = new Binding("Text", filterDgv, nameof(FilterDgv.Weight));
            bWeight.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            TextBoxWeightFilter.DataBindings.Add(bWeight);

            ComboBoxSteelGradeFilter.DataSource = Program.SteelGrades;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
            filterDgv.PropertyChanged += _filterDgv_PropertyChanged;
        }

        private async void ButtonAddPipe_Click(object sender, EventArgs e)
        {
            using var editPipeForm = new EditPipeForm();
            editPipeForm.Owner = this;
            editPipeForm.Text = "Добавление новой трубы";
            editPipeForm.CurrentPipe = new Pipe();
            if (editPipeForm.ShowDialog() == DialogResult.OK)
            {
                await Program.PipeReader.AddPipe(editPipeForm.CurrentPipe);
                RefreshDataGrid();
            }

        }

        private async void ButtonChangePipe_Click(object sender, EventArgs e)
        {
            using var editPipeForm = new EditPipeForm();
            editPipeForm.Owner = this;
            editPipeForm.Text = "Изменение трубы";
            Pipe p = new Pipe(dt.Rows[DataGridViewPipes.SelectedRows[0].Index].ItemArray!);
            editPipeForm.CurrentPipe = p;
            if (editPipeForm.ShowDialog() == DialogResult.OK)
            {
                await Program.PipeReader.UpdatePipe(editPipeForm.CurrentPipe);
                RefreshDataGrid();
            }

        }

        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            Pipe p = new Pipe(dt.Rows[DataGridViewPipes.SelectedRows[0].Index].ItemArray!);
            await Program.PipeReader.DeletePipe(p);
            RefreshDataGrid();
        }

        private void DataGridViewPipes_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((bool)DataGridViewPipes.Rows[e.RowIndex].Cells[1].Value == false)
            {
                DataGridViewPipes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private async void RefreshDataGrid()
        {
            var pipes = await Program.PipeReader.GetPipes();
            int countIsOk = 0;
            int totalWeight = 0;
            PipeListToDataTable(pipes);
            foreach (Pipe p in pipes)
            {
                countIsOk += p.IsOk ? 1 : 0;
                totalWeight += p.Weight;
            }
            bs.DataSource = dt;

            label1.Text = "Всего " + bs.Count + ", из них " + countIsOk +
                " без брака. Общий вес: " + totalWeight + " кг.";
        }

        private void _filterDgv_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            var filters = new List<string>();
            bs.RemoveFilter();
            if (filterDgv.Number > 0)
                filters.Add($"{nameof(Pipe.Number)} = {filterDgv.Number}");

            if (!String.IsNullOrEmpty(filterDgv.IsOk))
            {
                if (filterDgv.IsOk == "Нет")
                    filters.Add($"{nameof(Pipe.IsOk)} = True");
                else
                    filters.Add($"{nameof(Pipe.IsOk)} = False");
            }


            if (!String.IsNullOrEmpty(filterDgv.SteelGrade))
                filters.Add($"{nameof(Pipe.SteelGrade)} LIKE '%{filterDgv.SteelGrade}%'");

            if (filterDgv.Lenght > 0)
                filters.Add($"{nameof(Pipe.Lenght)} > {filterDgv.Lenght}");

            if (filterDgv.Radius > 0)
                filters.Add($"{nameof(Pipe.Radius)} > {filterDgv.Radius}");

            if (filterDgv.Weight > 0)
                filters.Add($"{nameof(Pipe.Weight)} < {filterDgv.Weight}");


            bs.RemoveFilter();


            if (filters.Count == 1)
            {
                bs.Filter = filters.First();
            }
            else if (filters.Count > 1)
            {
                bs.Filter = String.Join(" AND ", filters);
            }
            DataGridViewPipes.Refresh();

        }



    }
}