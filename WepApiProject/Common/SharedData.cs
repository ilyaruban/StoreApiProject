namespace WepApiProject.Common
{
    //роли будущих пользователей
    public static class SharedData
    {
        public static class Roles
        {
            public const string Admin = "admin";
            public const string Consumer = "consumer";

            public static IReadOnlyList<string> AllRoles
            {
                get => new List<string>() { Admin, Consumer };
            }
        }
    }
}
