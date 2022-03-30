﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Core
{
    /// <summary>
    /// An attribute class indicating a reference type which can replace a type in target RPs.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    internal class TypeReferenceTypeAttribute : Attribute
    {
        public TypeReferenceTypeAttribute(bool ignoreExtraProperties, string[] internalPropertiesToInclude)
        {
            IgnoreExtraProperties = ignoreExtraProperties;
            InternalPropertiesToInclude = internalPropertiesToInclude;
        }

        public bool IgnoreExtraProperties { get; }
        public string[] InternalPropertiesToInclude { get; }
    }
}
