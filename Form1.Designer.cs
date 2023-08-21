namespace Employee;

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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 550);
        this.Text = "Form1";

        label1 = new Label();
        label1.Location = new Point(350,40);
        label1.Name = "Label1";
        label1.Text = "Please add an employee";
        label1.Width = 200;
        this.Controls.Add(label1);

        label2 = new Label();
        label2.Location = new Point(150,90);
        label2.Name = "Label1";
        label2.Text = "Employee's name";
        label2.Width = 100;
        this.Controls.Add(label2);
        
        textBox1 = new TextBox();
        textBox1.Location = new Point(250,90);
        textBox1.Name = "TextBox1";
        textBox1.Width = 200;
        this.Controls.Add(textBox1);

        label3 = new Label();
        label3.Location = new Point(150,120);
        label3.Name = "Label3";
        label3.Text = "Employee's last";
        label3.Width = 100;
        this.Controls.Add(label3);

        textBox2 = new TextBox();
        textBox2.Location = new Point(250,120);
        textBox2.Name = "TextBox2";
        textBox2.Width = 200;
        this.Controls.Add(textBox2);

        label4 = new Label();
        label4.Location = new Point(150,150);
        label4.Name = "Label4";
        label4.Text = "Employee's age";
        label4.Width = 100;
        this.Controls.Add(label4);

        textBox3 = new TextBox();
        textBox3.Location = new Point(250,150);
        textBox3.Name = "TextBox3";
        textBox3.Width = 200;
        this.Controls.Add(textBox3);

        label5 = new Label();
        label5.Location = new Point(150,180);
        label5.Name = "Label5";
        label5.Text = "Employee's salary";
        label5.Width = 100;
        this.Controls.Add(label5);

        textBox4 = new TextBox();
        textBox4.Location = new Point(250,180);
        textBox4.Name = "TextBox4";
        textBox4.Width = 200;
        this.Controls.Add(textBox4);

        label6 = new Label();
        label6.Location = new Point(150,210);
        label6.Name = "Label6";
        label6.Text = "Employee's task";
        label6.Width = 100;
        this.Controls.Add(label6);

        comboBox1 = new ComboBox();
        comboBox1.Location = new Point(250,210);
        comboBox1.Name = "ComboBox1";
        comboBox1.Items.Add("BackEnd");
        comboBox1.Items.Add("FrontEnd");
        comboBox1.Items.Add("DataBase");
        comboBox1.Width = 200;
        this.Controls.Add(comboBox1);

        button1 = new Button();
        button1.Location = new Point(250,250);
        button1.Name = "Button1";
        button1.Text = "Add";
        button1.Width = 200;
        button1.Height = 50;
        button1.ForeColor = Color.White;
        button1.BackColor = Color.Green;
        this.Controls.Add(button1);
        
        listBox1 = new ListBox();
        listBox1.Location = new Point(140,330);
        listBox1.Name = "ListBox1";
        listBox1.Width = 500;
        listBox1.Height = 200;
        this.Controls.Add(listBox1);

        pictureBox1 = new PictureBox();
        pictureBox1.Name = "PictureBox1";
        pictureBox1.Location = new Point(500,120);
        pictureBox1.ImageLocation = @"C:\Users\user\Desktop\employees.jpg";
        pictureBox1.Width = 160;
        pictureBox1.Height = 100;
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        this.Controls.Add(pictureBox1);

    }


    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;

    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;

    private Button button1;

    private ComboBox comboBox1;

    private ListBox listBox1;

    private PictureBox pictureBox1;
    #endregion
}
