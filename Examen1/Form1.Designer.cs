namespace Examen1
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            button3 = new Button();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox9 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            groupBox4 = new GroupBox();
            label10 = new Label();
            button4 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(31, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 127);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Triangulo";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 83);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 54);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Altura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(94, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(86, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(86, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(86, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(209, 92);
            button1.Name = "button1";
            button1.Size = new Size(71, 29);
            button1.TabIndex = 0;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += crearTriangulo;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(31, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(286, 123);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rectangulo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 85);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 12;
            label4.Text = "Base";
            // 
            // button2
            // 
            button2.Location = new Point(209, 88);
            button2.Name = "button2";
            button2.Size = new Size(71, 29);
            button2.TabIndex = 1;
            button2.Text = "Crear";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 56);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 11;
            label5.Text = "Altura";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(94, 53);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(86, 23);
            textBox5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 27);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 10;
            label6.Text = "Nombre";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(94, 24);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(86, 23);
            textBox6.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(94, 82);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(86, 23);
            textBox4.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Location = new Point(31, 286);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(286, 124);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Paralelogramo";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 83);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 18;
            label7.Text = "Base";
            // 
            // button3
            // 
            button3.Location = new Point(209, 89);
            button3.Name = "button3";
            button3.Size = new Size(71, 29);
            button3.TabIndex = 2;
            button3.Text = "Crear";
            button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 54);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 17;
            label8.Text = "Altura";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(94, 51);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(86, 23);
            textBox7.TabIndex = 14;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(94, 80);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(86, 23);
            textBox9.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 25);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 16;
            label9.Text = "Nombre";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(94, 22);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(86, 23);
            textBox8.TabIndex = 13;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(button4);
            groupBox4.Location = new Point(352, 20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(408, 390);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pila";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 34);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 4;
            label10.Click += label10_Click;
            // 
            // button4
            // 
            button4.Location = new Point(294, 355);
            button4.Name = "button4";
            button4.Size = new Size(108, 29);
            button4.TabIndex = 3;
            button4.Text = "Mostrar Pila";
            button4.UseVisualStyleBackColor = true;
            button4.Click += mostrarPila;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 37);
            label11.Name = "label11";
            label11.Size = new Size(26, 15);
            label11.TabIndex = 5;
            label11.Text = "Pila";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 448);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
        private Button button2;
        private GroupBox groupBox3;
        private Button button3;
        private GroupBox groupBox4;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private TextBox textBox4;
        private Label label7;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox9;
        private Label label9;
        private TextBox textBox8;
        private Label label10;
        private ContextMenuStrip contextMenuStrip1;
        private Label label11;
    }
}
