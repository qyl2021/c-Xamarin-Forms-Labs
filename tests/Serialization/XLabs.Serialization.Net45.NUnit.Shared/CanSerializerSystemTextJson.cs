#if __ANDROID__ || WINDOWS_PHONE
#if WINDOWS_PHONE
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using TestFixture = Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestClassAttribute;
using Test = Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestMethodAttribute;
#else
using Newtonsoft.Json;
using NUnit.Framework;
using JsonSerializer = XLabs.Serialization.JsonNET.JsonSerializer;

#endif

namespace SerializationTests
{
    using XLabs.Serialization;

    public class CanSerializerSystemTextJson : CanSerializerTests
    {
#region Overrides of CanSerializerTests

        protected override ISerializer Serializer
        {
            get
            {
                return new JsonSerializer(new JsonSerializerSettings());
            }
        }

#endregion
    }
}
#endif