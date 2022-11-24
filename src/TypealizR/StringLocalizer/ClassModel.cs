﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Xml;
using Microsoft.CodeAnalysis;

namespace TypealizR.StringLocalizer;

internal class ClassModel
{
    private readonly TypeModel target;
	private readonly string rootNamespace;
	private readonly string members;

    public IEnumerable<MethodModel> Methods { get; }
    public IEnumerable<Diagnostic> Diagnostics { get; }

	public ClassModel(TypeModel target, string rootNamespace, IEnumerable<MethodModel> methods, IEnumerable<Diagnostic> warningsAndErrors)
    {
        this.target = target;
		this.rootNamespace = rootNamespace;
		Methods = methods;
		Diagnostics = warningsAndErrors;
		members = string.Join("\r", methods
            .Select(x => x.Declaration)
            .ToArray()
        );
    }

    public string FileName => $"IStringLocalizerExtensions_{target.FullName}.g.cs";

    public string Body => $@"
// <auto-generated/>
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using {rootNamespace};
using {target.Namespace};
namespace Microsoft.Extensions.Localization {{

    {_.GeneratedCodeAttribute}
    [DebuggerStepThrough]
    internal static partial class IStringLocalizerExtensions_{target.Name}
    {{
    {members}
    }}
}}";

}