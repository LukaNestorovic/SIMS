﻿using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for PatientView.xaml
    /// </summary>
    public partial class PatientView : Window
    {
        
        public AppointmentController appointmentController = new AppointmentController();
        public PatientController patientController = new PatientController();
        public Appointment appointment = new Appointment();
        public ObservableCollection<Appointment> appointments;
        public Patient patient = new Patient();
        private int brojac;
        private int id;

        public PatientView(int id)
        {
            InitializeComponent();
            appointments = new ObservableCollection<Appointment>(appointmentController.FindAllByPatientId(id));
            PatientAppointments.ItemsSource = appointments;
            this.id = id;
        }

       
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            patient = patientController.ReadPatient(id);
            appointment = (Appointment)PatientAppointments.SelectedItem;
            if (appointment == null)
            {
                MessageBox.Show("Choose appointment", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (patient.Brojac > 4)
                {
                    MessageBox.Show("Blokirani ste", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                    var t = new LogIn();
                    t.Show();
                    Close();
                }
                else
                {
                    appointmentController.DeleteAppointment(appointment.Id, id);
                    var s = new PatientView(id);
                    s.Show();
                    Close();
                }
            }
            
        }


        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Appointment appointment1 = new Appointment();
            appointment = (Appointment)PatientAppointments.SelectedItem;
            if (appointment == null)
            {
                MessageBox.Show("Choose appointment", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                    appointment1 = appointmentController.FindAppointment(appointment.Id);
                    var s = new Edit(appointment1, id);
                    s.Show();
                    Close();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientHome(id);
            s.Show();
            Close();
        }

        private void Schedule_Click(object sender, RoutedEventArgs e)
        {
            var s = new FreeAppointments(id);
            s.Show();
            Close();
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
            Close();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
