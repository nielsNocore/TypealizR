﻿//HintName: IStringLocalizerExtensions.Some.Root.Namespace.TR0005_NoCode.g.cs
// <auto-generated/>
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Some.Root.Namespace;
using Some.Root.Namespace.TypealizR;
namespace Microsoft.Extensions.Localization
{
    [GeneratedCode("TypealizR.StringLocalizerExtensionsSourceGenerator", "1.0.0.0")]
    internal static partial class IStringLocalizerExtensionsSomeRootNamespaceTR0005_NoCode
    {
        /// <summary>
        /// Looks up a localized string similar to 'class {name:s}'
        /// </summary>
        /// <returns>
        /// A localized version of the current default value of 'Greetings {0}'
        /// </returns>
        [DebuggerStepThrough]
        public static LocalizedString _class(this IStringLocalizer<global::Some.Root.Namespace.TR0005_NoCode> that, string name)
            => that["class {name:s}"].Format(name);
        /// <summary>
        /// wraps the specified <see cref="IStringLocalizer&ltSome.Root.Namespace.TR0005_NoCode&gt"/> into a generated type providing properties to access [Some.Nested.Group]: via properties
        /// IStringLocalizer<Some.Root.Namespace.TR0005_NoCode> localize = ...
        /// localize.Some.Nested.Group...
        /// </summary>
        [DebuggerStepThrough]
        public static TypealizedTR0005_NoCode Typealize(this IStringLocalizer<global::Some.Root.Namespace.TR0005_NoCode> that)
            => new TypealizedTR0005_NoCode(that);
    }
}