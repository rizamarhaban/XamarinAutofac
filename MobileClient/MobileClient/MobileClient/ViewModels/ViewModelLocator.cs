using CommonServiceLocator;

namespace MobileClient.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            Bootstrapper.Initialize();
        }

        public MainPageViewModel Main
        {
            get { return ServiceLocator.Current.GetInstance<MainPageViewModel>(); }
        }
    }
}
