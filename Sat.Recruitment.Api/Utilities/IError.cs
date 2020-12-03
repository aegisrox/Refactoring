using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Utilities
{
    public interface IError
    {
        void ValidateErrors(string name, string email, string address, string phone, ref string errors);
    }
}
