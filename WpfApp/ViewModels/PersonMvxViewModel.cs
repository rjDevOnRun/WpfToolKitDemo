using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Windows.Input;

namespace WpfApp.ViewModels
{
    /*
     *  This class uses the MvvmCross Nuget Package 
     *  
     *  View model uses traditional MVVM pattern for WPF application
     *  
     */

    public class PersonMvxViewModel: MvxNotifyPropertyChanged
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;

        ICommand nameCommand;
        public ICommand NameCommand => nameCommand ??= new MvxCommand(BuildFullName);


        void BuildFullName()
        {
            FullName = FirstName + " " + LastName;
            RaisePropertyChanged(() => FullName);
        }

    }
}
