namespace GestionInmuebles.Models.UserLogic;
public enum Theme { Light, Dark }
public class UserConfiguration
{
    public Theme PreferredTheme { get; set; }

    public UserConfiguration()
    {
        DefaultConfiguration();
    }

    public void DefaultConfiguration()
    {
        PreferredTheme = Theme.Light;
    }
}