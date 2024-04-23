using DemoModule.MongoDB;
using DemoModule.Samples;
using Xunit;

namespace DemoModule.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<DemoModuleMongoDbTestModule>
{

}
