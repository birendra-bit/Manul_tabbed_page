using System;
using System.Collections.Generic;
using System.Text;
using TabView.Modal;

namespace TabView.ViewModel
{
    public class AccountViewModal
    {
        public IList<UserAccount> UserAccounts { get; set; }
        public AccountViewModal()
        {
            UserAccounts = new List<UserAccount>();

            UserAccounts.Add(new UserAccount
            {
                Name = "Birendra Bhujel",
                PhoneNumber = "+91-9078564983",
                ImageURL = "UserImg.png",
                CallImage = "call.png"
            });
            UserAccounts.Add(new UserAccount
            {
                Name = "Zeezil Gurung",
                PhoneNumber = "+91-9078564983",
                ImageURL = "UserImg.png",
                CallImage = "call.png"

            });
            UserAccounts.Add(new UserAccount
            {
                Name = "Leela Maya",
                PhoneNumber = "+91-9078564983",
                ImageURL = "UserImg.png",
                CallImage = "call.png"

            });
            UserAccounts.Add(new UserAccount
            {
                Name = "Asha",
                PhoneNumber = "+91-9078564983",
                ImageURL = "UserImg.png",
                CallImage = "call.png"

            });
            UserAccounts.Add(new UserAccount
            {
                Name = "Wangchuk Kezang",
                PhoneNumber = "+91-9078564983",
                ImageURL = "UserImg.png",
                CallImage = "call.png"

            });
            UserAccounts.Add(new UserAccount
            {
                Name = "Birendra Bhujel",
                PhoneNumber = "+91-9078564983",
                ImageURL = "UserImg.png",
                CallImage = "call.png"
            });
            UserAccounts.Add(new UserAccount
            {
                Name = "Zeezil Gurung",
                PhoneNumber = "+91-9078564983",
                ImageURL = "UserImg.png",
                CallImage = "call.png"

            });
            UserAccounts.Add(new UserAccount
            {
                Name = "Leela Maya",
                PhoneNumber = "+91-9078564983",
                ImageURL = "UserImg.png",
                CallImage = "call.png"

            });
            UserAccounts.Add(new UserAccount
            {
                Name = "Asha",
                PhoneNumber = "+91-9078564983",
                ImageURL = "UserImg.png",
                CallImage = "call.png"

            });
            UserAccounts.Add(new UserAccount
            {
                Name = "Wangchuk Kezang",
                PhoneNumber = "+91-9078564983",
                ImageURL = "UserImg.png",
                CallImage = "call.png"
            });
        }
    }
}
