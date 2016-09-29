﻿using System.Threading.Tasks;
using Coolector.Common.DTO.Users;

namespace Coolector.Services.Users.Auth0
{
    public interface IAuth0RestClient
    {
        Task<Auth0UserDto> GetUserAsync(string userId);
        Task<Auth0UserDto> GetUserByAccessTokenAsync(string accessToken);
    }
}