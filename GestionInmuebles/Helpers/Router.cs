using GestionInmuebles.Views;

namespace GestionInmuebles.Helpers;
public class Router
{
    public static void Navigate(string route, MainWindow window)
    {
        switch (route)
        {
            case "login":
                window.NavigateTo(new LoginPage());
                break;
            case "home":
                window.NavigateTo(new HomePage());
                break;
            case "user":
                window.NavigateTo(new UserPage());
                break;
            case "company":
                window.NavigateTo(new CompanyDetails());
                break;
            case "property-list":
                window.NavigateTo(new PropertyList());
                break;
            case "property":
                window.NavigateTo(new PropertyDetails());
                break;
            default:
                window.NavigateTo(new NotFoundPage());
                break;
        }
    }

}
