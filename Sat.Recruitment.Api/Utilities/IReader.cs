using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Utilities
{
    public interface IReader
    {
        public StreamReader ReadUsersFromFile();
    }
}
