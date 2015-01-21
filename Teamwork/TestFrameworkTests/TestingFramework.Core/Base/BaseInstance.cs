namespace TestingFramework.Core.Base
{
    public static class BaseInstance<TPage> where TPage : new()
    {
        private static TPage instance;

        public static TPage Instance
        {
            get
            {
                if (!(instance != null))
                {
                    instance = new TPage();
                }

                return instance;
            }
        }
    }
}
