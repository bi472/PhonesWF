using PhoneClass;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        private void UpdateListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = phones;
            listBox1.DisplayMember = phones.ToString();
        }

        public Phone CreatePhoneFromJson(string phoneData)
        {
            var jsonData = JObject.Parse(phoneData);

            string manufacturer = jsonData["Manufacturer"].ToObject<string>();
            int simCardCount = jsonData["SimCardCount"].ToObject<int>();
            string model = jsonData["Model"].ToObject<string>();
            double screenSize = jsonData["ScreenSizeInInches"].ToObject<double>();
            int batteryCapacity = jsonData["BatteryCapacityInmAh"].ToObject<int>();
            string os = jsonData["OperatingSystem"].ToObject<string>();
            DateTime releaseDate = jsonData["ReleaseDate"].ToObject<DateTime>();

            return new Phone(manufacturer, simCardCount, model, screenSize, batteryCapacity, os, releaseDate);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] manufacturers = { "Samsung", "Apple", "Huawei", "Nokia", "LG", "Sony" };
            string[] operating_systems = { "Android", "iOS" };
            string[] phoneTypes = { "Phone", "Smartphone", "FeaturePhone" };

            this.BackColor = Phone.BackColor;

            comboBoxManufacturer.Items.AddRange(manufacturers);
            phoneTypeComboBox.Items.AddRange(phoneTypes);
            phoneTypeComboBox.SelectedIndex = 0;
            osComboBox.Items.AddRange(operating_systems);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string manufacturer = comboBoxManufacturer.SelectedItem.ToString();
                string phoneType = phoneTypeComboBox.SelectedItem.ToString();
                int simCardCount = (int)numericUpDownSimCards.Value;
                string model = textBoxModel.Text;
                float screenSize = (float)numericUpDownScreenSize.Value;
                int batteryCapacity = (int)numericUpDownBatteryCapacity.Value;
                string os = osComboBox.SelectedItem.ToString();
                DateTime releaseDate = dateTimePickerReleaseDate.Value;

                if (phoneType == "Phone")
                {
                    newPhone = new Phone(manufacturer, simCardCount, model, screenSize, batteryCapacity, os, releaseDate);
                }
                else if (phoneType == "Smartphone")
                {
                    // �������� ����� �������������� ���������, ����������� ��� Smartphone
                    newPhone = new Smartphone(manufacturer, simCardCount, model, screenSize, batteryCapacity, os, releaseDate, true, 12, true);
                }
                else if (phoneType == "FeaturePhone")
                {
                    // �������� ����� �������������� ���������, ����������� ��� FeaturePhone
                    newPhone = new FeaturePhone(manufacturer, simCardCount, model, true, "LCD");
                }

                // ��������� ��������� ������ Phone � ������
                phones.Add(newPhone);


                UpdateListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ������������ ������������� ������ Phone
            Phone defaultPhone = new Phone();

            Phone phoneWithBasicProperties = new Phone("Samsung", 2, "Galaxy S10");

            Phone phoneWithAllProperties = new Phone("Apple", 1, "iPhone 11", 6.1, 3110, "iOS 13", new DateTime(2019, 9, 20));

            // ������� ���������� � ������ ������� Phone � ������

            phones.Add(defaultPhone);
            phones.Add(phoneWithBasicProperties);
            phones.Add(phoneWithAllProperties);

            // ��������� ���������� � richTextBoxPhoneInfo
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "�������� �����������";
                openFileDialog.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // �������� � ����������� �����������
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);

                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (listBox1.SelectedItem != null && saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    saveFileDialog.Title = "��������� ������ Phone";
                    saveFileDialog.Filter = "JSON files (*.json)|*.json";

                    Phone selectedPhone = listBox1.SelectedItem as Phone;
                    if (selectedPhone != null)
                    {
                        string phoneData = JsonConvert.SerializeObject(selectedPhone); // ������������ ������� Phone � JSON
                        File.WriteAllText(saveFileDialog.FileName, phoneData);
                    }
                    else
                    {
                        MessageBox.Show("��������� ������� �� �������� �������� Phone.");
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "�������� ���� � �������";
                openFileDialog.Filter = "JSON files (*.json)|*.json";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string phoneData = File.ReadAllText(openFileDialog.FileName);
                    Phone deserializedPhone = CreatePhoneFromJson(phoneData); // �������������� JSON � ������ Phone
                    // ���������� �������� �������� � ���� �������
                    DateTime now = DateTime.Now;
                    TimeSpan age = now - deserializedPhone.ReleaseDate;
                    int years = age.Days / 365;

                    MessageBox.Show(deserializedPhone.ToString());

                    // ������� ���������� � ����������������� ������� Phone � ListBox
                    phones.Add(deserializedPhone);
                    UpdateListBox();

                    // ����� ���������� � ����� �������� � ������� ������ � ���� ������� ��������
                    label9.Text = "������� ��� ������ � ���� �������:" + years;
                }
            }
        }
    }
}   