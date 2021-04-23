﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PaymentUIStripe.ViewModels
{
    public class CreditCardPageViewModel: INotifyPropertyChanged
    {
        public string CardNumber { get; set; }
        public string CardCvv { get; set; }
        public string CardExpirationDate { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
