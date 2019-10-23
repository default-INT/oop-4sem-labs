using System;
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
    public partial class Form1 : Form
    {
        private Font fontForm;
        private EventPlanning events = new EventPlanning();

        public Form1()
        {
            InitializeComponent();
            fontForm = header.Font;
            TemplateEvents();
            for (int i = 0; i < events.GetLength(); i++)
            {
                monthCalendar.AddBoldedDate(events[i].date);
            }
            dataGridView.Rows.Add(
                events.CountEventsOnDay(DayOfWeek.Monday),
                events.CountEventsOnDay(DayOfWeek.Tuesday),
                events.CountEventsOnDay(DayOfWeek.Wednesday),
                events.CountEventsOnDay(DayOfWeek.Thursday),
                events.CountEventsOnDay(DayOfWeek.Friday),
                events.CountEventsOnDay(DayOfWeek.Saturday),
                events.CountEventsOnDay(DayOfWeek.Sunday)
            );
        }

        /// <summary>
        /// Метод обновляет значение таблицы
        /// </summary>
        private void RefreshEventTable()
        {
            dataGridView.Rows[0].SetValues(
                events.CountEventsOnDay(DayOfWeek.Monday),
                events.CountEventsOnDay(DayOfWeek.Tuesday),
                events.CountEventsOnDay(DayOfWeek.Wednesday),
                events.CountEventsOnDay(DayOfWeek.Thursday),
                events.CountEventsOnDay(DayOfWeek.Friday),
                events.CountEventsOnDay(DayOfWeek.Saturday),
                events.CountEventsOnDay(DayOfWeek.Sunday)
            );
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteEventForm deleteEventForm = new DeleteEventForm(ref events, ref monthCalendar);
            deleteEventForm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEventForm addEventForm = new AddEventForm(ref events, ref monthCalendar);
            addEventForm.Show();
        }

        /// <summary>
        /// Примеры мероприятий
        /// </summary>
        private void TemplateEvents()
        {
            events.CreateEvent("Поездка в Минск", new DateTime(2019, 4, 3, 8, 20, 0));
            events.CreateEvent("Поход в музей", new DateTime(2019, 4, 3, 15, 0, 0));
            events.CreateEvent("Поход в кино", new DateTime(2019, 4, 3, 16, 10, 0));
            events.CreateEvent("Поход в музей", new DateTime(2019, 4, 5, 14, 0, 0));
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            HideMenu();
            header.Text = "Мероприятия";
            headerListEventLable.Text = "Все мероприятия: ";
            for (int i = 0; i < events.GetLength(); i++)
            {
                label2.Text += (i+1).ToString() + " " + events[i].name + " " + events[i].date.ToString() +  "\n";
            }
        }

        private void Calendar_DateSelect(object sender, DateRangeEventArgs e)
        {
            EventPlanning eventsOnDay = events.FindEventsOnDate(e.End);
            HideMenu();
            header.Text = "Мероприятия";
            headerListEventLable.Text = "Список всех пероприятий на " + e.End.ToLongDateString() + ":";

            for (int i = 0; i < eventsOnDay.GetLength(); i++)
            {
                label2.Text += eventsOnDay[i].date.ToShortTimeString() + " " + eventsOnDay[i].name + "\n";
            }
        }

        /// <summary>
        /// Метод скрывает элементы пункта "Меню"
        /// </summary>
        private void HideMenu()
        {
            dataGridView.Hide();
            label2.Text = "";
            nameLabel.Hide();
            nameBox.Hide();
            dateTimeEntry.Hide();
            dateLabel.Hide();
            outputButtonDate.Hide();
        }

        /// <summary>
        /// Метод показывает элементы раздела "Меню"
        /// </summary>
        private void ShowMenu()
        {
            dataGridView.Show();
            label2.Text = "Вывести даты проведения указаного мероприятия";
            nameLabel.Show();
            nameBox.Show();
            dateTimeEntry.Show();
            dateLabel.Show();
            outputButtonDate.Show();
        }

        private void OutputDateButton_Click(object sender, EventArgs e)
        {
            EventPlanning eventsAfterDate = events.FindEventsAfterDate(nameBox.Text, dateTimeEntry.Value.Date);
            HideMenu();
            headerListEventLable.Text = "Даты проведения мероприятия \n\"" + nameBox.Text
                + "\" после "+ dateTimeEntry.Value.ToLongDateString() + ":";
            for (int i = 0; i<eventsAfterDate.GetLength(); i++)
            {
                label2.Text += eventsAfterDate[i].date.ToLongDateString() + "\n";
            }
            
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            ShowMenu();
            RefreshEventTable();
        }
    }
}
