using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CovidDashboardCanada.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private int _totalCases;
        public int TotalCases
        {
            get { return _totalCases; }
            set
            {
                if (_totalCases == value) return;
                _totalCases = value;
                OnPropertyChanged("TotalCases");
            }
        }

        private int _recoveredCases;
        public int RecoveredCases
        {
            get { return _recoveredCases; }
            set
            {
                if (_recoveredCases == value) return;
                _recoveredCases = value;
                OnPropertyChanged("RecoveredCases");
            }
        }

        private int _deaths;
        public int Deaths
        {
            get { return _deaths; }
            set
            {
                if (_deaths == value) return;
                _deaths = value;
                OnPropertyChanged("Deaths");
            }
        }

        private string _selectedRegion;
        public string SelectedRegion
        {
            get { return _selectedRegion; }
            set
            {
                if (_selectedRegion == value) return;
                _selectedRegion = value;
                OnPropertyChanged("SelectedRegion");
            }
        }

        public MainVM()
        {
            Console.WriteLine("Created");
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
