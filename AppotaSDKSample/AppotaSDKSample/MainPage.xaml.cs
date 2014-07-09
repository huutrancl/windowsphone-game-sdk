using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AppotaSDKSample.Resources;
using APTCallback;
using APTPaymentService;

namespace AppotaSDKSample
{
    public partial class MainPage : PhoneApplicationPage, AppotaSDKCallback
    {
        AppotaGameSDK gameSDK;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            gameSDK = new AppotaGameSDK(this);
        }

        private void btnShowLogin_Click(object sender, RoutedEventArgs e)
        {
            gameSDK.ShowLogin();
        }

        private void btnShowPayment_Click(object sender, RoutedEventArgs e)
        {
            gameSDK.MakePayment();
        }

        private void btnSwitchAccount_Click(object sender, RoutedEventArgs e)
        {
            gameSDK.SwitchAccount();
        }

        private void btnShowUserInfo_Click(object sender, RoutedEventArgs e)
        {
            gameSDK.ShowUserInfo();
        }


        private void btnLogoutAccount_Click(object sender, RoutedEventArgs e)
        {
            gameSDK.LogoutAccount();
        }
      
        public void onPaymentError(string message)
        {
            //throw new NotImplementedException();
        }

        public void onPaymentSuccess(APTPaymentResult.TransactionResult result)
        {
           // throw new NotImplementedException();
        }

        public void onUserLoginError(string message)
        {
           // throw new NotImplementedException();
        }

        public void onUserLoginSuccess(APTPaymentResult.UserLoginResult result)
        {
           // throw new NotImplementedException();
        }

        public void onUserRegisterError(string message)
        {
           // throw new NotImplementedException();
        }

        public void onUserRegisterSuccess(APTPaymentResult.UserLoginResult result)
        {
          //  throw new NotImplementedException();
        }
    }
}