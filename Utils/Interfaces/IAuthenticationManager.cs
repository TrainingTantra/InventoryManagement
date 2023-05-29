using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public interface IAuthenticationManager
    {
        string? Authenticator(string username, string password);
    }
}
