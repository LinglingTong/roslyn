﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CodeRefactorings;

namespace Microsoft.CodeAnalysis.ExternalAccess.Razor
{
    internal static class CSharpPredefinedCodeRefactoringProviderNames
    {
        public static string AddAwait => PredefinedCodeRefactoringProviderNames.AddAwait;
        public static string GenerateConstructorFromMembers => PredefinedCodeRefactoringProviderNames.GenerateConstructorFromMembers;
        public static string GenerateDefaultConstructors => PredefinedCodeRefactoringProviderNames.GenerateDefaultConstructors;
        public static string GenerateEqualsAndGetHashCodeFromMembers => PredefinedCodeRefactoringProviderNames.GenerateEqualsAndGetHashCodeFromMembers;
        
    }
}
