using System;
using System.IO;

namespace MyTunes
{
    public class StreamLoader : MyTunes.Shared.IStreamLoader
    {
        public Stream GetStreamForFilename(string filename) => File.OpenRead(filename);
    }
}
