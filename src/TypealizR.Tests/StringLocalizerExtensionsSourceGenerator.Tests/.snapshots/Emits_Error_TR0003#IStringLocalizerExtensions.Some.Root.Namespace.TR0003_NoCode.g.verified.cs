﻿//HintName: IStringLocalizerExtensions.Some.Root.Namespace.TR0003_NoCode.g.cs
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
    /// <summary>
    /// Extensions for <see cref="Some.Root.Namespace.TR0003_NoCode"/> to utilize typed-access to ressources generated by TypealizR.
    /// </summary>
    internal static partial class IStringLocalizerExtensionsSomeRootNamespaceTR0003_NoCode
    {
        /// <summary>
        /// Looks up a localized string similar to 'Greetings {0}, today is {1}'
        /// </summary>
        /// <returns>
        /// A localized version of the current default value of 'Greetings {0}, today is {1}'
        /// </returns>
        [DebuggerStepThrough]
        public static LocalizedString Greetings__0__today_is__1(this IStringLocalizer<global::Some.Root.Namespace.TR0003_NoCode> that, object _0, object _1)
            => that["Greetings {0}, today is {1}"].Format(_0, _1);
        /// <summary>
        /// Looks up a localized string similar to 'Hello {0}, today is {1}'
        /// </summary>
        /// <returns>
        /// A localized version of the current default value of 'Hello {0}, today is {1}'
        /// </returns>
        [DebuggerStepThrough]
        public static LocalizedString Hello__0__today_is__1(this IStringLocalizer<global::Some.Root.Namespace.TR0003_NoCode> that, object _0, object _1)
            => that["Hello {0}, today is {1}"].Format(_0, _1);
        /// <summary>
        /// wraps the specified <see cref="IStringLocalizerTR0003_NoCode"/> into a generated type providing properties to access [Some.Nested.Group]: via properties
        /// IStringLocalizer{TR0003_NoCode} localize = ...
        /// localize.Some.Nested.Group...
        /// </summary>
        [DebuggerStepThrough]
        public static TypealizedTR0003_NoCode Typealize(this IStringLocalizer<global::Some.Root.Namespace.TR0003_NoCode> that)
            => new TypealizedTR0003_NoCode(that);
    }
}