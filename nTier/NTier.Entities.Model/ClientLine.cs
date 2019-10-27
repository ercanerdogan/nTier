using NTier.Entities.Enum;
using NTier.Entities.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Entities.Model
{
    public class ClientLine : BaseModel
    {
        public int ClientLineId { get; set; }
        public int ClientID { get; set; }
        public ClientLineType ClientLineType { get; set; }
    }
}
