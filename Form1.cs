using PhoneClass;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Phone newPhone;

        private List<Phone> phones = new List<Phone>();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] manufacturers = { "Samsung", "Apple", "Huawei", "Nokia", "LG", "Sony" };
            string[] operating_systems = { "Android", "iOS" };

            comboBoxManufacturer.Items.AddRange(manufacturers);
            osComboBox.Items.AddRange(operating_systems);

            label4.Text = "���������� ����������";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // ������� ����� ��� ���������� ���������� � richTextBoxPhoneInfo
        private void update_richTextBoxPhoneInfo()
        {
            richTextBoxPhoneInfo.Clear();
            foreach (Phone phone in phones)
            {
                // ������� ���������� � ������ ������� Phone � ������
                richTextBoxPhoneInfo.AppendText($"�������������: {phone.Manufacturer}\n");
                richTextBoxPhoneInfo.AppendText($"���������� ���-����: {phone.SimCardCount}\n");
                richTextBoxPhoneInfo.AppendText($"������: {phone.Model}\n");
                richTextBoxPhoneInfo.AppendText($"��������� ������: {phone.ScreenSizeInInches}\n");
                richTextBoxPhoneInfo.AppendText($"������� ������������: {phone.BatteryCapacityInmAh}\n");
                richTextBoxPhoneInfo.AppendText($"������������ �������: {phone.OperatingSystem}\n\n\n");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string manufacturer = comboBoxManufacturer.SelectedItem.ToString();
            int simCardCount = (int)numericUpDownSimCards.Value;
            string model = textBoxModel.Text;

            newPhone = new Phone(manufacturer, simCardCount, model);

            // ��������� ��������� ������ Phone � ������
            phones.Add(newPhone);

            // ��������� ���������� � richTextBoxPhoneInfo
            update_richTextBoxPhoneInfo();

            label4.Text = $" ��� ��� ��������� ������ {newPhone.Manufacturer}, � ����������� ���-���� {newPhone.SimCardCount} : {newPhone.GetHashCode()}";
        }


        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ������������ ������������� ������ Phone
            Phone defaultPhone = new Phone();

            Phone phoneWithBasicProperties = new Phone("Samsung", 2, "Galaxy S10");

            Phone phoneWithAllProperties = new Phone("Apple", 1, "iPhone 11", 6.1, 3110, "iOS 13");

            // ������� ���������� � ������ ������� Phone � ������

            phones.Add(defaultPhone);
            phones.Add(phoneWithBasicProperties);
            phones.Add(phoneWithAllProperties);

            // ��������� ���������� � richTextBoxPhoneInfo

            update_richTextBoxPhoneInfo();

        }
    }
}