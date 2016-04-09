using Prism.Commands;
using Prism.Windows.Mvvm;
using PrismStarter.Service.Domain;
using PrismStarter.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrismStarter.Service.ViewModels
{
    public class IntroPageViewModel : ViewModelBase
    {
        private readonly IAddressService _addressService;
        public string FullName { get; set; }

        private string _phone;
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                SetProperty(ref _phone, value);
            }
        }

        private string _phone2;
        public string Phone2
        {
            get
            {
                return _phone2;
            }
            set
            {
                SetProperty(ref _phone2, value);
            }
        }

        private string _myCtrlProperty;
        public string MyCtrlProperty
        {
            get
            {
                return _myCtrlProperty;
            }
            set
            {
                SetProperty(ref _myCtrlProperty, value);
            }
        }

        public ICommand PhoneBtnCommand { get; private set; }
        public ICommand SendBtnCommand { get; private set; }

        public List<Address> Addresses { get; set; }

        public IntroPageViewModel(IAddressService addressService)
        {
            _addressService = addressService;
            var entity = _addressService.GetAddress();
            FullName = string.Join(" ", entity.FirstName, entity.LastName);
            Addresses = _addressService.GetAll();

            PhoneBtnCommand = new DelegateCommand(() =>
            {
                Phone = "01819421877";
            });

            SendBtnCommand = new DelegateCommand(() =>
            {
                Phone2 = Phone;
            });
        }
    }
}
