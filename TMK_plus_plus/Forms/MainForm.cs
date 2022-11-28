
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
        private BindingSource bsPackage = new();
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
                row["Package"] = pipe.Package;

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
            dt.Columns.Add("Package", typeof(PipePackage));

            DataGridViewPipes.AutoGenerateColumns = false;
            DataGridViewPipes.DataSource = bs;

            ColumnNumber.DataPropertyName = nameof(Pipe.Number);
            ColumnIsOk.DataPropertyName = nameof(Pipe.IsOk);
            ColumnSteelGrade.DataPropertyName = nameof(Pipe.SteelGrade);
            ColumnLenght.DataPropertyName = nameof(Pipe.Lenght);
            ColumnRadius.DataPropertyName = nameof(Pipe.Radius);
            ColumnWeight.DataPropertyName = nameof(Pipe.Weight);
            ColumnPipePackage.DataPropertyName = nameof(Pipe.Package);

            DataGridViewPackage.AutoGenerateColumns = false;
            DataGridViewPackage.DataSource = bsPackage;

            ColumnPackageNumber.DataPropertyName = nameof(PipePackage.Number);
            ColumnDate.DataPropertyName = nameof(PipePackage.DateCreate);

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
            Pipe p = new Pipe(dt.Rows[DataGridViewPipes.SelectedRows[0].Index].ItemArray!);
            if (p.Package == null)
            {
                using var editPipeForm = new EditPipeForm();
                editPipeForm.Owner = this;
                editPipeForm.Text = "Изменение трубы";
                editPipeForm.CurrentPipe = p;
                if (editPipeForm.ShowDialog() == DialogResult.OK)
                {
                    await Program.PipeReader.UpdatePipe(editPipeForm.CurrentPipe);
                    RefreshDataGrid();
                }
            }
            else { MessageBox.Show("Нельзя удалить трубу, находящуюся в пакете!"); }
        }

        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            Pipe p = new Pipe(dt.Rows[DataGridViewPipes.SelectedRows[0].Index].ItemArray!);
            if (p.Package == null)
            {
                await Program.PipeReader.DeletePipe(p);
                RefreshDataGrid();
            }
            else { MessageBox.Show("Нельзя удалить трубу, находящуюся в пакете!"); }

        }

        private void DataGridViewPipes_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((bool)DataGridViewPipes.Rows[e.RowIndex].Cells[1].Value == false)
            {
                DataGridViewPipes.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                DataGridViewPipes.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.LightPink;//Color.PaleVioletRed;
            }
        }

        private async void RefreshDataGrid()
        {
            bsPackage.Clear();
            var packages = await Program.PackageReader.GetPackages();
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
            packages.ForEach(p => bsPackage.Add(p));
            label1.Text = "Всего " + bs.Count + ", из них " + countIsOk +
                " без брака. Общий вес: " + totalWeight + " кг.";
        }

        private void _filterDgv_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            var filters = new List<string>();
            if (filterDgv.Number > 0)
                filters.Add($"{nameof(Pipe.Number)} = {filterDgv.Number}");

            if (!String.IsNullOrEmpty(filterDgv.IsOk))
            {
                if (filterDgv.IsOk == "Нет")
                    filters.Add($"{nameof(Pipe.IsOk)} = False");
                else
                    filters.Add($"{nameof(Pipe.IsOk)} = True");
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

        private async void ButtonAddPackage_Click(object sender, EventArgs e)
        {
            using var editPackageForm = new EditPackageForm();
            editPackageForm.Owner = this;
            editPackageForm.Text = "Добавление нового пакета";
            editPackageForm.CurrentPackage = new PipePackage();
            if (editPackageForm.ShowDialog() == DialogResult.OK)
            {
                await Program.PackageReader.AddPackage(editPackageForm.CurrentPackage);
                RefreshDataGrid();
            }
        }

        private async void ButtonChangePackage_Click(object sender, EventArgs e)
        {
            using var editPackageForm = new EditPackageForm();
            editPackageForm.Owner = this;
            editPackageForm.Text = "Изменение трубы";
            PipePackage? p = ((PipePackage)DataGridViewPackage.SelectedRows[0].DataBoundItem).Clone() as PipePackage;
            editPackageForm.CurrentPackage = p!;
            if (editPackageForm.ShowDialog() == DialogResult.OK)
            {
                await Program.PackageReader.UpdatePackage(editPackageForm.CurrentPackage!);
                RefreshDataGrid();
            }
        }


        private async void ButtonDeletePackage_Click(object sender, EventArgs e)
        {

            await Program.PackageReader.DeletePackage((PipePackage)DataGridViewPackage.SelectedRows[0].DataBoundItem);
            RefreshDataGrid();
        }

        private void DataGridViewPackage_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewPackage.SelectedRows.Count > 0)
                foreach (DataGridViewRow row in DataGridViewPipes.Rows)
                {
                    object o = dt.Rows[row.Index].ItemArray[6];
                    if (o != DBNull.Value && o != null)
                        if (((PipePackage)o).Equals(DataGridViewPackage.SelectedRows[0].DataBoundItem))
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.SelectionBackColor = Color.Empty;
                        }
                }
        }

        private async void ButtonAddToPackage_Click(object sender, EventArgs e)
        {
            Pipe p = new Pipe(dt.Rows[DataGridViewPipes.SelectedRows[0].Index].ItemArray!);
            if (p.Package != null)
                MessageBox.Show("Данная труба уже добавлена в пакет " + p.Package.Number);
            else
            {
                PipePackage pp = (PipePackage)DataGridViewPackage.SelectedRows[0].DataBoundItem;
                p.Package = pp;
                await Program.PipeReader.UpdatePipe(p);
                RefreshDataGrid();
            }

        }

        private async void ButtonDeleteFromPackage_Click(object sender, EventArgs e)
        {
            Pipe p = new Pipe(dt.Rows[DataGridViewPipes.SelectedRows[0].Index].ItemArray!);
            if (p.Package != null)
            {
                p.Package = null;
                await Program.PipeReader.UpdatePipe(p);
                RefreshDataGrid();
            }
            else { MessageBox.Show("Данная труба не добавлена в пакет!"); }
        }
    }
}