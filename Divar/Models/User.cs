using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

public class User : Entity
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public byte[] PasswordHash { get; set; }
}
