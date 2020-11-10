// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> Create or update an Azure Cosmos DB Gremlin graph. </summary>
    public partial class GremlinResourcesCreateUpdateGremlinGraphOperation : Operation<GremlinGraphGetResults>, IOperationSource<GremlinGraphGetResults>
    {
        private readonly ArmOperationHelpers<GremlinGraphGetResults> _operation;
        internal GremlinResourcesCreateUpdateGremlinGraphOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<GremlinGraphGetResults>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "GremlinResourcesCreateUpdateGremlinGraphOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override GremlinGraphGetResults Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<GremlinGraphGetResults>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<GremlinGraphGetResults>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        GremlinGraphGetResults IOperationSource<GremlinGraphGetResults>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return GremlinGraphGetResults.DeserializeGremlinGraphGetResults(document.RootElement);
        }

        async ValueTask<GremlinGraphGetResults> IOperationSource<GremlinGraphGetResults>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return GremlinGraphGetResults.DeserializeGremlinGraphGetResults(document.RootElement);
        }
    }
}
