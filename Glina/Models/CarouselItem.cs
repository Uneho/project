using System.Windows.Input;


namespace Glina.Models;



public class CarouselItem
{
    public string ImagePath { get; set; }
    public string ButtonContent { get; set; }
    public ICommand NavigateCommand { get; set; }
}