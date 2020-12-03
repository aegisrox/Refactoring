using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Utilities
{
    public interface INormal
    {
        public void NormalizeEmail(User newUser);
    }
}
