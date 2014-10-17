﻿// Copyright (c) Microsoft Open Technologies, Inc.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.Host.Mef
{
    /// <summary>
    /// The layer of an exported service.  
    /// 
    /// If there are multiple definitions of a service, the <see cref="ServiceLayer"/> is used to determine which is used.
    /// 
    /// Deskktop overrides Default
    /// Editor overrides Desktop and Default
    /// Host overrides Editor, Desktop and Default
    /// </summary>
    public static class ServiceLayer
    {
        public const string Host = "Host";
        public const string Editor = "Editor";
        public const string Desktop = "Desktop";
        public const string Default = "Default";
    }
}