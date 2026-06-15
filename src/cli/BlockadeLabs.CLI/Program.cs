#nullable enable

using System.CommandLine;
using BlockadeLabs.CLI;
using BlockadeLabs.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the BlockadeLabs SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(SkyboxExportsApiGroupCommand.Create());
rootCommand.Subcommands.Add(SkyboxesApiGroupCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);