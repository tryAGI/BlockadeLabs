#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlockadeLabs.CLI.Commands;

internal static partial class SkyboxesGetHistoryCommandApiCommand
{
    private static Option<string?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter by status. Options: all, pending, dispatched, processing, complete, abort, error (default: all)",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of items to be returned per page (default: 18, max-value: 100)",
    };

    private static Option<int?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"Page number (default: 0)",
    };

    private static Option<string?> Order { get; } = new(
        name: @"--order")
    {
        Description = @"Sort order. Options: ASC, DESC (default: DESC)",
    };

    private static Option<int?> ImagineId { get; } = new(
        name: @"--imagine-id")
    {
        Description = @"Filter by skybox ID",
    };

    private static Option<string?> Query { get; } = new(
        name: @"--query")
    {
        Description = @"Filter by title or prompt",
    };

    private static Option<string?> Generator { get; } = new(
        name: @"--generator")
    {
        Description = @"Filter by generator",
    };

                    private static string FormatResponse(ParseResult parseResult, global::BlockadeLabs.GetHistoryResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BlockadeLabs.GetHistoryResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-history", @"Get History");
                        command.Options.Add(Status);
                        command.Options.Add(Limit);
                        command.Options.Add(Offset);
                        command.Options.Add(Order);
                        command.Options.Add(ImagineId);
                        command.Options.Add(Query);
                        command.Options.Add(Generator);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var status = parseResult.GetValue(Status);
                        var limit = parseResult.GetValue(Limit);
                        var offset = parseResult.GetValue(Offset);
                        var order = parseResult.GetValue(Order);
                        var imagineId = parseResult.GetValue(ImagineId);
                        var query = parseResult.GetValue(Query);
                        var generator = parseResult.GetValue(Generator);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Skyboxes.GetHistoryAsync(
                                    status: status,
                                    limit: limit,
                                    offset: offset,
                                    order: order,
                                    imagineId: imagineId,
                                    query: query,
                                    generator: generator,
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
        return command;
    }
}