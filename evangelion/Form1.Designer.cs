namespace evangelion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IDTEXT = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.Label();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1afiliacion = new System.Windows.Forms.TextBox();
            this.comboBox1afiliacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxestadomental = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttontes = new System.Windows.Forms.Button();
            this.button2cargar = new System.Windows.Forms.Button();
            this.numericUpDown1edad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDowneva = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1edad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowneva)).BeginInit();
            this.SuspendLayout();
            // 
            // IDTEXT
            // 
            this.IDTEXT.Location = new System.Drawing.Point(466, 49);
            this.IDTEXT.Name = "IDTEXT";
            this.IDTEXT.Size = new System.Drawing.Size(48, 22);
            this.IDTEXT.TabIndex = 0;
            this.IDTEXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Silver;
            this.dateTimePicker1.Location = new System.Drawing.Point(1198, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(429, 49);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 16);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(466, 97);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(180, 22);
            this.textBoxnombre.TabIndex = 4;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(534, 52);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 5;
            this.button.Text = "buscar";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "nombre";
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Location = new System.Drawing.Point(410, 137);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(39, 16);
            this.edad.TabIndex = 7;
            this.edad.Text = "edad";
            this.edad.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "eva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "afiliacion";
            // 
            // textBox1afiliacion
            // 
            this.textBox1afiliacion.Location = new System.Drawing.Point(466, 259);
            this.textBox1afiliacion.Name = "textBox1afiliacion";
            this.textBox1afiliacion.Size = new System.Drawing.Size(100, 22);
            this.textBox1afiliacion.TabIndex = 12;
            this.textBox1afiliacion.TextChanged += new System.EventHandler(this.textBox1afiliacion_TextChanged);
            // 
            // comboBox1afiliacion
            // 
            this.comboBox1afiliacion.FormattingEnabled = true;
            this.comboBox1afiliacion.Location = new System.Drawing.Point(594, 259);
            this.comboBox1afiliacion.Name = "comboBox1afiliacion";
            this.comboBox1afiliacion.Size = new System.Drawing.Size(121, 24);
            this.comboBox1afiliacion.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(741, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "estado mental";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxestadomental
            // 
            this.textBoxestadomental.Location = new System.Drawing.Point(855, 46);
            this.textBoxestadomental.Name = "textBoxestadomental";
            this.textBoxestadomental.Size = new System.Drawing.Size(154, 22);
            this.textBoxestadomental.TabIndex = 15;
            this.textBoxestadomental.TextChanged += new System.EventHandler(this.textBoxestadomental_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "angel";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(466, 215);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(1078, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "fecha de creacion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 60);
            this.button3.TabIndex = 21;
            this.button3.Text = "actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(139, 563);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 49);
            this.button4.TabIndex = 22;
            this.button4.Text = "eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 444);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1192, 245);
            this.dataGridView1.TabIndex = 23;
            // 
            // buttontes
            // 
            this.buttontes.Location = new System.Drawing.Point(411, 360);
            this.buttontes.Name = "buttontes";
            this.buttontes.Size = new System.Drawing.Size(197, 26);
            this.buttontes.TabIndex = 24;
            this.buttontes.Text = "prueba de conexion";
            this.buttontes.UseVisualStyleBackColor = true;
            this.buttontes.Click += new System.EventHandler(this.buttontes_Click);
            // 
            // button2cargar
            // 
            this.button2cargar.Location = new System.Drawing.Point(139, 279);
            this.button2cargar.Name = "button2cargar";
            this.button2cargar.Size = new System.Drawing.Size(123, 69);
            this.button2cargar.TabIndex = 25;
            this.button2cargar.Text = "cargar";
            this.button2cargar.UseVisualStyleBackColor = true;
            this.button2cargar.Click += new System.EventHandler(this.button2cargar_Click);
            // 
            // numericUpDown1edad
            // 
            this.numericUpDown1edad.Location = new System.Drawing.Point(488, 137);
            this.numericUpDown1edad.Name = "numericUpDown1edad";
            this.numericUpDown1edad.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1edad.TabIndex = 26;
            this.numericUpDown1edad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDowneva
            // 
            this.numericUpDowneva.Location = new System.Drawing.Point(488, 173);
            this.numericUpDowneva.Name = "numericUpDowneva";
            this.numericUpDowneva.Size = new System.Drawing.Size(120, 22);
            this.numericUpDowneva.TabIndex = 27;
            this.numericUpDowneva.ValueChanged += new System.EventHandler(this.numericUpDowneva_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1597, 695);
            this.Controls.Add(this.numericUpDowneva);
            this.Controls.Add(this.numericUpDown1edad);
            this.Controls.Add(this.button2cargar);
            this.Controls.Add(this.buttontes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxestadomental);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1afiliacion);
            this.Controls.Add(this.textBox1afiliacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.IDTEXT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1edad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowneva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTEXT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label edad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1afiliacion;
        private System.Windows.Forms.ComboBox comboBox1afiliacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxestadomental;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttontes;
        private System.Windows.Forms.Button button2cargar;
        private System.Windows.Forms.NumericUpDown numericUpDown1edad;
        private System.Windows.Forms.NumericUpDown numericUpDowneva;
    }
}

