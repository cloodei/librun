namespace Library
{
    public static class global
    {
        public static ucheck[] u_list { get; set; }
        public static long user_id { get; set; } = 0;
        public static string connectionString { get; set; } =
            librun.Properties.Settings.Default.libConnectionString;

        public static void SignOut()
        {
            user_id = 0;
        }
    }
}
