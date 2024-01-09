using IQTest.API.Controllers;
using IQTest.Core.DTOs;
using IQTest.Core.Models;
using IQTest.Core.Services;
using Moq;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class AuthControllerTest
    {
        private readonly Mock<IAuthenticationService> _mockService;
        private readonly AuthController _controller;

        private List<UserApp> userApp;
        private List<LoginDto> loginDtos;
        private List<TokenDto> tokenDtos;

        public AuthControllerTest()
        {
            _mockService = new Mock<IAuthenticationService>();
            _controller = new AuthController(_mockService.Object);
            userApp = new List<UserApp> { new UserApp { Id = "1", Email = "metintpc@hotmail.com", PasswordHash="a35710SDFG*s2sd" },
            new UserApp { Id = "2", Email = "metintpc1@hotmail.com", PasswordHash="1a35710SDFG*s2sd" },
            new UserApp { Id = "3", Email = "metintpc2@hotmail.com", PasswordHash="2a35710SDFG*s2sd" }};

            loginDtos = new List<LoginDto> { new LoginDto { Email = "metintpc@hotmail.com", Password="a35710SDFG*s2sd" },
            new LoginDto { Email = "metintpc1@hotmail.com", Password="1a35710SDFG*s2sd" },
            new LoginDto { Email = "metintpc2@hotmail.com", Password="2a35710SDFG*s2sd" }};

            tokenDtos = new List<TokenDto> { new TokenDto {  AccessToken = "metintpc@hotmail.com", RefreshToken ="a35710SDFG*s2sd" ,
            AccessTokenExpiration = DateTime.Now, RefrestTokenExpiration = DateTime.Now } };
        }

        [Fact]
        public async void CreateToken_ActionExecutes_ReturnTokenDto()
        {
            var loginDto = loginDtos.First();
            var tokenDto = tokenDtos.First();

            _mockService.Setup(x => x.CreateTokenAsync(loginDto)).ReturnsAsync(CustomResponseDto<TokenDto>.Success(200, tokenDto));

            var result = await _controller.CreateToken(loginDto);

            var customResponseDto = Assert.IsType<CustomResponseDto<TokenDto>>(result);

            _mockService.Verify(x => x.CreateTokenAsync(loginDto), Times.Once);
        }
    }
}
