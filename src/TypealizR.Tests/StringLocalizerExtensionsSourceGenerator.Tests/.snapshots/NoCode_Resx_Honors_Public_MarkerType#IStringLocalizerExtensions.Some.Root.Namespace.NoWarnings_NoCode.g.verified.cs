﻿//HintName: IStringLocalizerExtensions.Some.Root.Namespace.NoWarnings_NoCode.g.cs
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
    public static partial class IStringLocalizerExtensionsSomeRootNamespaceNoWarnings_NoCode
    {
        /// <summary>
        /// Looks up a localized string similar to 'Greetings {name}, today is {date}'
        /// </summary>
        /// <returns>
        /// A localized version of the current default value of 'Greetings {0}, today is {1}'
        /// </returns>
        [DebuggerStepThrough]
        public static LocalizedString Greetings__name__today_is__date(this IStringLocalizer<global::Some.Root.Namespace.NoWarnings_NoCode> that, object name, object date)
            => that["Greetings {name}, today is {date}"].Format(name, date);
        /// <summary>
        /// Looks up a localized string similar to 'Hello'
        /// </summary>
        /// <returns>
        /// A localized version of the current default value of 'Hello'
        /// </returns>
        [DebuggerStepThrough]
        public static LocalizedString Hello(this IStringLocalizer<global::Some.Root.Namespace.NoWarnings_NoCode> that)
            => that["Hello"];
        /// <summary>
        /// Looks up a localized string similar to 'Hello {name:s}, today is {date:d}'
        /// </summary>
        /// <returns>
        /// A localized version of the current default value of 'Hello {0}, today is {1}'
        /// </returns>
        [DebuggerStepThrough]
        public static LocalizedString Hello__name__today_is__date(this IStringLocalizer<global::Some.Root.Namespace.NoWarnings_NoCode> that, string name, DateOnly date)
            => that["Hello {name:s}, today is {date:d}"].Format(name, date);
        /// <summary>
        /// wraps the specified <see cref="IStringLocalizer&ltSome.Root.Namespace.NoWarnings_NoCode&gt"/> into a generated type providing properties to access [Some.Nested.Group]: via properties
        /// IStringLocalizer<Some.Root.Namespace.NoWarnings_NoCode> localize = ...
        /// localize.Some.Nested.Group...
        /// </summary>
        [DebuggerStepThrough]
        public static TypealizedNoWarnings_NoCode Typealize(this IStringLocalizer<global::Some.Root.Namespace.NoWarnings_NoCode> that)
            => new TypealizedNoWarnings_NoCode(that);
    }
}