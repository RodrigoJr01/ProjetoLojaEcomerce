using LojaEcomerce.Models;

namespace LojaEcomerce.Interface
{
    public interface IUsuarioRepositorio
    {
        // A interface não contem codigo apenas a promessa do que se deve ser feito(como um contrato)
        LoginViewModel Validar(string email, string senha);
    }
}
