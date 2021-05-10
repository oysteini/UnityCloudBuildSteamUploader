using Newtonsoft.Json;

namespace BuildUploader.Console
{
    internal class AppStoreSettings
    {
        [JsonProperty("user")]
        public string UserId { get; internal set; }

        [JsonProperty("app_password")]
        public string AppSpecificPassword { get; internal set; }
    }
}
