using AutoMapper;
using IQTest.Core.DTOs;
using IQTest.Core.Models;
using IQTest.Core.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Service.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<UserApp> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserService(UserManager<UserApp> userManager, IMapper mapper, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
        }

        public async Task<CustomResponseDto<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new UserApp();

            if(createUserDto.City != null)
            {
                user = new UserApp { Email = createUserDto.Email, UserName = createUserDto.UserName , City = createUserDto.City};
            }
            else
            {
                user = new UserApp { Email = createUserDto.Email, UserName = createUserDto.UserName };
            }

            var result = await _userManager.CreateAsync(user, createUserDto.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToList();

                return CustomResponseDto<UserAppDto>.Fail(404, errors);
            }

            return CustomResponseDto<UserAppDto>.Success(200, _mapper.Map<UserAppDto>(user));
        }

        public async Task<CustomResponseDto<NoContentDto>> CreateUserRoles(CreateUserRolesDTO createUserRolesDTO)
        { 

            var user = await _userManager.FindByIdAsync(createUserRolesDTO.UserId.ToString());

            //AspNetUserRoles tablosu
            await _userManager.AddToRoleAsync(user, createUserRolesDTO.Roles);


            return CustomResponseDto<NoContentDto>.Success(201);
        }

        public async Task<CustomResponseDto<NoContentDto>> CreateRoles(CreateRolesDTO createRolesDTO)
        {
            //AspNetRoles tablosu
            if (!await _roleManager.RoleExistsAsync(createRolesDTO.Roles))
            {
                await _roleManager.CreateAsync(new() { Name = createRolesDTO.Roles });
            }

            return CustomResponseDto<NoContentDto>.Success(201);
        }

        public async Task<CustomResponseDto<UserAppDto>> GetUserByNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            if (user == null) return CustomResponseDto<UserAppDto>.Fail(404, "UserName not found");

            return CustomResponseDto<UserAppDto>.Success(200, _mapper.Map<UserAppDto>(user));
        }
    }
}
