using System.Windows;
using System.Windows.Input;
using WPF_MVVM.Commands;

namespace WPF_MVVM.Views;

public partial class MainWindow : Window
{
    public ICommand ShowCommand { get; set; }

    public MainWindow()
    {
        InitializeComponent();

        DataContext = this;

        //ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteShowCommand);
    }

    void ExecuteShowCommand(object parameter)
    {
        MessageBox.Show(parameter.ToString());
    }

    //bool CanExecuteShowCommand(object parameter)
    //{
    //    return txtBox.Text.Length > 3;
    //}
}