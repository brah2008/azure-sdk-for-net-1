// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Rewrite rule set of an application gateway. </summary>
    public partial class ApplicationGatewayRewriteRuleSet : NetworkSubResource
    {
        /// <summary> Initializes a new instance of ApplicationGatewayRewriteRuleSet. </summary>
        public ApplicationGatewayRewriteRuleSet()
        {
            RewriteRules = new ChangeTrackingList<ApplicationGatewayRewriteRule>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewayRewriteRuleSet. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the rewrite rule set that is unique within an Application Gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="rewriteRules"> Rewrite rules in the rewrite rule set. </param>
        /// <param name="provisioningState"> The provisioning state of the rewrite rule set resource. </param>
        internal ApplicationGatewayRewriteRuleSet(ResourceIdentifier id, string name, ETag? etag, IList<ApplicationGatewayRewriteRule> rewriteRules, NetworkProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            RewriteRules = rewriteRules;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the rewrite rule set that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? Etag { get; }
        /// <summary> Rewrite rules in the rewrite rule set. </summary>
        public IList<ApplicationGatewayRewriteRule> RewriteRules { get; }
        /// <summary> The provisioning state of the rewrite rule set resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
