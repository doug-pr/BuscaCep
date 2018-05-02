using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaCep.ViewModels
{
    class BuscaCepViewModel : ViewModelBase
    {
        public BuscaCepViewModel() : base()
        {

        }

        private string _CEP;

        public string CEP
        {
            get => _CEP;
            set
            {
                _CEP = value;
                OnPropertyChanged();
            }
        }

    }
}
