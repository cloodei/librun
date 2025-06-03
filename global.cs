namespace Library
{
    public static class global
    {
        public struct ucheck
        {
            public long id;
            public string email;
            public string username;
            public string password;
            public bool locked;
        }

        public static ucheck[] u_list { get; set; } = null;
        public static long user_id { get; set; } = 0;
        public static bool locked { get; set; } = false;
        public static string connectionString { get; set; } = librun.Properties.Settings.Default.libConnectionString;

        public static void SignOut()
        {
            user_id = 0;
        }
    }
}
