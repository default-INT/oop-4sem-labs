using EventPlanningLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEventPlanning
{
    public partial class DeleteEventForm : Form
    {
        private EventPlanning events;
        private MonthCalendar calendar;

        public DeleteEventForm(ref EventPlanning events, ref MonthCalendar calendar)
        {
            InitializeComponent();
            this.events = events;
            this.calendar = calendar;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(
                        datePicker.Value.Year,
                        datePicker.Value.Month,
                        datePicker.Value.Day,
                        datePicker.Value.Hour,
                        datePicker.Value.Minute,
                        0
                );
            
            events.DeleteEvent(nameBox.Text, date);
            if (events.CountEventsOnDay(date) == 0)
            {
                calendar.RemoveBoldedDate(date);
                calendar.UpdateBoldedDates();
            }
            this.Close();
        }
    }
}
