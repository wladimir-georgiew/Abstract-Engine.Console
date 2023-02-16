namespace Tests
{
    public static class Helpers
    {
        public static DerivedType? GetInstance<DerivedType>(string classTypeFullName)
        {
            Type type = Type.GetType(classTypeFullName);

            if (type != null)
            {
                return (DerivedType?)Activator.CreateInstance(type);
            }

            // Check other assemblies
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = assembly.GetType(classTypeFullName);

                if (type != null &&
                    typeof(DerivedType).IsAssignableFrom(type))
                {
                    return (DerivedType?)Activator.CreateInstance(type);
                }
            }

            return default(DerivedType);
        }
    }
}
