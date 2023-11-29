using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Configuration
{
    public class AuthEndpoint
    {
        public string Base_url { get; set; }
        public string SecretEndpoint { get; set; }
        public string LoginEndpoint { get; set; }
        public string RegisterEndpoint { get; set; }
        public string ChangePasswordEndpoint { get; set; }
    }
}
