namespace Booking.UI.FormDialog;

public partial class FormEditCar : Form
{
    private Car CarModel { get; set; }
    private FormCar CarForm { get; set; }
    private int Option { get; set; }

    public FormEditCar(int option, Car carModel, FormCar formCar)
    {
        InitializeComponent();
        CarModel = carModel;
        Option = option;
        CarForm = formCar;
    }

    private void FormEditStaff_Load(object sender, EventArgs e)
    {
        if (Option == 1)
        {
            guna2Button2.Text = "Добавить";
            label1.Text = "Добавление";
        }
        else
        {
            guna2TextBox1.Text = CarModel.Brand;
            guna2TextBox2.Text = CarModel.Mark;
            guna2TextBox3.Text = CarModel.YearStart.ToString();
            guna2TextBox4.Text = CarModel.Color;
            guna2TextBox5.Text = CarModel.CarNumber;
            guna2TextBox6.Text = CarModel.VIN;
            guna2TextBox7.Text = CarModel.MinimalExperience.ToString();
            guna2CheckBox1.Checked = CarModel.Active;
            guna2Button2.Text = "Сохранить";
            label1.Text = "Изменение";
        }
    }

    private async void guna2Button2_Click_1(object sender, EventArgs e)
    {
        Car car = new()
        {
            CarId = CarModel.CarId,
            Brand = guna2TextBox1.Text,
            Mark = guna2TextBox2.Text,
            YearStart = Convert.ToInt32(guna2TextBox3.Text),
            Color = guna2TextBox4.Text,
            CarNumber = guna2TextBox5.Text,
            VIN = guna2TextBox6.Text,
            Active = guna2CheckBox1.Checked,
            MinimalExperience = Convert.ToInt32(guna2TextBox7.Text),
            Class = Convert.ToInt32(guna2ComboBox1.Text.Split('-')[0]),
            ClassTxt = guna2ComboBox1.Text.Split('-')[1]
        };

        var api = new ApiClient<Staff>(new Uri("http://localhost:5000/api/booking-car"));

        await api.PutAsync("booking/car", car);
        await CarForm.UpdateDateAsync();
        this.Close();
        return;
    }
}
