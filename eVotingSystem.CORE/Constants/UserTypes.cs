namespace eVotingSystem.CORE.Constants
{
    public enum UserTypes
    {
        Person = 1,
        Administrator,
        Supervisor
    }

    public static partial class UserTypesExtensions
    {
        public static string ToStringBH(this UserTypes userType)
        {
            if (userType == UserTypes.Administrator) return "Administrator";
            if (userType == UserTypes.Person) return "Glasač";
            if (userType == UserTypes.Supervisor) return "Supervizor";

            return "";
        }
    }
}
