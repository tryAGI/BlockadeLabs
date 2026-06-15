#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlockadeLabs.CLI.Commands;

internal static partial class SkyboxExportsRequestExportCommandApiCommand
{
    private static Option<string> SkyboxId { get; } = new(
        name: @"--skybox-id")
    {
        Description = @"Skybox obfuscated_id (needs to have status=complete)",
        Required = true,
    };

    private static Option<int> TypeId { get; } = new(
        name: @"--type-id")
    {
        Description = @"Export type id.",
        Required = true,
    };

    private static Option<string?> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"Optionally, you may specify a webhook url to specify the destination for progress updates.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::BlockadeLabs.RequestExportResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BlockadeLabs.RequestExportResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"request-export", @"Request Export
Process for tracking export progress is identical to tracking skybox generation by using Pusher, Webhook or API Data pooling.

If the export request has already been completed you will immediately get a response with status=complete and file_url in the response.");
                        command.Options.Add(SkyboxId);
                        command.Options.Add(TypeId);
                        command.Options.Add(WebhookUrl);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlockadeLabs.RequestExportRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlockadeLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var skyboxId = parseResult.GetRequiredValue(SkyboxId);
                        var typeId = parseResult.GetRequiredValue(TypeId);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SkyboxExports.RequestExportAsync(
                                    skyboxId: skyboxId,
                                    typeId: typeId,
                                    webhookUrl: webhookUrl,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::BlockadeLabs.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}