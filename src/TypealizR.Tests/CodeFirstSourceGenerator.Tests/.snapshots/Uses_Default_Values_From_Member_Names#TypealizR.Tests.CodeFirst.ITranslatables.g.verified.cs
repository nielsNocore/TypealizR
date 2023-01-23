﻿//HintName: TypealizR.Tests.CodeFirst.ITranslatables.g.cs
// <auto-generated/>
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Localization;
namespace TypealizR.Tests.CodeFirst {
    [GeneratedCode("TypealizR.CodeFirstSourceGenerator", "1.0.0.0")]
    public partial class Translatables: ITranslatables {
        private readonly IStringLocalizer<ITranslatables> localizer;
        public Translatables (IStringLocalizer<ITranslatables> localizer) {
            this.localizer = localizer;
        }
        public LocalizedString Hello (string world) => localizer[@"Hello {0}", world];
        public LocalizedString Hello (string user, string world, int visitCount, bool dontPanic) => localizer[@"Hello {0} {1} {2} {3}", user, world, visitCount, dontPanic];
        public LocalizedString Greeting => localizer[@"Greeting"];
    }
}