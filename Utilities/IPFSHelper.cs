using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ipfs.Http;

namespace Audify.Utilities
{
    public class IPFSHelper
    {
        public async Task<string> UploadIPFSAsync(string fileName)
        {
            var client = new IpfsClient();
          
            string text = await client.FileSystem.ReadAllTextAsync(fileName);
            string response = "";
            using (StreamReader sr = new StreamReader(fileName))
            {
               
                var r = new string [0];
              response = await  client.UploadAsync("add", System.Threading.CancellationToken.None, sr.BaseStream, fileName,r);

            }
            return response;
        }
    }
}
