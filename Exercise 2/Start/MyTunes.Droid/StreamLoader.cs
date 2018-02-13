using System.IO;
using Android.Content;

namespace MyTunes
{
    public class StreamLoader : MyTunes.Shared.IStreamLoader
    {
        private readonly Context context;

        public StreamLoader(Context context) => this.context = context;

        public Stream GetStreamForFilename(string filename) => context.Assets.Open(filename);
    }
}
