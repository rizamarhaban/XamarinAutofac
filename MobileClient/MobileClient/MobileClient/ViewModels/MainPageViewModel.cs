using SomeExternalServices;
using System.Collections.ObjectModel;

namespace MobileClient.ViewModels
{
    public class MainPageViewModel
    {
        private readonly ICustomerServices _extServices;
        private ObservableCollection<string> _customersName = new ObservableCollection<string>();

        public MainPageViewModel(ICustomerServices extServices)
        {
            _extServices = extServices;
            _extServices.GetCustomersName().ForEach(name => _customersName.Add(name));
        }

        public ObservableCollection<string> Names
        {
            get { return _customersName; }
        }
    }
}
