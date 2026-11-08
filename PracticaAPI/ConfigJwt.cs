using Microsoft.IdentityModel.Tokens;
using System.Text;
namespace PracticaAPI
{
    public class ConfigJwt
    {
        //Llave secreta: con ella el servidor FIRMA el token y el cliente lo valida
        //Debe tener 32 caracteres para que sea segura. En un proyecto no va codigo (se usa user-secret).
        public static readonly SymmetricSecurityKey Llave = new(Encoding.UTF8.GetBytes("llave-secreta-de-la-prectica-maui-2026-cambiarla"));
    }
}
