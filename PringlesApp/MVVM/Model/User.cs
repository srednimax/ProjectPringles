using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using PringlesApp.Annotations;
using PringlesDatabase.Models;

namespace PringlesApp.MVVM.Model
{
    public class User : INotifyPropertyChanged
    {
        public string Username { get; set; }
        public bool IsAvUsername { get; set; }
        public bool IsCorrectUsername { get; set; }
        public string Password {get; set; }
        public bool IsStrongPassword {get; set; }
        public string ConfirmPassword {get; set; }
        public bool IsSamePassword {get; set; }
        public string Email { get; set; }
        public bool IsAvEmail { get; set; }
        public bool IsCorrectEmail { get; set; }
        public bool IsSameEmail { get; set; }
        public string ConfirmEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsCorrectDateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsCorrectPhoneNumber { get; set; }

        public DateTime CreatedOn { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public int CountBool()
        {
            int score = 0;

            if (IsAvUsername)
                score++;
            if (IsCorrectUsername)
                score++;
            if (IsCorrectEmail)
                score++;
            if (IsSameEmail)
                score++;
            if (IsAvEmail)
                score++;
            if (IsSamePassword)
                score++;
            if (IsStrongPassword)
                score++;
            if (IsCorrectPhoneNumber)
                score++;
            if (IsCorrectDateOfBirth)
                score++;
            return score;
        }
    }
    
}