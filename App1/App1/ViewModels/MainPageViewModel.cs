using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Models;
using App1.Common;

namespace App1.ViewModels
{
    public class MainPageViewModel
    {
        public Customer MyCustomer { get; set; }

        public MainPageViewModel()
        {
            MyCustomer = new Customer { FirstName = "Bob", LastName = "Smith" };
        }

        private RelayCommand _updateNameCommand;

        private void UpdateName()
        {
            MyCustomer.FirstName = "Sue";
        }

        public RelayCommand UpdateNameCommand
        {
            get
            {
                if (_updateNameCommand == null) _updateNameCommand = new RelayCommand(UpdateName);
                return this._updateNameCommand;
            }
            set
            {
                this._updateNameCommand = value;
            }
        }

    }
}
