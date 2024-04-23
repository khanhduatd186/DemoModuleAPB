using DemoModule.Samples;
using Xunit;

namespace DemoModule.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<DemoModuleMongoDbTestModule>
{

}
