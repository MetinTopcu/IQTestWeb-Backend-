using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Core.DTOs
{
    public class CreateUserRolesDTO
    {
        public Guid UserId { get; set; }

        public string Roles { get; set; } = string.Empty;
    }
}
