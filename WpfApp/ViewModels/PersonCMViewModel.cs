using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfApp.ViewModels
{
    /* 
        This class uses the CommunityToolKit.MVVM Nuget Package (8.00 preview-2) 
        
        - Very easy WPF ViewModels, just using the Attribute Annotations
        - Very clean codebase..
        - all codes required to run are generated automatically

        - For properties:
            - annotate with [ObservableProperty]
            - to notify other props use [AlsoNotifyChangeFor]
            - to notify Command CanExecutes... use [AlsoNotifyCanExecuteFor]

        - For Commands:
            - Method to Execute: annotate with [ICommand]
            - Method to CanExecute: annotate with [ICommand(CanExecute(nameof(MethodToCheck))]
     */


    [INotifyPropertyChanged]
    public partial class PersonCMViewModel
    {
        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullName))]
        [AlsoNotifyCanExecuteFor(nameof(BuildFullNameCommand))]
        string firstName = string.Empty;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullName))]
        [AlsoNotifyCanExecuteFor(nameof(BuildFullNameCommand))]
        string lastName = string.Empty;

        [ObservableProperty]
        string fullName = string.Empty;


        [ICommand(CanExecute = nameof(CanBuildFullName))]
        void BuildFullName()
        {
            FullName = FirstName + " " + LastName;
        }

        bool CanBuildFullName()
        {
            if((string.IsNullOrEmpty(firstName)) && (string.IsNullOrEmpty(lastName))) return false;

            return true;
        }

    }
}
