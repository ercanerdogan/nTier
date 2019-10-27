using NTier.Entities.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Entities.Model
{
    public class Client : BaseModel
    {
        public int ClientID { get; set; }
        public int ClientName { get; set; }
        public int ClientTitle { get; set; }
    }
}
