using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Silosys.Services
{
    public class AlertResponse
    {
        public AlertStatus AlertStatus { get; set; }

        public Guid? CreationdCode { get; set; }

        public string Error { get; set; }
    }
}
