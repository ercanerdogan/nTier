﻿using NTier.Data.Interface.DataAccess;
using NTier.Data.Repository.Infrastructure.EntityFramework;
using NTier.Entities.Enum;
using NTier.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Data.Repository.Host.EntityFramework.DataAccess
{
    public class EfClientLineDal : EfEntityRepositoryBase<ClientLine>, IClientLineDal
    {
        private readonly EfNTierContext _context;
        public EfClientLineDal(EfNTierContext context) : base(context)
        {
            this._context = context;
        }

        public IEnumerable<ClientLine> GetClientLinesByClientLineType(ClientLineType clientLineType)
        {
            return this.Get(x => x.ClientLineType == clientLineType);
        }
    }
}
