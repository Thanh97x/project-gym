using Demotht.Debugging;

namespace Demotht
{
    public class DemothtConsts
    {
        public const string LocalizationSourceName = "Demotht";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "c2a04e289cbc43ac9047abb2c7fc98d7";
    }
}
