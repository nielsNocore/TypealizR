﻿//HintName: Some.Root.Namespace.Groupings_NoCode_WithDuplicates.Typealized.g.cs
// <auto-generated/>
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Localization;
using Some.Root.Namespace;
namespace Some.Root.Namespace.TypealizR
{
    [GeneratedCode("TypealizR.TypealizedClassSourceGenerator", "1.0.0.0")]
    /// <summary>
    /// Wraps a <see cref="IStringLocalizer{T}"/> and provides properties for typed-access to resources, generated by TypealizR
    /// </summary>
    internal partial class TypealizedGroupings_NoCode_WithDuplicates
    {
        private readonly IStringLocalizer<global::Some.Root.Namespace.Groupings_NoCode_WithDuplicates> localizer;
        /// <summary>
        /// Creates a new instance of <see cref="TypealizedGroupings_NoCode_WithDuplicates"/>
        /// </summary>
        public TypealizedGroupings_NoCode_WithDuplicates(IStringLocalizer<global::Some.Root.Namespace.Groupings_NoCode_WithDuplicates> localizer)
        {
            this.localizer = localizer;
            Log = new LogGroup(localizer);
        }
        public LogGroup Log { get; }
        [GeneratedCode("TypealizR.TypealizedClassSourceGenerator", "1.0.0.0")]
        internal partial class LogGroup
        {
            private readonly IStringLocalizer<global::Some.Root.Namespace.Groupings_NoCode_WithDuplicates> localizer;
            [DebuggerStepThrough]
            public LogGroup(IStringLocalizer<global::Some.Root.Namespace.Groupings_NoCode_WithDuplicates> localizer)
            {
                this.localizer = localizer;
                Warning = new WarningGroup(localizer);
            }
            public WarningGroup Warning { get; }
            [GeneratedCode("TypealizR.TypealizedClassSourceGenerator", "1.0.0.0")]
            internal partial class WarningGroup
            {
                private readonly IStringLocalizer<global::Some.Root.Namespace.Groupings_NoCode_WithDuplicates> localizer;
                [DebuggerStepThrough]
                public WarningGroup(IStringLocalizer<global::Some.Root.Namespace.Groupings_NoCode_WithDuplicates> localizer)
                {
                    this.localizer = localizer;
                }
        /// <summary>
        /// Looks up a localized string similar to '[Log.Warning]: Could not find {UserName:s}'
        /// </summary>
        /// <returns>
        /// A localized version of the current default value of 'Could not find {0}'
        /// </returns>
        public LocalizedString Could_not_find__UserName(string UserName)
            => localizer["[Log.Warning]: Could not find {UserName:s}"].Format(UserName);
        /// <summary>
        /// Looks up a localized string similar to '[Log.Warning]: Could not find {UserName:s}!'
        /// </summary>
        /// <returns>
        /// A localized version of the current default value of 'Could not find {0}!'
        /// </returns>
        public LocalizedString Could_not_find__UserName1(string UserName)
            => localizer["[Log.Warning]: Could not find {UserName:s}!"].Format(UserName);
        /// <summary>
        /// Looks up a localized string similar to '[Log.Warning]: Unknown error'
        /// </summary>
        /// <returns>
        /// A localized version of the current default value of 'Encountered an unknown error during the operation'
        /// </returns>
        public LocalizedString Unknown_error
            => localizer["[Log.Warning]: Unknown error"];
        /// <summary>
        /// Looks up a localized string similar to '[Log.Warning]: Unknown error!'
        /// </summary>
        /// <returns>
        /// A localized version of the current default value of 'Encountered an unknown error during the operation!'
        /// </returns>
        public LocalizedString Unknown_error1
            => localizer["[Log.Warning]: Unknown error!"];
            }
        }
        /// <summary>
        /// Gets the string resource with the given name.
        /// </summary>
        /// <param name="name">The name of the string resource.</param>
        /// <returns>The string resource as a <see cref="LocalizedString"/>.</returns>
        public LocalizedString this[string name] => this.localizer[name];
        /// <summary>
        /// Gets the string resource with the given name and formatted with the supplied arguments.
        /// </summary>
        /// <param name="name">The name of the string resource.</param>
        /// <param name="arguments">The values to format the string with.</param>
        /// <returns>The formatted string resource as a <see cref="LocalizedString"/>.</returns>
        public LocalizedString this[string name, params object[] arguments] => this.localizer[name, arguments];
        /// <summary>
        /// Gets all string resources.
        /// </summary>
        /// <param name="includeParentCultures">
        /// A <see cref="System.Boolean"/> indicating whether to include strings from parent cultures.
        /// </param>
        /// <returns>The strings.</returns>
        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures) => this.localizer.GetAllStrings(includeParentCultures);
        /// <summary>
        /// The wrapped <see cref="IStringLocalizer{T}"/>
        /// </summary>
        /// <returns>The wrapped <see cref="IStringLocalizer{T}"/>.</returns>
        public IStringLocalizer<global::Some.Root.Namespace.Groupings_NoCode_WithDuplicates> Localizer => this.localizer;
    }
}