// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Article;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Customer;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Invoice;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.MachineModel;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.MachineType;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Order;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Stock;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Supplier;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Warehouse;
using Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.WarehouseLocation;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration
{
    /// <summary>
    /// Builds and executes requests for operations under \api2\Integration
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IntegrationRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Article property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Article.ArticleRequestBuilder Article
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Article.ArticleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The AssetType property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.AssetTypeRequestBuilder AssetType
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.AssetType.AssetTypeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Customer property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Customer.CustomerRequestBuilder Customer
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Customer.CustomerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Invoice property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Invoice.InvoiceRequestBuilder Invoice
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Invoice.InvoiceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Job property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.JobRequestBuilder Job
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Job.JobRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Machine property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.MachineRequestBuilder Machine
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Machine.MachineRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MachineModel property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.MachineModel.MachineModelRequestBuilder MachineModel
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.MachineModel.MachineModelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MachineType property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.MachineType.MachineTypeRequestBuilder MachineType
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.MachineType.MachineTypeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Order property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Order.OrderRequestBuilder Order
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Order.OrderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Stock property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Stock.StockRequestBuilder Stock
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Stock.StockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Supplier property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Supplier.SupplierRequestBuilder Supplier
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Supplier.SupplierRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Warehouse property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Warehouse.WarehouseRequestBuilder Warehouse
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.Warehouse.WarehouseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The WarehouseLocation property</summary>
        public global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.WarehouseLocation.WarehouseLocationRequestBuilder WarehouseLocation
        {
            get => new global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.WarehouseLocation.WarehouseLocationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.IntegrationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IntegrationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Qwips.ServiceSystem.Integration.ClientSdk.Api2.Integration.IntegrationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IntegrationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618