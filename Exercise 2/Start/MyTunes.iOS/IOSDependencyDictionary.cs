namespace MyTunes
{
    internal class IOSDependencyDictionary : Injector.InjectorDictionary
    {
        public object getObjectForType(string type)
        {
            if (type.Equals("IStreamLoader")) return new StreamLoader();
            throw new System.NotImplementedException();
        }
    }
}