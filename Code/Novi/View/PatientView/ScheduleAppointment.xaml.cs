﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Model;
using Controller;

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for ScheduleAppointment.xaml
    /// </summary>
    public partial class ScheduleAppointment : Window
    {
        private int id;
        public Appointment appointment = new Appointment();
        public AppointmentController appointmentController = new AppointmentController();
        public ScheduleAppointment(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientView(id);
            s.Show();
            Close();
        }

        private void Schedule_Click(object sender, RoutedEventArgs e)
        {
            appointment = appointmentController.ReadApp(Int32.Parse(Id.Text));
            appointmentController.UpdateApp(appointment.DateTime, appointment.Descripton, appointment.Duration, appointment.Emergency, id, 1, 1, appointment.Id); //Zameniti 1 sa Doctor.Id i Room.Id
            var s = new PatientView(id);
            s.Show();
            Close();
        }
    }
}
