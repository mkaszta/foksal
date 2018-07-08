using BLL.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace BLL
{
    public class NBPHelper
    {
        public static CurrencyRate GetRate(string currency)
        {
            string dateParam = "";
            string jsonResponse = "";
            DateTime todayMinusMonth = DateTime.Now.AddMonths(-1);
            DateTime baseDate = new DateTime(todayMinusMonth.Year, todayMinusMonth.Month, DateTime.DaysInMonth(todayMinusMonth.Year, todayMinusMonth.Month));

            while (string.IsNullOrEmpty(jsonResponse))
            {
                dateParam = baseDate.ToString("yyyy-MM-dd");
                jsonResponse = GetNBPResponse(string.Format("http://api.nbp.pl/api/exchangerates/rates/a/{0}/{1}/", currency, dateParam));
                baseDate = baseDate.AddDays(-1);
            }

            NBPCurrency nbpCurrency = JsonConvert.DeserializeObject<NBPCurrency>(jsonResponse);

            return new CurrencyRate()
            {
                Date = Convert.ToDateTime(nbpCurrency.rates[0].effectiveDate),
                Rate = (decimal)nbpCurrency.rates[0].mid
            };
        }

        public static bool CurrencyExists(string currency)
        {
            string jsonResponse = GetNBPResponse(string.Format("http://api.nbp.pl/api/exchangerates/rates/a/{0}/", currency));
            return !string.IsNullOrEmpty(jsonResponse);
        }

        private static string GetNBPResponse(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            try
            {
                WebResponse response = request.GetResponse();

                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                return "";
            }
        }
    }

    public class NBPRate
    {
        public string no { get; set; }
        public string effectiveDate { get; set; }
        public double mid { get; set; }
    }

    public class NBPCurrency
    {
        public string table { get; set; }
        public string currency { get; set; }
        public string code { get; set; }
        public List<NBPRate> rates { get; set; }
    }
}
