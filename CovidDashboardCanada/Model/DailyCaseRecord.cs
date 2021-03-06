﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CovidDashboardCanada.Model
{
    public class DailyCaseRecord
    {
        public string DateString { get; set; }
        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        private double _latitude;
        public double Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }
        private double _longtitude;
        public double Longtitude
        {
            get { return _longtitude; }
            set { _longtitude = value; }
        }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public string CaseType { get; set; }
        public int BC { get; set; }
        public int AB { get; set; }
        public int SK { get; set; }
        public int MB { get; set; }
        public int ON { get; set; }
        public int QC { get; set; }
        public int NB { get; set; }
        public int NS { get; set; }
        public int NF { get; set; }
        public int PEI { get; set; }
        public int NWT { get; set; }
        public int YK { get; set; }
        public int NV { get; set; }
        public int WS { get; set; }
        public int ID { get; set; }
        public int MT { get; set; }
    }
}
