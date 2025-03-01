namespace Booking.UI
{
    public partial class FormCar : Form
    {
        private List<Car> _car;

        public FormCar()
        {
            InitializeComponent();
        }

        public async Task UpdateDateAsync()
        {
            var api = new ApiClient<List<Car>>(new Uri("http://localhost:5000/api/booking-car"));

            _car = await api.GetAsync("booking/car");
            guna2DataGridView1.DataSource = _car;
        }

        private async void FormAdmin_Load(object sender, EventArgs e)
        {
            await UpdateDateAsync();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            if (!IsSelecedRow())
            {
                return;
            }

            var selectedRow = guna2DataGridView1.SelectedRows[0];
            Car car = new()
            {
                CarId = (int)selectedRow.Cells[0].Value,
                Brand = selectedRow.Cells[1].Value.ToString(),
                Mark = selectedRow.Cells[2].Value.ToString(),
                YearStart = (int)selectedRow.Cells[3].Value,
                Color = selectedRow.Cells[4].Value.ToString(),
                CarNumber = selectedRow.Cells[5].Value.ToString(),
                VIN = selectedRow.Cells[6].Value.ToString(),
                Active = (bool)selectedRow.Cells[7].Value,
                MinimalExperience = (int)selectedRow.Cells[8].Value,
                Class = (int)selectedRow.Cells[9].Value,
                ClassTxt = ""
            };

            FormEditCar edit = new(2, car, this);
            edit.ShowDialog();
        }

        private bool IsSelecedRow()
        {
            if (guna2DataGridView1.SelectedRows.Count < 0 || _car.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для данного действия.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void FilterData(string searchText)
        {
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                searchText = searchText.Trim().ToLower();

                var filters = _car
                    .Where(p =>
                        p.Brand.ToLower().Contains(searchText) ||
                        p.Mark.ToLower().Contains(searchText) ||
                        p.VIN.ToLower().Contains(searchText)
                    )
                    .ToList();

                guna2DataGridView1.DataSource = filters;
            }
            else
            {
                guna2DataGridView1.DataSource = _car;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            FilterData(guna2TextBox1.Text);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormEditCar formEdit = new(1, new(), this);
            formEdit.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (!IsSelecedRow())
            {
                return;
            }

            FormListLogin formLogin = new((int)guna2DataGridView1.SelectedRows[0].Cells[0].Value);
            formLogin.ShowDialog();
        }
    }
}
