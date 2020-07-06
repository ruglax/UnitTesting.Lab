using System;

namespace Lab.Silosys.Services
{
    public class ExternalServiceExample : IExternalServiceExample
    {
        public AlertResponse CreateAlert(AlertRequest alertRequest)
        {
            throw new NotImplementedException();
            //return new AlertResponse
            //{
            //    AlertStatus = AlertStatus.Error,
            //    CreationdCode = null,
            //    Error = "Ocurrio un error al creal la solicitud"
            //};
        }
    }
}
