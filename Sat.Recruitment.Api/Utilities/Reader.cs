using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Utilities
{
    public class Reader : IReader
    {
        public StreamReader ReadUsersFromFile()
        {
                
                var path = Directory.GetCurrentDirectory() + "/Files/Users.txt";

                FileStream fileStream = new FileStream(path, FileMode.Open);

                StreamReader reader = new StreamReader(fileStream);

                return reader;
        }
    }
}
