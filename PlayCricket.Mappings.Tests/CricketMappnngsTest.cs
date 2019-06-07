using NUnit.Framework;
using PlayCricket.Mappings;

namespace Tests
{
    public class CricketMappnngsTest
    {

        [Test]
        public void EnsureMappingConfigurationInitialized()
        {
            CricketDataMappings.EnsureInitialised();
            CricketDataMappings.MapperConfig.AssertConfigurationIsValid();
        }
    }
}