using BookingCar.Domain.Dto;

namespace Booking.UI.FormDialog;

public partial class FormAuth : Form
{
    public FormAuth()
    {
        InitializeComponent();
    }

    private void Guna2Button1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private async void Guna2Button2_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text))
        {
            MessageBox.Show("Заполните логин и пароль.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var api = new ApiClient<Auth>(new Uri("http://localhost:5000/api/booking-car"));

        var authDto = new AuthDTO()
        {
            Login = guna2TextBox1.Text,
            Password = HashPassword(guna2TextBox2.Text)
        };

        var user = await api.PostAsync("tech-support/auth", authDto);

        if (user is null)
        {
            return;
        }

        if (user.IsDelete)
        {
            MessageBox.Show("Вас удалили, обратитесь к администратору.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        CurrentUser.FullName = user.FullName;
        CurrentUser.Role = user.Position;

        FormMain formMain = new();
        formMain.Show();
        this.Hide();
    }

    public string HashPassword(string password)
    {
        byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(bytes);
    }
}
