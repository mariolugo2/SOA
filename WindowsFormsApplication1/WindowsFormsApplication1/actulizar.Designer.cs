namespace WindowsFormsApplication1
{
    partial class actulizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.semestre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_carrera = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_plantel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.s_apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.TextBox();
            this.p_apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.semestre);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.comboBox_carrera);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comboBox_plantel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 136);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos academicos";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(388, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // semestre
            // 
            this.semestre.Location = new System.Drawing.Point(125, 75);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(168, 20);
            this.semestre.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Semestre";
            // 
            // comboBox_carrera
            // 
            this.comboBox_carrera.FormattingEnabled = true;
            this.comboBox_carrera.Items.AddRange(new object[] {
            "SISTEMAS",
            "LOGISTICA",
            "INDUSTRIAL"});
            this.comboBox_carrera.Location = new System.Drawing.Point(388, 31);
            this.comboBox_carrera.Name = "comboBox_carrera";
            this.comboBox_carrera.Size = new System.Drawing.Size(159, 21);
            this.comboBox_carrera.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Carrera";
            // 
            // comboBox_plantel
            // 
            this.comboBox_plantel.FormattingEnabled = true;
            this.comboBox_plantel.Items.AddRange(new object[] {
            "TECNOLOGICO DE MEXICALI",
            "TECNOLOGICO DE TIJUNA",
            "TECNOLOGICO DE MORELIA"});
            this.comboBox_plantel.Location = new System.Drawing.Point(125, 31);
            this.comboBox_plantel.Name = "comboBox_plantel";
            this.comboBox_plantel.Size = new System.Drawing.Size(168, 21);
            this.comboBox_plantel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Plantel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.telefono);
            this.groupBox2.Controls.Add(this.correo);
            this.groupBox2.Controls.Add(this.direccion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 110);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de contacto";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(388, 65);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(159, 20);
            this.telefono.TabIndex = 5;
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(125, 66);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(168, 20);
            this.correo.TabIndex = 4;
            this.correo.Text = "@example.com";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(125, 31);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(422, 20);
            this.direccion.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Direccion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.s_apellido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.matricula);
            this.groupBox1.Controls.Add(this.p_apellido);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 146);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del estudiante";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(388, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(388, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // s_apellido
            // 
            this.s_apellido.Location = new System.Drawing.Point(125, 101);
            this.s_apellido.Name = "s_apellido";
            this.s_apellido.Size = new System.Drawing.Size(168, 20);
            this.s_apellido.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Segundo Apellido";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Matricula";
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(125, 26);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(100, 20);
            this.matricula.TabIndex = 1;
            // 
            // p_apellido
            // 
            this.p_apellido.Location = new System.Drawing.Point(388, 61);
            this.p_apellido.Name = "p_apellido";
            this.p_apellido.Size = new System.Drawing.Size(159, 20);
            this.p_apellido.TabIndex = 6;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(125, 61);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(168, 20);
            this.nombre.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Primer Apellido";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Nombre";
            // 
            // actulizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 487);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "actulizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "actulizar";
            this.toolTip1.SetToolTip(this, "Valor Numerico");
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox semestre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_carrera;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_plantel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox s_apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.TextBox p_apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}