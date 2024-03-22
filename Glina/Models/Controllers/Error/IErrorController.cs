namespace Glina.Models.Controllers.Error;

public interface IErrorController
{
    void DisplayError(string error);
    void ClearErrors();
}