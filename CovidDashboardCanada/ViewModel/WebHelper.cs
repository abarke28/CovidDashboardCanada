using System;
using System.Collections.Generic;
using System.Text;

namespace CovidDashboardCanada.ViewModel
{
    public static class WebHelper
    {
        public const string CONFIRMED_CASES_CSV = @"https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_time_series/time_series_19-covid-Confirmed.csv";
        public const string RECOVERED_CASES_CSV = @"https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_time_series/time_series_19-covid-Recovered.csv";
        public const string DEATHS_CASES_CSV = @"https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_time_series/time_series_19-covid-Deaths.csv";

    }
}
