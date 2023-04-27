using System.Security.Claims;
using System.Windows.Forms;

namespace Alarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddAlarm_Click(object sender, EventArgs e)
        {
            DateTime alarmTime = dateTimePicker1.Value;
            string alarmName = Nombre.Text;
            bool[] alarmDays = { lunes.Checked, Martes.Checked, miercoles.Checked, jueves.Checked, viernes.Checked, sabado.Checked, domingo.Checked };
            Alarm newAlarm = new Alarm(alarmTime, alarmName, alarmDays);

            listBox1.Items.Add(newAlarm);
        }

        private void btnDeleteAlarm_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btnEditAlarm_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Alarm selectedAlarm = (Alarm)listBox1.SelectedItem;
                selectedAlarm.Time = dateTimePicker1.Value;
                selectedAlarm.Name = textBox2.Text;
                selectedAlarm.Days = new bool[] { lunes.Checked, Martes.Checked, miercoles.Checked, jueves.Checked, viernes.Checked, sabado.Checked, domingo.Checked };
                listBox1.Items[listBox1.SelectedIndex] = selectedAlarm;
            }
        }
    }

    public class Alarm
    {
        public DateTime Time { get; set; }
        public string Name { get; set; }
        public bool[] Days { get; set; }

        public Alarm(DateTime time, string name, bool[] days)
        {
            Time = time;
            Name = name;
            Days = days;
        }

        public bool IsActive(DateTime currentTime)
        {
            if (Days[(int)currentTime.DayOfWeek] && currentTime.TimeOfDay >= Time.TimeOfDay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }

}
