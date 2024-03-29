﻿using IQTest.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Core.Services
{
    public interface IUserService
    {
        Task<CustomResponseDto<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<CustomResponseDto<UserAppDto>> GetUserByNameAsync(string userName);
        Task<CustomResponseDto<NoContentDto>> CreateUserRoles(CreateUserRolesDTO createUserRolesDTO);
        Task<CustomResponseDto<NoContentDto>> CreateRoles(CreateRolesDTO createRolesDTO);
    }
}
