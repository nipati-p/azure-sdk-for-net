// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    internal class VMwareVmInstanceOperationSource : IOperationSource<VMwareVmInstanceResource>
    {
        private readonly ArmClient _client;

        internal VMwareVmInstanceOperationSource(ArmClient client)
        {
            _client = client;
        }

        VMwareVmInstanceResource IOperationSource<VMwareVmInstanceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VMwareVmInstanceData.DeserializeVMwareVmInstanceData(document.RootElement);
            return new VMwareVmInstanceResource(_client, data);
        }

        async ValueTask<VMwareVmInstanceResource> IOperationSource<VMwareVmInstanceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VMwareVmInstanceData.DeserializeVMwareVmInstanceData(document.RootElement);
            return new VMwareVmInstanceResource(_client, data);
        }
    }
}
