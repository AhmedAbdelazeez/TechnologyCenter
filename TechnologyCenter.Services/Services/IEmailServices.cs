using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnologyCenter.Services.Models;

namespace TechnologyCenter.Services.Services
{
    public interface IEmailServices
    {
        void SendEmail(Message message);
    }
}
