# WpfToolKitDemo
WPF with Traditional v/s CommunityTookKit.MVVM Approach


This application uses the CommunityToolKit.MVVM Nuget Package (8.00 preview-2) 
        
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
