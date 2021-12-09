using Albina.BusinesLogic.Core.Interfaces;
using Albina.BusinesLogic.Core.Models;
using AutoMapper;
using Bor.DataAccess.Core.Interfaces;
using Bor.DataAccess.Core.Models;
using Microsoft.EntityFrameworkCore;
using Shareds.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.BusinesLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IContext _context;

        public UserService(IMapper mapper, IContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<UserInformationBlo> Auth(UserIdentityBlo userIdentityBlo)
        {
         UserRto user = await _context.Users.FirstOrDefaultAsync(x => x.Password == userIdentityBlo.Password && x.PhoneNumber == userIdentityBlo.Number);

            if (user == null)
                throw new NotFoundException("Неверный номер телефона или пароль");

            return await ConvertToUserInformation(user);
        }

        public Task<bool> DoesExist(int numberPrefix, int number)
        {
            throw new NotImplementedException();
        }

        public async Task<UserInformationBlo> Get(int userId)
        {
            UserRto user = await _context.Users.FirstOrDefaultAsync(h => h.Id == userId);
            if (user == null) throw new NotFoundException($"Пользователь с id {userId} не найден");

            UserInformationBlo userInformationBlo = await ConvertToUserInformation(user);
            return userInformationBlo;
        }

        public async Task<UserInformationBlo> Register(UserIdentityBlo userIdentityBlo)
        {
            UserRto newUser = new UserRto()
            {
                PhoneNumberPrefix = userIdentityBlo.NumberPrefix,
                PhoneNumber = userIdentityBlo.Number,
                Password = userIdentityBlo.Password
            };
            _context.Users.Add(newUser);

            await _context.SaveChangesAsync();

            return await ConvertToUserInformation(newUser);

        }

        public Task<UserInformationBlo> Update(UserIdentityBlo userIdentityBlo, UserUpdateBlo userUpdateBlo)
        {
            throw new NotImplementedException();
        }

        private async Task<UserInformationBlo> ConvertToUserInformation(UserRto userRto)
        {
            if (userRto == null) throw new ArgumentNullException(nameof(userRto));

            UserInformationBlo userInformationBlo = _mapper.Map<UserInformationBlo>(userRto);

            return userInformationBlo;
        }
    }
}
