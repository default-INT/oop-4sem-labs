using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventPlanningLibrary;

namespace WindowsFormsEventPlanning
{
    public partial class AddEventForm : Form
    {
        private EventPlanning events;
        private MonthCalendar calendar;

        public AddEventForm()
        {
            InitializeComponent();
        }

        public AddEventForm(ref EventPlanning events, ref MonthCalendar calendar)
        {
            InitializeComponent();
            this.events = events;
            this.calendar = calendar;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            events.CreateEvent(nameBox.Text, datePicker.Value);
            calendar.AddAnnuallyBoldedDate(datePicker.Value);
            calendar.UpdateBoldedDates();
            AddEventForm.ActiveForm.Close();
        }
    }
}
