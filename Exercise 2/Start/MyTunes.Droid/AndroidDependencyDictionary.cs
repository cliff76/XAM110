using Android.Content;

namespace MyTunes
{
    internal class AndroidDependencyDictionary : Injector.InjectorDictionary
    {
        private Context applicationContext;

        public AndroidDependencyDictionary(Context applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public object getObjectForType(string type)
        {
            if (type.Equals("IStreamLoader")) return new StreamLoader(applicationContext);
            throw new System.NotImplementedException();
        }
    }
}