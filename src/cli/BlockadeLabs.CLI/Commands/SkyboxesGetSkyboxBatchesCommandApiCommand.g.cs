#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlockadeLabs.CLI.Commands;

internal static partial class SkyboxesGetSkyboxBatchesCommandApiCommand
{
    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Results per page. 1-100, default 18.",
    };

    private static Option<int?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"Records to skip. Default 0.",
    };

    private static Option<global::BlockadeLabs.GetSkyboxBatchesOrder?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"ASC or DESC. Default DESC.",
    };

    private static Option<global::BlockadeLabs.GetSkyboxBatchesStatus?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter by batch status.",
    };

    private static Option<int?> BatchId { get; } = new(
        name: @"--batch-id")
    {
        Description = @"Filter to one batch id.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::BlockadeLabs.GetSkyboxBatchesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BlockadeLabs.GetSkyboxBatchesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-skybox-batches", @"Get Skybox Batches
Paginated list of batch requests for the account.");
                        command.Options.Add(Limit);
                        command.Options.Add(Offset);
                        command.Options.Add(Order);
                        command.Options.Add(Status);
                        command.Options.Add(BatchId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var limit = parseResult.GetValue(Limit);
                        var offset = parseResult.GetValue(Offset);
                        var order = parseResult.GetValue(Order);
                        var status = parseResult.GetValue(Status);
                        var batchId = parseResult.GetValue(BatchId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Skyboxes.GetSkyboxBatchesAsync(
                                    limit: limit,
                                    offset: offset,
                                    order: order,
                                    status: status,
                                    batchId: batchId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::BlockadeLabs.SourceGenerationContext.Default,
                                        @"Data",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::BlockadeLabs.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}