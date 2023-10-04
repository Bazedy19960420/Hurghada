namespace Hurghada.Domain.AppMetaData
{
    public class Router
    {
        public const string root = "api";
        public const string v1 = "v1";
        public const string v2 = "v2";
        public const string rule = root + "/" + v1 + "/";

        public static class PropertyRouting
        {
            public const string prefix = rule + "properties";
            public const string GetProperty = prefix + "/{id}";
            public const string GetProperties = prefix + "/" + "List";
            public const string AddProperty = prefix + "/" + "Add";
            public const string EditProperty = prefix + "/" + "Edit";
            public const string DeleteProperty = prefix + "/{id}";

        }
        public static class GuideRouting
        {
            public const string prefix = rule + "guides";
            public const string GetGuide = prefix + "/{id}";
            public const string GetGuides = prefix + "/" + "List";
            public const string AddGuide = prefix + "/" + "Add";
            public const string DeleteGuide = prefix + "/{id}";
            public const string EditGuide = prefix + "/" + "Edit";
        }
    }
}
