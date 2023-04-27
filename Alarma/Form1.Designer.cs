namespace Alarma
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
            btnEditAlarm = new Button();
            btnDeleteAlarm = new Button();
            btnAddAlarm = new Button();
            monthCalendar1 = new MonthCalendar();
            textBox2 = new TextBox();
            Nombre = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            domingo = new CheckBox();
            sabado = new CheckBox();
            jueves = new CheckBox();
            miercoles = new CheckBox();
            Martes = new CheckBox();
            viernes = new CheckBox();
            lunes = new CheckBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnEditAlarm
            // 
            btnEditAlarm.Location = new Point(266, 138);
            btnEditAlarm.Name = "btnEditAlarm";
            btnEditAlarm.Size = new Size(94, 29);
            btnEditAlarm.TabIndex = 30;
            btnEditAlarm.Text = "Editar";
            btnEditAlarm.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAlarm
            // 
            btnDeleteAlarm.Location = new Point(265, 95);
            btnDeleteAlarm.Name = "btnDeleteAlarm";
            btnDeleteAlarm.Size = new Size(94, 29);
            btnDeleteAlarm.TabIndex = 29;
            btnDeleteAlarm.Text = "Eliminar";
            btnDeleteAlarm.UseVisualStyleBackColor = true;
            // 
            // btnAddAlarm
            // 
            btnAddAlarm.Location = new Point(265, 60);
            btnAddAlarm.Name = "btnAddAlarm";
            btnAddAlarm.Size = new Size(94, 29);
            btnAddAlarm.TabIndex = 28;
            btnAddAlarm.Text = "Añadir Alarma";
            btnAddAlarm.UseVisualStyleBackColor = true;
            btnAddAlarm.Click += BtnAddAlarm_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(416, 233);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(255, 394);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Editar";
            textBox2.Size = new Size(125, 23);
            textBox2.TabIndex = 26;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(273, 8);
            Nombre.Name = "Nombre";
            Nombre.PlaceholderText = "nombre";
            Nombre.Size = new Size(208, 23);
            Nombre.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(17, 8);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 23);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.Value = new DateTime(2023, 4, 27, 13, 47, 0, 0);
            // 
            // domingo
            // 
            domingo.AutoSize = true;
            domingo.Location = new Point(125, 148);
            domingo.Name = "domingo";
            domingo.Size = new Size(76, 19);
            domingo.TabIndex = 23;
            domingo.Text = "Domingo";
            domingo.UseVisualStyleBackColor = true;
            // 
            // sabado
            // 
            sabado.AutoSize = true;
            sabado.Location = new Point(125, 118);
            sabado.Name = "sabado";
            sabado.Size = new Size(65, 19);
            sabado.TabIndex = 22;
            sabado.Text = "Sabado";
            sabado.UseVisualStyleBackColor = true;
            // 
            // jueves
            // 
            jueves.AutoSize = true;
            jueves.Location = new Point(18, 178);
            jueves.Name = "jueves";
            jueves.Size = new Size(60, 19);
            jueves.TabIndex = 21;
            jueves.Text = "Jueves";
            jueves.UseVisualStyleBackColor = true;
            // 
            // miercoles
            // 
            miercoles.AutoSize = true;
            miercoles.Location = new Point(18, 148);
            miercoles.Name = "miercoles";
            miercoles.Size = new Size(77, 19);
            miercoles.TabIndex = 20;
            miercoles.Text = "Miercoles";
            miercoles.UseVisualStyleBackColor = true;
            // 
            // Martes
            // 
            Martes.AutoSize = true;
            Martes.Location = new Point(18, 118);
            Martes.Name = "Martes";
            Martes.Size = new Size(62, 19);
            Martes.TabIndex = 19;
            Martes.Text = "Martes";
            Martes.UseVisualStyleBackColor = true;
            // 
            // viernes
            // 
            viernes.AutoSize = true;
            viernes.Location = new Point(125, 88);
            viernes.Name = "viernes";
            viernes.Size = new Size(64, 19);
            viernes.TabIndex = 18;
            viernes.Text = "Viernes";
            viernes.UseVisualStyleBackColor = true;
            // 
            // lunes
            // 
            lunes.AutoSize = true;
            lunes.Location = new Point(18, 88);
            lunes.Name = "lunes";
            lunes.Size = new Size(54, 19);
            lunes.TabIndex = 17;
            lunes.Text = "lunes";
            lunes.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 222);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(198, 199);
            listBox1.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnEditAlarm);
            Controls.Add(btnDeleteAlarm);
            Controls.Add(btnAddAlarm);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox2);
            Controls.Add(Nombre);
            Controls.Add(dateTimePicker1);
            Controls.Add(domingo);
            Controls.Add(sabado);
            Controls.Add(jueves);
            Controls.Add(miercoles);
            Controls.Add(Martes);
            Controls.Add(viernes);
            Controls.Add(lunes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditAlarm;
        private Button btnDeleteAlarm;
        private Button btnAddAlarm;
        private MonthCalendar monthCalendar1;
        private TextBox textBox2;
        private TextBox Nombre;
        private DateTimePicker dateTimePicker1;
        private CheckBox domingo;
        private CheckBox sabado;
        private CheckBox jueves;
        private CheckBox miercoles;
        private CheckBox Martes;
        private CheckBox viernes;
        private CheckBox lunes;
        private ListBox listBox1;
    }
}