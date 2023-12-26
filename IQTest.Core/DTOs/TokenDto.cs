using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Core.DTOs
{
    public class TokenDto
    {
        public string AccessToken { get; set; } // 3 parçadan oluşan string token
        public DateTime AccessTokenExpiration { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefrestTokenExpiration { get; set; }
    }
}
