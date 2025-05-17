using PTPM20;
using System.IO;

namespace PTPM20._2wf
{
    public partial class Form1 : Form
    {
        List<Sanatorium> sanatoriumList = new List<Sanatorium>();
        List<Tourist_Voucher> touristvouchersList = new List<Tourist_Voucher>();
        List<string[]> ListTurVoucher = new List<string[]>();
        List<string[]> ListSanVoucher = new List<string[]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadSanatorium();
            ReadTourist();
            dateGridView();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DiseaseLabel.Visible = false;
            DiseaseTextBox.Visible = false;
            RouteCategoryLabel.Visible = true;
            RouteCategoryTextBox.Visible = true;
            CertificateLabel.Visible = true;
            CertificateTextBox.Visible = true;
            SaveSanatoriumButton.Visible = false;
            SaveTuristButton.Visible = true;

        }

        private void SanatoriumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DiseaseLabel.Visible = true;
            DiseaseTextBox.Visible = true;
            RouteCategoryLabel.Visible = false;
            RouteCategoryTextBox.Visible = false;
            CertificateLabel.Visible = false;
            CertificateTextBox.Visible = false;
            SaveSanatoriumButton.Visible = true;
            SaveTuristButton.Visible = false;
        }

        private void SaveSanatoriumButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            int duration = Convert.ToInt32(DurationTextBox.Text);
            int price = Convert.ToInt32(PriceTextBox.Text);
            string availability_of_excursions = AvailabilityOfExcursionsСomboBox.SelectedItem.ToString();
            string disease = DiseaseTextBox.Text;
            string type = "Санаторий";


            if (Validation.CheckTextFieldOfText(name) == "" && name is not null)
            {
                if (duration > 0 && duration < 15)
                {
                    if (price > 30000 && price <= 200000)
                    {
                        if (Validation.CheckTextFieldOfText(disease) == "" && disease is not null)
                        {
                            Sanatorium sanatorium = new Sanatorium(name, duration, price, availability_of_excursions, disease);
                            sanatoriumList.Add(sanatorium);
                            string writeInFile = sanatorium.Info();
                            StreamWriter sw = new StreamWriter("sanatorium.txt");
                            sw.WriteLine(writeInFile);
                            sw.WriteLine(name);
                            sw.WriteLine(type);
                            sw.WriteLine(duration);
                            sw.WriteLine(price);
                            sw.WriteLine(availability_of_excursions);
                            sw.WriteLine(disease);
                            sw.Close();
                        }
                        else MessageBox.Show(Validation.CheckTextFieldOfText(disease));
                    }
                    else MessageBox.Show("Цена не может быть меньше 30000 и больше 200000");
                }
                else MessageBox.Show("Число суток не может быть меньше 0 и больше 14");
            }
            else MessageBox.Show(Validation.CheckTextFieldOfText(name));
            ReadSanatorium();
            ReadTourist();
            dateGridView();
        }

        private void SaveTuristButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            int duration = Convert.ToInt32(DurationTextBox.Text);
            int price = Convert.ToInt32(PriceTextBox.Text);
            string availability_of_excursions = AvailabilityOfExcursionsСomboBox.SelectedItem.ToString();
            string routeCategory = RouteCategoryTextBox.Text;
            string certificate = CertificateTextBox.Text;
            string type = "Туристическая путевка";


            if (Validation.CheckTextFieldOfText(name) == "" && name is not null)
            {
                if (duration > 0 && duration < 15)
                {
                    if (price > 30000 && price <= 200000)
                    {
                        if (Validation.CheckTextFieldOfText(routeCategory) == "" && routeCategory is not null)
                        {
                            Tourist_Voucher touristvoucher = new Tourist_Voucher(name, duration, price, availability_of_excursions, routeCategory, certificate);
                            touristvouchersList.Add(touristvoucher);
                            string writeInFile = touristvoucher.Info();
                            StreamWriter sw = new StreamWriter("touristvouchers.txt");
                            sw.WriteLine(writeInFile);
                            sw.WriteLine(name);
                            sw.WriteLine(type);
                            sw.WriteLine(duration);
                            sw.WriteLine(price);
                            sw.WriteLine(availability_of_excursions);
                            sw.WriteLine(routeCategory);
                            sw.WriteLine(certificate);
                            sw.Close();
                        }
                        else MessageBox.Show(Validation.CheckTextFieldOfText(routeCategory));
                    }
                    else MessageBox.Show("Цена не может быть меньше 30000 и больше 200000");
                }
                else MessageBox.Show("Число суток не может быть меньше 0 и больше 14");
            }
            else MessageBox.Show(Validation.CheckTextFieldOfText(name));
            ReadSanatorium();
            ReadTourist();
            dateGridView();
        }
        private void ReadSanatorium()
        {
            string line;
            StreamReader sr = new StreamReader("sanatorium.txt");

            while (!sr.EndOfStream)
            {
                string[] voucher = new string[7];

                line = sr.ReadLine();
                voucher[0] = line;

                for (int i = 1; i <= 5; i++)
                {
                    voucher[i] = sr.ReadLine();
                }
                voucher[6] = sr.ReadLine();
                ListSanVoucher.Add(voucher);
            }
            sr.Close();
        }
        private void ReadTourist()
        {
            string line;
            StreamReader sr = new StreamReader("touristvouchers.txt");

            while (!sr.EndOfStream)
            {
                string[] voucher = new string[8];

                line = sr.ReadLine();
                voucher[0] = line;

                for (int i = 1; i <= 6; i++)
                {
                    voucher[i] = sr.ReadLine();
                }
                voucher[7] = sr.ReadLine();
                ListTurVoucher.Add(voucher);
            }
            sr.Close();
        }
        private void dateGridView()
        {
            int x = 0;
            dataGridView1.ColumnCount = 8;
            dataGridView1.RowCount = ListTurVoucher.Count + ListSanVoucher.Count;
            dataGridView1.Columns[0].HeaderCell.Value = "Название";
            dataGridView1.Columns[1].HeaderCell.Value = "Тип путевки";
            dataGridView1.Columns[2].HeaderCell.Value = "Продолжительность";
            dataGridView1.Columns[3].HeaderCell.Value = "Цена";
            dataGridView1.Columns[4].HeaderCell.Value = "Наличие эксурсии";
            dataGridView1.Columns[5].HeaderCell.Value = "Категория маршрута (Для тур. путевки)";
            dataGridView1.Columns[6].HeaderCell.Value = "Справка от врача (Для тур. путевки)";
            dataGridView1.Columns[7].HeaderCell.Value = "Заболевание (Для санатория)";

            for (int i = 0; i < ListTurVoucher.Count; i++)
            {
                dataGridView1[0, i].Value = ListTurVoucher[i][1];
                dataGridView1[1, i].Value = ListTurVoucher[i][2];
                dataGridView1[2, i].Value = ListTurVoucher[i][3];
                dataGridView1[3, i].Value = ListTurVoucher[i][4];
                dataGridView1[4, i].Value = ListTurVoucher[i][5];
                dataGridView1[5, i].Value = ListTurVoucher[i][6];
                dataGridView1[6, i].Value = ListTurVoucher[i][7];
                x++;

            }
            for (int i = 0; i < ListSanVoucher.Count; i++)
            {
                dataGridView1[0, x + i].Value = ListSanVoucher[i][1];
                dataGridView1[1, x + i].Value = ListSanVoucher[i][2];
                dataGridView1[2, x + i].Value = ListSanVoucher[i][3];
                dataGridView1[3, x + i].Value = ListSanVoucher[i][4];
                dataGridView1[4, x + i].Value = ListSanVoucher[i][5];
                dataGridView1[7, x + i].Value = ListSanVoucher[i][6];
            }
        }
    }
}
