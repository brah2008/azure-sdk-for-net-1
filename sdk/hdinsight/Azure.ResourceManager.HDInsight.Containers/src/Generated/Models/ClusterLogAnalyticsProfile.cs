// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster log analytics profile to enable or disable OMS agent for cluster. </summary>
    public partial class ClusterLogAnalyticsProfile
    {
        /// <summary> Initializes a new instance of ClusterLogAnalyticsProfile. </summary>
        /// <param name="isEnabled"> True if log analytics is enabled for the cluster, otherwise false. </param>
        public ClusterLogAnalyticsProfile(bool isEnabled)
        {
            IsEnabled = isEnabled;
        }

        /// <summary> Initializes a new instance of ClusterLogAnalyticsProfile. </summary>
        /// <param name="isEnabled"> True if log analytics is enabled for the cluster, otherwise false. </param>
        /// <param name="applicationLogs"> Collection of logs to be enabled or disabled for log analytics. </param>
        /// <param name="isMetricsEnabled"> True if metrics are enabled, otherwise false. </param>
        internal ClusterLogAnalyticsProfile(bool isEnabled, ClusterLogAnalyticsApplicationLogs applicationLogs, bool? isMetricsEnabled)
        {
            IsEnabled = isEnabled;
            ApplicationLogs = applicationLogs;
            IsMetricsEnabled = isMetricsEnabled;
        }

        /// <summary> True if log analytics is enabled for the cluster, otherwise false. </summary>
        public bool IsEnabled { get; set; }
        /// <summary> Collection of logs to be enabled or disabled for log analytics. </summary>
        public ClusterLogAnalyticsApplicationLogs ApplicationLogs { get; set; }
        /// <summary> True if metrics are enabled, otherwise false. </summary>
        public bool? IsMetricsEnabled { get; set; }
    }
}
