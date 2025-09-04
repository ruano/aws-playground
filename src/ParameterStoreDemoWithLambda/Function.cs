using Amazon.Lambda.Core;
using Amazon.Lambda.RuntimeSupport;
using Amazon.Lambda.Serialization.SystemTextJson;
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

// The function handler that will be called for each Lambda event
var handler = async (string input, ILambdaContext context) =>
{
    var client = new AmazonSimpleSystemsManagementClient();

    var request = new GetParameterRequest
    {
        Name = "/SampleApp/ConnectionStrings/MyConnection",
        WithDecryption = true
    };

    GetParameterResponse response = await client.GetParameterAsync(request);

    return string.Format("Decrypted Value: {0}", response.Parameter.Value);
};

// Build the Lambda runtime client passing in the handler to call for each
// event and the JSON serializer to use for translating Lambda JSON documents
// to .NET types.
await LambdaBootstrapBuilder.Create(handler, new DefaultLambdaJsonSerializer())
        .Build()
        .RunAsync();