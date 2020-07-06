using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Silosys.Services
{
    public class AlertRequest
    {
        public AlertType AlertType { get; set; }

        public decimal AvailableCapacity { get; set; }

        public string Message { get; set; }
    }
}
