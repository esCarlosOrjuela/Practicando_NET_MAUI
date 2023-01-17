using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Aprendiendo_Net_MAUI.Mvvm.Models.DataBindingDemo
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        public string Name { get => name; set { name = value; OnPropertyChanget(); } }

        private string phone;
        public string Phone { get => phone; set { phone = value; OnPropertyChanget(); } }

        private string address;
        public string Address { get => address; set { address = value; OnPropertyChanget(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanget([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}

