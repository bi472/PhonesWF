namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label4 = new Label();
            dateTimePickerReleaseDate = new DateTimePicker();
            numericUpDownBatteryCapacity = new NumericUpDown();
            numericUpDownScreenSize = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            numericUpDownSimCards = new NumericUpDown();
            textBoxModel = new TextBox();
            osComboBox = new ComboBox();
            phoneTypeComboBox = new ComboBox();
            comboBoxManufacturer = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox5 = new GroupBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label14 = new Label();
            label12 = new Label();
            label10 = new Label();
            groupBox4 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            label9 = new Label();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            tabPage2 = new TabPage();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBatteryCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScreenSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSimCards).BeginInit();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePickerReleaseDate);
            groupBox1.Controls.Add(numericUpDownBatteryCapacity);
            groupBox1.Controls.Add(numericUpDownScreenSize);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numericUpDownSimCards);
            groupBox1.Controls.Add(textBoxModel);
            groupBox1.Controls.Add(osComboBox);
            groupBox1.Controls.Add(phoneTypeComboBox);
            groupBox1.Controls.Add(comboBoxManufacturer);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(65, 34);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new Size(600, 621);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 145);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(183, 32);
            label4.TabIndex = 8;
            label4.Text = "Тип устройства";
            // 
            // dateTimePickerReleaseDate
            // 
            dateTimePickerReleaseDate.Location = new Point(199, 540);
            dateTimePickerReleaseDate.Margin = new Padding(6, 6, 6, 6);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(359, 39);
            dateTimePickerReleaseDate.TabIndex = 7;
            // 
            // numericUpDownBatteryCapacity
            // 
            numericUpDownBatteryCapacity.Location = new Point(338, 416);
            numericUpDownBatteryCapacity.Margin = new Padding(6, 6, 6, 6);
            numericUpDownBatteryCapacity.Name = "numericUpDownBatteryCapacity";
            numericUpDownBatteryCapacity.Size = new Size(223, 39);
            numericUpDownBatteryCapacity.TabIndex = 5;
            numericUpDownBatteryCapacity.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDownScreenSize
            // 
            numericUpDownScreenSize.Location = new Point(338, 343);
            numericUpDownScreenSize.Margin = new Padding(6, 6, 6, 6);
            numericUpDownScreenSize.Name = "numericUpDownScreenSize";
            numericUpDownScreenSize.Size = new Size(223, 39);
            numericUpDownScreenSize.TabIndex = 5;
            numericUpDownScreenSize.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 553);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(152, 32);
            label8.TabIndex = 4;
            label8.Text = "Дата выхода";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 484);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(274, 32);
            label7.TabIndex = 4;
            label7.Text = "Операционная система";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 420);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(283, 32);
            label6.TabIndex = 4;
            label6.Text = "Емкость батареии (mAh)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 348);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(176, 32);
            label5.TabIndex = 4;
            label5.Text = "Размер экрана";
            // 
            // numericUpDownSimCards
            // 
            numericUpDownSimCards.Location = new Point(338, 282);
            numericUpDownSimCards.Margin = new Padding(6, 6, 6, 6);
            numericUpDownSimCards.Name = "numericUpDownSimCards";
            numericUpDownSimCards.Size = new Size(223, 39);
            numericUpDownSimCards.TabIndex = 3;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(338, 213);
            textBoxModel.Margin = new Padding(6, 6, 6, 6);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(219, 39);
            textBoxModel.TabIndex = 2;
            // 
            // osComboBox
            // 
            osComboBox.FormattingEnabled = true;
            osComboBox.Location = new Point(338, 478);
            osComboBox.Margin = new Padding(6, 6, 6, 6);
            osComboBox.Name = "osComboBox";
            osComboBox.Size = new Size(219, 40);
            osComboBox.TabIndex = 1;
            // 
            // phoneTypeComboBox
            // 
            phoneTypeComboBox.FormattingEnabled = true;
            phoneTypeComboBox.Location = new Point(202, 139);
            phoneTypeComboBox.Margin = new Padding(6, 6, 6, 6);
            phoneTypeComboBox.Name = "phoneTypeComboBox";
            phoneTypeComboBox.Size = new Size(355, 40);
            phoneTypeComboBox.TabIndex = 1;
            // 
            // comboBoxManufacturer
            // 
            comboBoxManufacturer.FormattingEnabled = true;
            comboBoxManufacturer.Location = new Point(202, 66);
            comboBoxManufacturer.Margin = new Padding(6, 6, 6, 6);
            comboBoxManufacturer.Name = "comboBoxManufacturer";
            comboBoxManufacturer.Size = new Size(355, 40);
            comboBoxManufacturer.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 288);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(251, 32);
            label3.TabIndex = 0;
            label3.Text = "Количество сим-карт";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 220);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 0;
            label2.Text = "Модель";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 73);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 0;
            label1.Text = "Производитель";
            // 
            // button1
            // 
            button1.Location = new Point(212, 668);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(312, 49);
            button1.TabIndex = 1;
            button1.Text = "Ввод информации";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(676, 34);
            groupBox2.Margin = new Padding(6, 6, 6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 6, 6, 6);
            groupBox2.Size = new Size(667, 621);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Просмотр списка";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(9, 49);
            listBox1.Margin = new Padding(4, 2, 4, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(643, 548);
            listBox1.TabIndex = 7;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(22, 60);
            tabControl1.Margin = new Padding(4, 2, 4, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2311, 1175);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Margin = new Padding(4, 2, 4, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 2, 4, 2);
            tabPage1.Size = new Size(2295, 1121);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Техника";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label20);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label10);
            groupBox5.Location = new Point(1354, 668);
            groupBox5.Margin = new Padding(6, 6, 6, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(6, 6, 6, 6);
            groupBox5.Size = new Size(931, 397);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "Тестирование методов класса";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(11, 361);
            label20.Margin = new Padding(6, 0, 6, 0);
            label20.Name = "label20";
            label20.Size = new Size(91, 32);
            label20.TabIndex = 0;
            label20.Text = "label10";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(11, 329);
            label19.Margin = new Padding(6, 0, 6, 0);
            label19.Name = "label19";
            label19.Size = new Size(91, 32);
            label19.TabIndex = 0;
            label19.Text = "label10";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(11, 297);
            label18.Margin = new Padding(6, 0, 6, 0);
            label18.Name = "label18";
            label18.Size = new Size(91, 32);
            label18.TabIndex = 0;
            label18.Text = "label10";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 265);
            label17.Margin = new Padding(6, 0, 6, 0);
            label17.Name = "label17";
            label17.Size = new Size(91, 32);
            label17.TabIndex = 0;
            label17.Text = "label10";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(11, 233);
            label16.Margin = new Padding(6, 0, 6, 0);
            label16.Name = "label16";
            label16.Size = new Size(91, 32);
            label16.TabIndex = 0;
            label16.Text = "label10";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 169);
            label14.Margin = new Padding(6, 0, 6, 0);
            label14.Name = "label14";
            label14.Size = new Size(91, 32);
            label14.TabIndex = 0;
            label14.Text = "label10";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 105);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(91, 32);
            label12.TabIndex = 0;
            label12.Text = "label10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 41);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(91, 32);
            label10.TabIndex = 0;
            label10.Text = "label10";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(676, 668);
            groupBox4.Margin = new Padding(6, 6, 6, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(6, 6, 6, 6);
            groupBox4.Size = new Size(667, 218);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Работа с файлами";
            // 
            // button4
            // 
            button4.Location = new Point(375, 151);
            button4.Margin = new Padding(6, 6, 6, 6);
            button4.Name = "button4";
            button4.Size = new Size(280, 49);
            button4.TabIndex = 1;
            button4.Text = "Загрузить из файла";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(11, 151);
            button3.Margin = new Padding(6, 6, 6, 6);
            button3.Name = "button3";
            button3.Size = new Size(292, 49);
            button3.TabIndex = 1;
            button3.Text = "Выгрузить в файл";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 41);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(379, 32);
            label9.TabIndex = 0;
            label9.Text = "Прошло времени с даты выхода:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(button2);
            groupBox3.Location = new Point(1354, 34);
            groupBox3.Margin = new Padding(6, 6, 6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(6, 6, 6, 6);
            groupBox3.Size = new Size(576, 621);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Просмотр изображения";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 47);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 499);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(193, 555);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(197, 47);
            button2.TabIndex = 10;
            button2.Text = "Загрузить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(8, 46);
            tabPage2.Margin = new Padding(4, 2, 4, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 2, 4, 2);
            tabPage2.Size = new Size(2253, 1121);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Вторая вкладка";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2346, 1257);
            Controls.Add(tabControl1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBatteryCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScreenSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSimCards).EndInit();
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numericUpDownSimCards;
        private TextBox textBoxModel;
        private ComboBox comboBoxManufacturer;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private GroupBox groupBox2;
        private Label label5;
        private NumericUpDown numericUpDownScreenSize;
        private Label label6;
        private Label label7;
        private ComboBox osComboBox;
        private DateTimePicker dateTimePickerReleaseDate;
        private Label label8;
        private NumericUpDown numericUpDownBatteryCapacity;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBox1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label4;
        private ComboBox phoneTypeComboBox;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label9;
        private Button button4;
        private Button button3;
        private GroupBox groupBox5;
        private Label label14;
        private Label label12;
        private Label label10;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
    }
}