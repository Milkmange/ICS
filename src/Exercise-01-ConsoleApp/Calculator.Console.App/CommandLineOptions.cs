﻿using System.Diagnostics.CodeAnalysis;
using Calculator.Utils;
using CommandLine;

namespace Calculator.App;

/// <summary>
///     CommandLine parser settings
///     https://commandline.codeplex.com/
/// </summary>
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
internal class CommandLineOptions
{
    [Option('f', "first", Required = false, HelpText = "The first operand.")]
    public int? First { get; set; }

    [Option('o', "operation", Required = true, HelpText = "The operation.")]
    public MathOperation Operation { get; set; }

    [Option('s', "second", Required = false, HelpText = "The second operand.")]
    public int? Second { get; set; }

    [Option('v', "verbose", Default = false, HelpText = "Prints all messages to standard output.")]
    public bool Verbose { get; set; }
}
