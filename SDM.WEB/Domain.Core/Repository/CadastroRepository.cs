using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Repository
{
    public class CadastroRepository : Repository.BaseRepository<Entities.EntitiModel.Cadastro>
    {
        public CadastroRepository()
            : base(new INFRA.DATA.Context.dbContext())
        {

        }
    }
}
