using Guna.UI2.WinForms;
using System.Text.RegularExpressions;
using LocalClient = BookingCar.Domain.Entities.Client;

namespace Booking.UI.FormDialog;

public partial class FormEditClient : Form
{
    private LocalClient ClientModel { get; set; }
    private FormClient ClientForm { get; set; }
    private int Option { get; set; }

    public FormEditClient(int option, LocalClient clientModel, FormClient formClient)
    {
        InitializeComponent();
        ClientModel = clientModel;
        Option = option;
        ClientForm = formClient;
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
            guna2TextBox1.Text = ClientModel.Last_name;
            guna2TextBox2.Text = ClientModel.First_name;
            guna2TextBox3.Text = ClientModel.Middle_name;
            guna2TextBox5.Text = ClientModel.Phone;
            guna2TextBox6.Text = ClientModel.Email;
            guna2TextBox7.Text = ClientModel.Passport;
            guna2TextBox8.Text = ClientModel.DriverLicense;
            guna2CheckBox1.Checked = ClientModel.Blocked;
            guna2DateTimePicker1.Value = ClientModel.Birthdate;
            guna2DateTimePicker2.Value = ClientModel.DateStartDriving;
            guna2Button2.Text = "Сохранить";
            label1.Text = "Изменение";
        }
    }

    private async void guna2Button2_Click_1(object sender, EventArgs e)
    {
        if (!CheckValidation())
        {
            return;
        }

        LocalClient client = new()
        {
            ClientId = ClientModel.ClientId,
            Last_name = guna2TextBox1.Text,
            First_name = guna2TextBox2.Text,
            Middle_name = guna2TextBox3.Text,
            Birthdate = guna2DateTimePicker1.Value,
            Phone = guna2TextBox5.Text,
            Email = guna2TextBox6.Text,
            Passport = guna2TextBox7.Text,
            DriverLicense = guna2TextBox8.Text,
            DateStartDriving = guna2DateTimePicker2.Value,
            Blocked = guna2CheckBox1.Checked,
            Experience = 0
        };

        var api = new ApiClient<Staff>(new Uri("http://localhost:5000/api/booking-car"));

        await api.PutAsync("client/edit", client);
        await ClientForm.UpdateDateAsync();
        this.Close();
        return;
    }

    private bool CheckValidation()
    {
        var validationMessage = "";

        if (string.IsNullOrEmpty(guna2TextBox1.Text))
        {
            validationMessage = "Фамилия не может быть пустой.";
        }

        if (guna2TextBox1.Text.Length < 2 || guna2TextBox1.Text.Length > 50)
        {
            validationMessage = "Фамилия должна содержать от 2 до 50 символов.";
        }

        if (ContainsDigits(guna2TextBox1.Text))
        {
            validationMessage = "Фамилия не может содержать цифры.";
        }

        if (string.IsNullOrEmpty(guna2TextBox2.Text))
        {
            validationMessage = "Имя не может быть пустым.";
        }

        if (guna2TextBox2.Text.Length < 2 || guna2TextBox2.Text.Length > 50)
        {
            validationMessage = "Имя должно содержать от 2 до 50 символов.";
        }

        if (ContainsDigits(guna2TextBox2.Text))
        {
            validationMessage = "Имя не может содержать цифры.";
        }

        if (ContainsDigits(guna2TextBox3.Text))
        {
            validationMessage = "Отчество не может содержать цифры.";
        }

        var phoneRegex = new Regex(@"^9\d{9}$");
        if (!phoneRegex.IsMatch(guna2TextBox5.Text))
        {
            validationMessage = "Номер телефона должен начинаться с 9 и содержать только цифры.";
        }

        var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        if (!emailRegex.IsMatch(guna2TextBox6.Text))
        {
            validationMessage = "Неправильная почта.";
        }

        if (guna2DateTimePicker1.Value > DateTime.Now.AddYears(-18))
        {
            validationMessage = "Маленький возраст.";
        }

        if (guna2DateTimePicker1.Value.AddYears(18) < guna2DateTimePicker1.Value)
        {
            validationMessage = "Водительский стаж считаем с 18 лет.";
        }

        if (validationMessage.Count() > 0)
        {
            MessageBox.Show(validationMessage, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    /// <summary>
    /// Метод для проверки строки на наличие цифр.
    /// </summary>
    /// <param name="input">Строка для проверки.</param>
    /// <returns>True, если строка содержит цифры, иначе False.</returns>
    private bool ContainsDigits(string input)
    {
        return input.Any(char.IsDigit);
    }

    private void guna2TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
}
