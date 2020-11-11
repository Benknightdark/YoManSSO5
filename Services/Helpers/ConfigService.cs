using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OAthLib.Models.FB;
using OAthLib.Models.Google;
using OAthLib.Models.Line;
using OAthLib.Models.LinkedIn;
using OAthLib.Models.MS;

namespace OAthLib.Services.Helpers {
    public class ConfigService {
        public IConfiguration configuration { get; }

        public ConfigService (IConfiguration configuration) {
            this.configuration = configuration;

        }
        public LineConfig GetLineConfig () {
            var appConfig = System.Text.Json.JsonSerializer.Deserialize<LineConfig> (configuration.GetSection ("Line").Value);
            return appConfig;

        }
        public FBConfig GetFBConfig () {

            var appConfig = System.Text.Json.JsonSerializer.Deserialize<FBConfig> (configuration.GetSection ("FB").Value);
            return appConfig;
        }
        public GoogleConfig GetGoogleConfig () {
            var appConfig = System.Text.Json.JsonSerializer.Deserialize<GoogleConfig> (configuration.GetSection ("Google").Value);
            return appConfig;
            
        }
        public LinkedInConfig GetLinkedInConfig () {
            

             var appConfig = System.Text.Json.JsonSerializer.Deserialize<LinkedInConfig> (configuration.GetSection ("LinkedIn").Value);
            return appConfig;
        }
        public MSConfig GetMSConfig () {
             var appConfig = System.Text.Json.JsonSerializer.Deserialize<MSConfig> (configuration.GetSection ("MS").Value);
            return appConfig;
        }
    }
}