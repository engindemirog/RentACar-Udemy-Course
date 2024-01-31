using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Constants;

public static class UsersOperationClaims
{
    public const string Admin = "users.admin";

    public const string Read = "users.read";
    public const string Write = "users.write";

    public const string Add = "users.add";
    public const string Update = "users.update";
    public const string Delete = "users.delete";

}
