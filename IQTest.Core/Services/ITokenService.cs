using IQTest.Core.Configuration;
using IQTest.Core.DTOs;
using IQTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Core.Services
{
    public interface ITokenService
    {
        Task<TokenDto> CreateToken(UserApp userApp);
        ClientTokenDto CreateTokenByClient(Client client);

    }
}
