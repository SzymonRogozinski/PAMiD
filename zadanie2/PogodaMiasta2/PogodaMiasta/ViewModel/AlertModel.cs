using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogodaMiasta.ViewModel
{
    public class AlertModel
    {
        private string _status;
        private string _date;
        private string _type;
        private string _value;

        public AlertModel(string status, string date, string type, string value)
        {
            _status = status;
            _date = date;
            _type = type;
            _value = value;
        }

        public AlertModel(string status)
        {
            _status = status;
        }

        public string Status {  get { return _status??"..."; } }
        public string Date { get { return _date ?? "..."; } }
        public string Type { get { return _type ?? "..."; } }
        public string Value { get { return _value ?? "..."; } }
    }
}
