using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace GetStartedApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
       CToF();
    }

    private void Celsius_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        CToF();
    }

    private void CToF()
    {
        Debug.WriteLine($"Click! Celsius={Celsius.Text}");
        if (double.TryParse(Celsius.Text, out double c))
        {
            var f = c * (9d / 5d) + 32;
            Fahrenheit.Text = f.ToString("0.00"); 
        }
        else
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";
        }
    }
}