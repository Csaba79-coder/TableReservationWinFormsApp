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
    public partial class Form1 : Form
    {

        List<Reservation> reservations = new List<Reservation>();
        public Form1()
        {
            InitializeComponent();
            readData();
            writeData();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog();
            if (add.DialogResult == DialogResult.OK)
            {
                readData();
                writeData();
            }
        }

        private void readData()
        {
            reservations.Clear();
            StreamReader reader = new StreamReader("reservation.txt");
            while (!reader.EndOfStream)
            {
                Reservation reserv = new Reservation();
                reserv.NameOfGuest = reader.ReadLine();
                reserv.NumberOfGuest = Convert.ToInt32(reader.ReadLine());
                reserv.ArrivalHour = Convert.ToInt32(reader.ReadLine());
                reserv.ArrivalDate = Convert.ToDateTime(reader.ReadLine());
                reserv.RegularGuest = Convert.ToBoolean(reader.ReadLine());
                reservations.Add(reserv);
            }
            reader.Close();
        }

        private void writeData()
        {
            listBoxGuests.Items.Clear();
            foreach (Reservation res in reservations)
            {
                listBoxGuests.Items.Add(res.NameOfGuest + " " + res.NumberOfGuest);
            }
        }

        private void listBoxGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxRegGuest.Checked = false;
            if (listBoxGuests.SelectedIndex > 0)
            {
                textBoxName.Text = reservations[listBoxGuests.SelectedIndex].NameOfGuest;
                textBoxGuestNumber.Text = reservations[listBoxGuests.SelectedIndex].NumberOfGuest.ToString();
                textBoxArrivalHour.Text = reservations[listBoxGuests.SelectedIndex].ArrivalHour.ToString();
                textBoxArrivalDate.Text = reservations[listBoxGuests.SelectedIndex].ArrivalDate.ToString();
                bool regularGuest = reservations[listBoxGuests.SelectedIndex].RegularGuest;
                if (regularGuest)
                {
                    checkBoxRegGuest.Checked = true;
                }
                else
                {
                    checkBoxRegGuest.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("There is no guest choosen!");
            }
        }
    }
}
