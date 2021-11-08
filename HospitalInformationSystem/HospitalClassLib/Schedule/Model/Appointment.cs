// File:    Termin.cs
// Author:  paracelsus
// Created: Monday, March 22, 2021 6:47:56 PM
// Purpose: Definition of Class Termin


using HospitalClassLib.RoomsAndEquipment.Model;
using HospitalClassLib.SharedModel;
using HospitalClassLib.SharedModel.Enums;
using System;




namespace HospitalClassLib.Schedule.Model
{
    public class Appointment 
   {
        

        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public AppointmentType Type { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Room Room { get; set; }
        public DateTime InitialTime { get; set; }
        public String AppointmentID { get; set; }
        
    
                

        public Appointment(DateTime startTime, int duration, AppointmentType type, Doctor doctor, Patient patient, Room room)
        {
            StartTime = startTime;
            InitialTime = startTime;
            Duration = duration;
            Type = type;
            Doctor = doctor;
            Patient = patient;
            Room = room;
            AppointmentID = GenerateID();
            
        }

        public Appointment()
        {
            Type = AppointmentType.examination;
            AppointmentID = GenerateID();
            
        }

        public Appointment(Appointment anamnesisAppointment)
        {
           
            StartTime = anamnesisAppointment.StartTime;
            InitialTime = anamnesisAppointment.InitialTime;
            Duration = anamnesisAppointment.Duration;
            Type = anamnesisAppointment.Type;
            Doctor = anamnesisAppointment.Doctor;
            Patient = anamnesisAppointment.Patient;
            Room = anamnesisAppointment.Room;
            AppointmentID = anamnesisAppointment.AppointmentID;
            
        }

        

        public bool EqualDate(DateTime date)
        {
            return this.StartTime == date;
        }

        public DateTime GetEndTime()
        {
            return StartTime.AddMinutes(Duration);
        }

        public bool GetIfPast()
        {
            return (GetEndTime() < DateTime.Now);
        }

        public String GetAppointmentDate() 
        { 
            return StartTime.ToString("dd.MM.yyyy."); 
        }

        public String GetAppointmentTime()
        {
            return StartTime.ToString("HH:mm");
        }

        

        private static string GenerateID()
        {
            return DateTime.Now.ToString("yyMMddhhmmssffffff");
        }

        public bool GetIfCurrent()
        {
            return (StartTime <= DateTime.Now && GetEndTime() >= DateTime.Now);
        }

        

        //TODO: move logic to dto mapper
        public String GetPatientName()
        {
            return Patient.FullName;
        }

        //TODO: move logic to dto mapper
        public String GetDoctorName()
        {
            return Doctor.FullName;
        }

        //TODO: move logic to mapper
        public String AppointmentFullInfo
        {
            get => GetDoctorName() + ", " + GetAppointmentTime() + " " + GetAppointmentDate();
        }

        public bool SameStartTime(DateTime startTime)
        {
            return this.StartTime == startTime;
        }

    }
}