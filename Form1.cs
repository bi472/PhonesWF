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

            label4.Text = "Отладочная информация";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // сделать метод для обновления информации в richTextBoxPhoneInfo
        private void update_richTextBoxPhoneInfo()
        {
            richTextBoxPhoneInfo.Clear();
            foreach (Phone phone in phones)
            {
                // Выводим информацию о каждом объекте Phone в списке
                richTextBoxPhoneInfo.AppendText($"Производитель: {phone.Manufacturer}\n");
                richTextBoxPhoneInfo.AppendText($"Количество сим-карт: {phone.SimCardCount}\n");
                richTextBoxPhoneInfo.AppendText($"Модель: {phone.Model}\n");
                richTextBoxPhoneInfo.AppendText($"Диагональ экрана: {phone.ScreenSizeInInches}\n");
                richTextBoxPhoneInfo.AppendText($"Емкость аккумулятора: {phone.BatteryCapacityInmAh}\n");
                richTextBoxPhoneInfo.AppendText($"Операционная система: {phone.OperatingSystem}\n\n\n");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string manufacturer = comboBoxManufacturer.SelectedItem.ToString();
            int simCardCount = (int)numericUpDownSimCards.Value;
            string model = textBoxModel.Text;

            newPhone = new Phone(manufacturer, simCardCount, model);

            // Добавляем созданный объект Phone в список
            phones.Add(newPhone);

            // Обновляем информацию в richTextBoxPhoneInfo
            update_richTextBoxPhoneInfo();

            label4.Text = $" Хэш код созданной модели {newPhone.Manufacturer}, с количеством сим-карт {newPhone.SimCardCount} : {newPhone.GetHashCode()}";
        }


        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Тестирование конструкторов класса Phone
            Phone defaultPhone = new Phone();

            Phone phoneWithBasicProperties = new Phone("Samsung", 2, "Galaxy S10");

            Phone phoneWithAllProperties = new Phone("Apple", 1, "iPhone 11", 6.1, 3110, "iOS 13");

            // Выводим информацию о каждом объекте Phone в списке

            phones.Add(defaultPhone);
            phones.Add(phoneWithBasicProperties);
            phones.Add(phoneWithAllProperties);

            // Обновляем информацию в richTextBoxPhoneInfo

            update_richTextBoxPhoneInfo();

        }
    }
}