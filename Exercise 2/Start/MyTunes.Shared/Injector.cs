using System;
using MyTunes.Shared;

namespace MyTunes
{
    public class Injector
    {
        public interface InjectorDictionary
        {
            object getObjectForType(string type);
        }

        public Injector()
        {
        }

        public static void inject(InjectorDictionary dictionary)
        {
            SongLoader.loader = (IStreamLoader)dictionary.getObjectForType("IStreamLoader");
        }
    }
}
