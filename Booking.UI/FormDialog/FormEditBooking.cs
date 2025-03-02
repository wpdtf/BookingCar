using BookingCar.Domain.Declare;
using BookingCar.Domain.Entities;
using Guna.UI2.WinForms;
using System.Text.RegularExpressions;
using LocalBooking = BookingCar.Domain.Entities.Booking;
using LocalClient = BookingCar.Domain.Entities.Client;

namespace Booking.UI.FormDialog;

public partial class FormEditBooking : Form
{
    private LocalBooking BookingModel { get; set; }
    private LocalClient ClientModel { get; set; }
    private Car CarModel { get; set; }
    private FormBooking BookingForm { get; set; }
    private int Option { get; set; }
    private string TariffName { get; set; }

    public FormEditBooking(int option, LocalBooking bookingModel, LocalClient clientModel, Car carModel, FormBooking formBooking, string tarriffName)
    {
        InitializeComponent();
        BookingModel = bookingModel;
        ClientModel = clientModel;
        CarModel = carModel;
        Option = option;
        BookingForm = formBooking;
        TariffName = tarriffName;
    }

    private void FormEditStaff_Load(object sender, EventArgs e)
    {
        if (SelectedCar.CarId > 0)
        {

            if (SelectedCar.CarId == CarModel.CarId)
            {
                guna2Button1.Text = "Выбрано";
                guna2Button1.Enabled = false;
            }
            else
            {
                guna2Button1.Enabled = true;
            }
        }
        else
        {
            guna2Button1.Enabled = false;
        }

        if (SelectedClient.ClientId > 0)
        {

            if (SelectedClient.ClientId == ClientModel.ClientId)
            {
                guna2Button3.Text = "Выбрано";
                guna2Button3.Enabled = false;
            }
            else
            {
                guna2Button3.Enabled = true;
            }
        }
        else
        {
            guna2Button3.Enabled = false;
        }

        if (SelectedTariff.TarrifId > 0)
        {

            if (SelectedTariff.TarrifId == BookingModel.TariffId)
            {
                guna2Button1.Text = "Выбрано";
                guna2Button4.Enabled = false;
            }
            else
            {
                guna2Button4.Enabled = true;
            }
        }
        else
        {
            guna2Button4.Enabled = false;
        }

        if (Option == 1)
        {
            guna2Button2.Text = "Добавить";
            label1.Text = "Добавление";
            guna2Button3.Enabled = false;
            guna2Button6.Enabled = false;
            guna2Button7.Enabled = false;
        }
        else
        {
            guna2TextBox1.Text = CarModel.Brand;
            guna2TextBox2.Text = CarModel.Color;
            guna2TextBox3.Text = ClientModel.Last_name;
            guna2TextBox4.Text = BookingModel.BookingTime.ToString();
            guna2TextBox5.Text = ClientModel.First_name;
            guna2TextBox6.Text = ClientModel.Phone;
            guna2TextBox7.Text = TariffName;
            guna2TextBox8.Text = BookingModel.Status.ToString();
            guna2DateTimePicker1.Value = BookingModel.BookingStart;
            guna2Button2.Text = "Сохранить";
            label1.Text = "Изменение";

            if (BookingModel.Status == statusBooking.Сancellation)
            {
                guna2Button3.Enabled = false;
                guna2Button4.Enabled = false;
                guna2Button1.Enabled = false;
                guna2Button6.Enabled = false;
                guna2Button5.Enabled = false;
                guna2Button7.Text = "Востановить";
            }
            else if (BookingModel.Status == statusBooking.Create)
            {
                guna2Button6.Enabled = false;
            }
            else if (BookingModel.Status == statusBooking.End)
            {
                guna2Button7.Enabled = false;
            }
        }
    }

    private async void guna2Button2_Click_1(object sender, EventArgs e)
    {
        if (!await CheckValidationAsync())
        {
            return;
        }

        LocalBooking booking = new()
        {
            BookingId = BookingModel.BookingId,
            CarId = BookingModel.CarId,
            ClientId = BookingModel.ClientId,
            Status = BookingModel.Status,
            BookingTime = Convert.ToInt32(guna2TextBox4.Text),
            BookingStart = guna2DateTimePicker1.Value,
            TariffId = BookingModel.TariffId
        };

        var api = new ApiClient<LocalBooking>(new Uri("http://localhost:5000/api/booking-car"));

        await api.PutAsync("booking/booking", booking);
        await BookingForm.UpdateDateAsync();
        this.Close();
        return;
    }

