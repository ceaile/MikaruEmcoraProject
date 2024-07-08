using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikaruEmcora.Core.Entities.Base;

namespace MikaruEmcora.Core.Entities
{
    public class User : BaseEntity
    {
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
