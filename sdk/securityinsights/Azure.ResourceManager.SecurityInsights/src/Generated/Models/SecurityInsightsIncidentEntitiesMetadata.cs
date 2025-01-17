// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Information of a specific aggregation in the incident related entities result. </summary>
    public partial class SecurityInsightsIncidentEntitiesMetadata
    {
        /// <summary> Initializes a new instance of SecurityInsightsIncidentEntitiesMetadata. </summary>
        /// <param name="count"> Total number of aggregations of the given kind in the incident related entities result. </param>
        /// <param name="entityKind"> The kind of the aggregated entity. </param>
        internal SecurityInsightsIncidentEntitiesMetadata(int count, SecurityInsightsEntityKind entityKind)
        {
            Count = count;
            EntityKind = entityKind;
        }

        /// <summary> Total number of aggregations of the given kind in the incident related entities result. </summary>
        public int Count { get; }
        /// <summary> The kind of the aggregated entity. </summary>
        public SecurityInsightsEntityKind EntityKind { get; }
    }
}
