using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace GetHash
{
    class Hasher
    {
        private string result;
        private readonly string path;

        internal string Result
        {
            get
            {
                hash();
                return result;
            }

            set
            {
                result = value;
            }
        }

        internal Hasher(string path)
        {
            this.path = path;
        }

        private void hash()
        {
            try
            {
                using (var sha = SHA384.Create())
                {
                    using (var file = File.OpenRead(path))
                    {
                        Result = Convert.ToBase64String(sha.ComputeHash(file));
                    }
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
