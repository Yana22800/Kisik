using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bor.DataAccess.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bor.Core.Models;
using Albina.BusinesLogic.Core.Models;
using Albina.BusinesLogic.Services;
using Albina.BusinesLogic.Core.Interfaces;
using AutoMapper;

namespace Bor_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCotroller : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserCotroller(IUserService userService, IMapper mapper,)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("/auth")]
        public async Task<ActionResult<UserInformationDto>> Auth([FromBody] UserIdentityDto userIdentityDto)
        {
            UserIdentityBlo userIdentityBlo = _mapper.Map<UserIdentityBlo>(userIdentityDto);
            UserInformationBlo UserInformationBlo = await _userService.Auth(userIdentityBlo);
            UserInformationDto userInformationDto = _mapper.Map<UserInformationDto>(UserInformationBlo);
            return userInformationDto;
        }
        [HttpPost("/register")]
        public async Task<ActionResult<UserInformationDto>> Register([FromBody] UserIdentityDto userIdentityDto)
        {
            UserIdentityBlo userIdentityBlo = _mapper.Map<UserIdentityBlo>(userIdentityDto);
            UserInformationBlo UserInformationBlo = await _userService.Register(userIdentityBlo);
            UserInformationDto userInformationDto = _mapper.Map<UserInformationDto>(UserInformationBlo);
            return userInformationDto;
        }
            [HttpPost("/update")]
            public async Task<ActionResult<UserInformationDto>> Update([FromBody] UserIdentityDto userIdentityDto)
            {
                
            }
        }
    }
}
