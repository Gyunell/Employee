namespace Employee;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        button1.Click += Button1_click;
    }

    public int txt3int;
    public int isciSayan;

    private void Button1_click(object sender, EventArgs e)
    {
        isciSayan += 1;
        txt3int = Convert.ToInt32(textBox3.Text);

        if (textBox1.Text.Length < 3)
        {
            MessageBox.Show("ad 3 simvoldan kicik ola bilmez");
        }
        else if (textBox2.Text.Length < 3)
        {
            MessageBox.Show("soyad 3 simvoldan kicik ola bilmez");
        }
        else if (txt3int < 3 || txt3int < 18)
        {
            MessageBox.Show("yas 18'den kicik, 65'den boyuk ola bilmez");
        }
        else
        {
            listBox1.Items.Add("Employee" + isciSayan);
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox3.Text);
            listBox1.Items.Add(textBox4.Text);
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add("--------------");
        }
    }
}
