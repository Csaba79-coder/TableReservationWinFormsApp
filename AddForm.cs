using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableReservationWinFormsApp
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && numericUpDownPerson.Value > 0 &&
                dateTimePicker1.Value >= DateTime.Now && numericUpDownHour.Value > 10)
            {
                StreamWriter writer = new StreamWriter("reservation.txt", true);
                writer.WriteLine(textBoxName.Text);
                writer.WriteLine(numericUpDownPerson.Value);
                writer.WriteLine(numericUpDownHour.Value);
                writer.WriteLine(dateTimePicker1.Value);
                writer.WriteLine(checkBoxRegular.Checked);
                writer.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("There is not all data fulfilled!");
            }
        }
    }
}
