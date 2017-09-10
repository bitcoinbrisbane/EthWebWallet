using System;
using System.Collections.Generic;

namespace EthWebWalletMVC.Models
{
    public class HomeViewModel
    {
        public IList<AccountViewModel> Accounts { get; set; }

        public HomeViewModel()
        {
            Accounts = new List<AccountViewModel>();
        }
    }
}