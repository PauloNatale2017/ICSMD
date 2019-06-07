using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Repository
{
    public class UserRepository : Repository.BaseRepository<Entities.EntitiModel.User>
    {
        public UserRepository()  : base(new INFRA.DATA.Context.dbContext())
        {

        }
    }

}
