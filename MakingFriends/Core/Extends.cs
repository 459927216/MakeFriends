namespace Core
{
    public static class Extends
    {
        public static bool IsNull(this string values)
        {
            return string.IsNullOrWhiteSpace(values);
        }
    }
}
