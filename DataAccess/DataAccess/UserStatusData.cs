using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class UserStatusData : IUserStatusData
    {
        private readonly SkillsManagerContext _context;

        public UserStatusData(SkillsManagerContext context)
            => _context = context;

        public async Task<List<UserStatusModel>> GetUserStatuses()
        {
            return await _context.UserStatus
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
