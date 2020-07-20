using System.Collections.Generic;
using Lab.Silosys.WinFormsMVP.Presenter;

namespace Lab.Silosys.WinFormsMVP.View
{
    public interface ICustomerView
    {
        IList<string> CustomerList { get; set; }

        int SelectedCustomer { get; set; }

        string CustomerName { get; set; }

        string Address { get; set; }

        string Phone { get; set; }

        CustomerPresenter Presenter { set; }
    }
}