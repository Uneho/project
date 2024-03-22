using System.Windows;
using System.Windows.Controls;

namespace Glina.Models.Controllers.Ui;

public class UiController : IUiController
{
    private TextBox _loginTextBox;
    private PasswordBox _passwordBox;
    private TextBox _passwordTextBox; // используется для отображения пароля как текста

    public UiController(TextBox loginTextBox, PasswordBox passwordBox, TextBox passwordTextBox)
    {
        _loginTextBox = loginTextBox;
        _passwordBox = passwordBox;
        _passwordTextBox = passwordTextBox;
    }

    public void FocusLogin()
    {
        _loginTextBox.Focus();
    }

    public void FocusPassword()
    {
        _passwordBox.Focus();
    }

    public void PasswordVisibility(bool isVisible)
    {
        if (isVisible)
        {
            _passwordTextBox.Text = _passwordBox.Password;
            _passwordTextBox.Visibility = Visibility.Visible;
            _passwordBox.Visibility = Visibility.Collapsed;
        }
        else
        {
            _passwordBox.Visibility = Visibility.Visible;
            _passwordTextBox.Visibility = Visibility.Collapsed;
        }
    }
}