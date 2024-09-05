using MikaruEmcora.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikaruEmcora.Core.Entities {
    public class EmailReceived : BaseEntity {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

    }
}
