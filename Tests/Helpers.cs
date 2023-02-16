namespace Tests
{
    public static class Helpers
    {
        public static DerivedType? GetInstance<DerivedType>(string classTypeFullName, params object?[]? args)
        {
            Type type = Type.GetType(classTypeFullName);

            if (type != null)
            {
                return (DerivedType?)Activator.CreateInstance(type);
            }

            // Check other assemblies
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = asm.GetType(classTypeFullName);

                if (type != null &&
                    typeof(DerivedType).IsAssignableFrom(type))
                {
                    return (DerivedType?)Activator.CreateInstance(type, args);
                }
            }

            return default(DerivedType);
        }
    }
}
