#nullable enable

using System.CommandLine;

namespace BlockadeLabs.CLI.Commands;

internal static class SkyboxesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"skyboxes", @"Skyboxes endpoint commands.");
                         command.Subcommands.Add(SkyboxesCancelAllPendingGenerationsCommandApiCommand.Create());
                         command.Subcommands.Add(SkyboxesCancelGenerationCommandApiCommand.Create());
                         command.Subcommands.Add(SkyboxesDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(SkyboxesGenerateSkyboxCommandApiCommand.Create());
                         command.Subcommands.Add(SkyboxesGetHistoryCommandApiCommand.Create());
                         command.Subcommands.Add(SkyboxesGetSkyboxByIdCommandApiCommand.Create());
                         command.Subcommands.Add(SkyboxesGetSkyboxByObfuscatedIdCommandApiCommand.Create());
                         command.Subcommands.Add(SkyboxesGetSkyboxStyleFamiliesCommandApiCommand.Create());
                         command.Subcommands.Add(SkyboxesGetSkyboxStylesCommandApiCommand.Create());
        return command;
    }
}