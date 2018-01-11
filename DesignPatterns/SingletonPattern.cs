namespace DesignPatterns
{
    /// <summary>
    /// Instantiates only one object and uses that object for the entire
    /// lifetime of the process. 
    /// This is useful if you wish the object to maintain state of if it takes lots of resources to set the object up
    /// </summary>
    public static class SingletonPattern
    {
        //DateTime.Now
        private static string _presidentOfIndia = "Ram Nath Govindh";

        public static string PresidentOfIndia
        {
            get { return _presidentOfIndia; }
        }

    }
}