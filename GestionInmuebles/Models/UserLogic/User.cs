using GestionInmuebles.Models.CompanyLogic;
namespace GestionInmuebles.Models.UserLogic;
public class User
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; } //Cambiar a forma segura
    public List<Company> CompanyAccess { get; set; }
    public UserConfiguration Configuration { get; set; }

    public User(string email, string name, string password)
    {
        Id = Guid.NewGuid();
        Email = email;
        Name = name;
        Password = password;
        CompanyAccess = [];
        Configuration = new UserConfiguration();
    }

    //Login
    //Logout
}