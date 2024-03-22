namespace Glina.Models.Controllers.Ui;

public interface IUiController
{
    void FocusLogin();
    void FocusPassword();
    void PasswordVisibility(bool isVisible);
}