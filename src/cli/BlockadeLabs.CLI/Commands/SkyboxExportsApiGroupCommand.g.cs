#nullable enable

using System.CommandLine;

namespace BlockadeLabs.CLI.Commands;

internal static class SkyboxExportsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"skybox-exports", @"Skybox Exports endpoint commands.");
                         command.Subcommands.Add(SkyboxExportsCancelExportRequestCommandApiCommand.Create());
                         command.Subcommands.Add(SkyboxExportsGetExportRequestCommandApiCommand.Create());
                         command.Subcommands.Add(SkyboxExportsGetExportTypesCommandApiCommand.Create());
                         command.Subcommands.Add(SkyboxExportsRequestExportCommandApiCommand.Create());
        return command;
    }
}