// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Contains the tables, columns &amp; rows resulting from a query. </summary>
    public partial class LogsBatchQueryResult : LogsQueryResult
    {
        /// <summary> Initializes a new instance of LogsBatchQueryResult. </summary>
        /// <param name="allTables"> The list of tables, columns and rows. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allTables"/> is null. </exception>
        internal LogsBatchQueryResult(IEnumerable<LogsQueryResultTable> allTables) : base(allTables)
        {
            if (allTables == null)
            {
                throw new ArgumentNullException(nameof(allTables));
            }
        }

        /// <summary> Initializes a new instance of LogsBatchQueryResult. </summary>
        /// <param name="allTables"> The list of tables, columns and rows. </param>
        /// <param name="Statistics"> Any object. </param>
        /// <param name="Visualization"> Any object. </param>
        /// <param name="Error"> Any object. </param>
        internal LogsBatchQueryResult(IReadOnlyList<LogsQueryResultTable> allTables, JsonElement Statistics, JsonElement Visualization, JsonElement Error) : base(allTables, Statistics, Visualization, Error)
        {
        }
    }
}
