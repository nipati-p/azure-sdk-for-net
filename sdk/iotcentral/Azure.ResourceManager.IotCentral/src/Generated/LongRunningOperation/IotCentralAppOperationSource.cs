// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral
{
    internal class IotCentralAppOperationSource : IOperationSource<IotCentralAppResource>
    {
        private readonly ArmClient _client;

        internal IotCentralAppOperationSource(ArmClient client)
        {
            _client = client;
        }

        IotCentralAppResource IOperationSource<IotCentralAppResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = IotCentralAppData.DeserializeIotCentralAppData(document.RootElement);
            return new IotCentralAppResource(_client, data);
        }

        async ValueTask<IotCentralAppResource> IOperationSource<IotCentralAppResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = IotCentralAppData.DeserializeIotCentralAppData(document.RootElement);
            return new IotCentralAppResource(_client, data);
        }
    }
}
