namespace Dimah.Core.Application.Shared
{
    public class SystemEnums
    {
        public enum ChartItemStatuses
        {
            New = 1,
            Payed = 2,
            Deleted = 3
        }
        public enum DailyRequestStatus
        {
            New = 1,
            Payed = 2,
            Finished = 3,
            Deleted = 4
        }

        public enum Roles
        {
            SuperSystemAdmin = 1,
            SystemAdmin = 2,
            NewsPermission = 3,
            SettingPermission = 4,
            UsersPermission = 5
        }

        public static class FileCateguery
        {
            public static string Projects = "projects";
            public static string ProjectTypes = "projectTypes";
            public static string News = "news";
            public static string Posters = "posters";
        }
    }
}