    private async Task<bool> CheckValidationAsync()
    {
        var validationMessage = "";
        var api = new ApiClient<ClientExpirience>(new Uri("http://localhost:5000/api/booking-car"));
        var result = await api.GetAsync($"client/experience?clientId={BookingModel.ClientId}");

        if (result.Expirience < CarModel.MinimalExperience)
        {
            validationMessage = "Стаж клиента меньше необходимого для автомобиля.";
        }

        if (!guna2TextBox4.Text.All(char.IsDigit) && !(int.Parse(guna2TextBox4.Text) > 0))
        {
            validationMessage = "Время аренды должно быть положительным числом.";
        }

        if (guna2TextBox7.Text.Count() == 0)
        {
            validationMessage = "Необходимо указать тариф.";
        }

        if (validationMessage.Count() > 0)
        {
            MessageBox.Show(validationMessage, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        guna2Button1.Enabled = false;
        guna2Button1.Text = "Изменено";

        BookingModel.CarId = SelectedCar.CarId;
        CarModel.Brand = SelectedCar.Brand;
        CarModel.Color = SelectedCar.Color;
        CarModel.MinimalExperience = SelectedCar.MinimalExperience;
        guna2TextBox1.Text = CarModel.Brand;
        guna2TextBox2.Text = CarModel.Color;
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
        guna2Button3.Enabled = false;
        guna2Button3.Text = "Изменено";

        BookingModel.ClientId = SelectedClient.ClientId;
        ClientModel.First_name = SelectedClient.First_name;
        ClientModel.Last_name = SelectedClient.Last_name;
        ClientModel.Phone = SelectedClient.Phone;
        guna2TextBox3.Text = ClientModel.Last_name;
        guna2TextBox5.Text = ClientModel.First_name;
        guna2TextBox6.Text = ClientModel.Phone;
    }

    private void guna2Button4_Click(object sender, EventArgs e)
    {
        guna2Button4.Enabled = false;
        guna2Button4.Text = "Изменено";

        BookingModel.TariffId = SelectedTariff.TarrifId;
        TariffName = SelectedTariff.Name;
        guna2TextBox7.Text = TariffName;
    }

    private void guna2Button5_Click(object sender, EventArgs e)
    {
        BookingModel.Status = statusBooking.Сancellation;
        guna2TextBox8.Text = BookingModel.Status.ToString();


        guna2Button3.Enabled = false;
        guna2Button4.Enabled = false;
        guna2Button1.Enabled = false;
        guna2Button6.Enabled = false;
        guna2Button5.Enabled = false;
        guna2Button7.Text = "Востановить";
    }

    private void guna2Button6_Click(object sender, EventArgs e)
    {
        if (BookingModel.Status == statusBooking.Payment)
        {
            guna2Button6.Enabled = false;
            BookingModel.Status = statusBooking.Create;
            guna2TextBox8.Text = BookingModel.Status.ToString();
        }
        else if (BookingModel.Status == statusBooking.End)
        {
            BookingModel.Status = statusBooking.Payment;
            guna2TextBox8.Text = BookingModel.Status.ToString();
        }
    }

    private void guna2Button7_Click(object sender, EventArgs e)
    {
        if (BookingModel.Status == statusBooking.Create)
        {
            BookingModel.Status = statusBooking.Payment;
            guna2TextBox8.Text = BookingModel.Status.ToString();
        }
        else if (BookingModel.Status == statusBooking.Payment)
        {
            guna2Button7.Enabled = false;
            BookingModel.Status = statusBooking.End;
            guna2TextBox8.Text = BookingModel.Status.ToString();
        }
        else if (BookingModel.Status == statusBooking.Сancellation)
        {
            guna2Button6.Enabled = false;
            BookingModel.Status = statusBooking.Create;
            guna2TextBox8.Text = BookingModel.Status.ToString();
        }
    }
}
