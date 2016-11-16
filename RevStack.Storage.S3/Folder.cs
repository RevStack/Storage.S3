using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevStack.Storage.Model;

namespace RevStack.Storage.S3
{
    public class Folder : IFolder
    {
        public string Path { get; set; }
        public long Size { get; set; }
        public string Url { get; set; }
    }
}
