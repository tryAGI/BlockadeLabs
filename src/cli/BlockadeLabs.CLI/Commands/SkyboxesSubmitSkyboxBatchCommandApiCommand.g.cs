#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlockadeLabs.CLI.Commands;

internal static partial class SkyboxesSubmitSkyboxBatchCommandApiCommand
{
    private static Option<int> Quantity { get; } = new(
        name: @"--quantity")
    {
        Description = @"Number of skyboxes to generate. Required. Total credit cost is quantity times credits per generation, and must fit the plan batch cap and the account balance.",
        Required = true,
    };

    private static Option<int> SkyboxStyleId { get; } = new(
        name: @"--skybox-style-id")
    {
        Description = @"Style id from Get Skybox Styles. Required.",
        Required = true,
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Text prompt. Maximum 2000 characters, or the style max-char.",
        Required = true,
    };

    private static Option<string?> NegativeText { get; } = new(
        name: @"--negative-text")
    {
        Description = @"Things to avoid. Maximum 600 characters, or the style negative-text-max-char.",
    };

    private static Option<bool?> EnhancePrompt { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enhance-prompt",
        description: @"Automatically improve the prompt. Default: false.");

    private static Option<int?> HorizonShift { get; } = new(
        name: @"--horizon-shift")
    {
        Description = @"Model 4 only. Not used for Model 3 generations. Default 0. Range -20 to 20.",
    };

    private static Option<int?> VariantId { get; } = new(
        name: @"--variant-id")
    {
        Description = @"Required for Model 4 batches. 1 is Balance, 2 is Detail, or another id from the style variants array.",
    };

    private static Option<bool?> SoftLines { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--soft-lines",
        description: @"Model 4 only. Default: false.");

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"0 for a random seed. Model 3 accepts 1-2147483647. Model 4 accepts 1-4294967295.",
    };

    private static Option<int?> MaxWait { get; } = new(
        name: @"--max-wait")
    {
        Description = @"Per-generation wait limit in seconds. Range 30-1800.",
    };

    private static Option<string?> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"Optional URL for batch-level status updates. The payload matches the batch object.",
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

                    private static string FormatResponse(ParseResult parseResult, global::BlockadeLabs.SubmitSkyboxBatchResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BlockadeLabs.SubmitSkyboxBatchResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"submit-skybox-batch", @"Submit Skybox Batch
Queue multiple skyboxes in one request. Accepts the same parameters as Generate Skybox, plus quantity. Essential and Standard allow batches up to 3 credits. Business allows up to 30. Free cannot use batches. Model 4 batches also require a Standard or Business plan and variant_id. Only one batch can be in progress per account (409).");
                        command.Options.Add(Quantity);
                        command.Options.Add(SkyboxStyleId);
                        command.Options.Add(Prompt);
                        command.Options.Add(NegativeText);
                        command.Options.Add(EnhancePrompt);
                        command.Options.Add(HorizonShift);
                        command.Options.Add(VariantId);
                        command.Options.Add(SoftLines);
                        command.Options.Add(Seed);
                        command.Options.Add(MaxWait);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlockadeLabs.SubmitSkyboxBatchRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlockadeLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var quantity = parseResult.GetRequiredValue(Quantity);
                        var skyboxStyleId = parseResult.GetRequiredValue(SkyboxStyleId);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var negativeText = CliRuntime.WasSpecified(parseResult, NegativeText) ? parseResult.GetValue(NegativeText) : (__requestBase is { } __NegativeTextBaseValue ? __NegativeTextBaseValue.NegativeText : default);
                        var enhancePrompt = CliRuntime.WasSpecified(parseResult, EnhancePrompt) ? parseResult.GetValue(EnhancePrompt) : (__requestBase is { } __EnhancePromptBaseValue ? __EnhancePromptBaseValue.EnhancePrompt : default);
                        var horizonShift = CliRuntime.WasSpecified(parseResult, HorizonShift) ? parseResult.GetValue(HorizonShift) : (__requestBase is { } __HorizonShiftBaseValue ? __HorizonShiftBaseValue.HorizonShift : default);
                        var variantId = CliRuntime.WasSpecified(parseResult, VariantId) ? parseResult.GetValue(VariantId) : (__requestBase is { } __VariantIdBaseValue ? __VariantIdBaseValue.VariantId : default);
                        var softLines = CliRuntime.WasSpecified(parseResult, SoftLines) ? parseResult.GetValue(SoftLines) : (__requestBase is { } __SoftLinesBaseValue ? __SoftLinesBaseValue.SoftLines : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var maxWait = CliRuntime.WasSpecified(parseResult, MaxWait) ? parseResult.GetValue(MaxWait) : (__requestBase is { } __MaxWaitBaseValue ? __MaxWaitBaseValue.MaxWait : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Skyboxes.SubmitSkyboxBatchAsync(
                                    quantity: quantity,
                                    skyboxStyleId: skyboxStyleId,
                                    prompt: prompt,
                                    negativeText: negativeText,
                                    enhancePrompt: enhancePrompt,
                                    horizonShift: horizonShift,
                                    variantId: variantId,
                                    softLines: softLines,
                                    seed: seed,
                                    maxWait: maxWait,
                                    webhookUrl: webhookUrl,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::BlockadeLabs.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}