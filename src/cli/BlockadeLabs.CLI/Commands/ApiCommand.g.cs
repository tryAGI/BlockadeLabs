#nullable enable

using System.CommandLine;

namespace BlockadeLabs.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(SkyboxExportsApiGroupCommand.Create());
                         command.Subcommands.Add(SkyboxesApiGroupCommand.Create());
        return command;
    }
}