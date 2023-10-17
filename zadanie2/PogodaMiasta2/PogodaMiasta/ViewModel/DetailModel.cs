using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogodaMiasta.ViewModel
{
    public class DetailModel
    {
        private string _detail;

        public DetailModel(string det) 
        {
            _detail = det;
        }

        public string Detail { get => _detail; }

    }
}
