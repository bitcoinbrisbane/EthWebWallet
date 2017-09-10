using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EthWebWalletMVC.Models;

namespace EthWebWalletMVC.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HomeViewModel viewModel = new HomeViewModel();
            Nethereum.Web3.Web3 web3 = new Nethereum.Web3.Web3("http://192.168.0.103:8545");
            var accounts = await web3.Personal.ListAccounts.SendRequestAsync();

            foreach (var account in accounts)
            {
                Models.AccountViewModel accountViewModel = new Models.AccountViewModel() { Account = account };
                viewModel.Accounts.Add(accountViewModel);
            }

            return View(viewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
