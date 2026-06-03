using System;
using System.Drawing.Text;
using System.Windows.Forms;


namespace CAMIONIU
{
    public partial class Form1 : Form
    {
        Camiones camion1 = new Camiones();
        
        private int velocidadMovimiento = 5;

        public Form1()
        {
            InitializeComponent();
            
        }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 359);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "ENCENDER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ENCENDER_Click;
            // 
            // button2
            // 
            button2.Location = new Point(245, 359);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "APAGAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += APAGAR_Click;
            // 
            // button3
            // 
            button3.Location = new Point(51, 426);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "ACELERAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ACELERAR_Click;
            // 
            // button4
            // 
            button4.Location = new Point(245, 426);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "FRENAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += FRENAR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1041, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            label1.Click += Nombre_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1201, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 5;
            label2.Text = "Estado";
            label2.Click += Estado_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1325, 9);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 6;
            label3.Text = "Kilometraje";
            label3.Click += Kilometraje_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descarga__1_;
            pictureBox1.Location = new Point(64, 212);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += Timer1_Tick;
            // 
            // button5
            // 
            button5.Location = new Point(391, 426);
            button5.Name = "button5";
            button5.Size = new Size(97, 38);
            button5.TabIndex = 8;
            button5.Text = "REINICIAR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += REINICIAR_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1478, 526);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            camion1.Nombre = "Volvo";

            label1.Text = "Camion: " + camion1.Nombre;
            label2.Text = "Estado: " + camion1.GetEstado();
            label3.Text = "Kilometraje: 0";
        }

        private Button button1 = null!;
        private Button button2 = null!;
        private Button button3 = null!;
        private Button button4 = null!;

        private void ENCENDER_Click(object? sender, EventArgs e)
        {
            camion1.Encender();

            label2.Text = "Estado: " + camion1.GetEstado();
        }
        private void APAGAR_Click(object? sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                MessageBox.Show("Primero debe frenar el camión.");
                return;
            }

            camion1.Apagar();

            label2.Text = "Estado: " + camion1.GetEstado();
        }

        private void ACELERAR_Click(object? sender, EventArgs e)
        {
            if (camion1.GetEstado() == "Encendido")
            {
                camion1.Acelerar(60, 10000);
                velocidadMovimiento += 3;
                label3.Text = "Kilometraje: " + camion1.kilometraje;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Primero debes encender el camión");
            }
        }
        private void FRENAR_Click(object? sender, EventArgs e)
        {
            if (velocidadMovimiento > 0)
            {
                velocidadMovimiento -= 3;
            }

            if (velocidadMovimiento < 0)
            {
                velocidadMovimiento = 0;
                timer1.Stop();
            }
        }

        private Label label1 = null!;
        private Label label2 = null!;
        private Label label3 = null!;

        private void Kilometraje_Click(object? sender, EventArgs e)
        {

        }

        private void Estado_Click(object? sender, EventArgs e)
        {

        }

        private void Nombre_Click(object? sender, EventArgs e)
        {

        }

        private PictureBox pictureBox1 = null!;

        private void PictureBox1_Click(object? sender, EventArgs e)
        {
            pictureBox1.Left += 5;
        }

        private System.Windows.Forms.Timer timer1 = null!;
        private System.ComponentModel.IContainer? components;

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            pictureBox1.Left += velocidadMovimiento;

            if (pictureBox1.Left > this.Width)
            {
                pictureBox1.Left = -pictureBox1.Width;

                pictureBox1.Left += velocidadMovimiento;
            }

        }
        
        private Button button5 = null!;

        private void    REINICIAR_Click(object? sender, EventArgs e)
        {
        
            // Detener movimiento
            timer1.Stop();

            // Apagar camión
            camion1.Apagar();

            // Reiniciar kilometraje
            camion1.kilometraje = 0;

            // Volver imagen a posición inicial
            pictureBox1.Left = 64;
            pictureBox1.Top = 212;

            // Actualizar labels
            label2.Text = "Estado: " + camion1.GetEstado();
            label3.Text = "Kilometraje: 0";

            velocidadMovimiento = 5;

            MessageBox.Show("Camión reiniciado");
        
        }
    }
}

