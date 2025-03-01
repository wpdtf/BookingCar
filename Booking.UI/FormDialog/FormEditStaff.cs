namespace Booking.UI.FormDialog;

public partial class FormEditStaff : Form
{
    private Staff StaffModel { get; set; }
    private FormStaff FormStaff { get; set; }
    private int Option { get; set; }

    public FormEditStaff(int option, Staff staffModel, FormStaff formStaff)
    {
        InitializeComponent();
        StaffModel = staffModel;
        Option = option;
        FormStaff = formStaff;
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
            guna2TextBox1.Text = StaffModel.Last_name;
            guna2TextBox3.Text = StaffModel.First_name;
            guna2TextBox2.Text = StaffModel.Middle_name;
            guna2DateTimePicker1.Value = StaffModel.Birthdate;
            guna2TextBox4.Text = StaffModel.Phone;
            guna2CheckBox1.Checked = StaffModel.Dismissed;
            guna2Button2.Text = "Сохранить";
            label1.Text = "Изменение";
        }
    }

    private async void guna2Button2_Click_1(object sender, EventArgs e)
    {
        Staff staff = new()
        {
            Last_name = guna2TextBox1.Text,
            First_name = guna2TextBox3.Text,
            Middle_name = guna2TextBox2.Text,
            Birthdate = guna2DateTimePicker1.Value,
            Phone = guna2TextBox4.Text,
            UserId = StaffModel.UserId,
            Dismissed = guna2CheckBox1.Checked,
            Position = Convert.ToInt16(guna2ComboBox1.Text.Split('-')[0]),
            PositionTxt = guna2ComboBox1.Text.Split('-')[1]
        };

        var api = new ApiClient<Staff>(new Uri("http://localhost:5000/api/booking-car"));

        await api.PutAsync("tech-support/staff", staff);
        await FormStaff.UpdateDateAsync();
        this.Close();
        return;
    }
}
