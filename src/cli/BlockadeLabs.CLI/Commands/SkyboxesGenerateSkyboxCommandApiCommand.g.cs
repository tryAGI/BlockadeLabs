#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlockadeLabs.CLI.Commands;

internal static partial class SkyboxesGenerateSkyboxCommandApiCommand
{
    private static Option<int> SkyboxStyleId { get; } = new(
        name: @"--skybox-style-id")
    {
        Description = @"Style id from Get Skybox Styles. Chooses the model version and the aesthetic. Required.",
        Required = true,
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Text prompt describing the skybox world you wish to create. Maximum number of characters: 2000, or the max-char value returned for the chosen style.",
        Required = true,
    };

    private static Option<string?> NegativeText { get; } = new(
        name: @"--negative-text")
    {
        Description = @"Things to avoid. Maximum number of characters: 600, or the negative-text-max-char value returned for the chosen style.",
    };

    private static Option<bool?> EnhancePrompt { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enhance-prompt",
        description: @"Have an AI automatically improve the prompt (default: false).");

    private static Option<int?> HorizonShift { get; } = new(
        name: @"--horizon-shift")
    {
        Description = @"Model 4 only. Not used for Model 3 generations. Defaults to 0. Negative shifts the horizon down, positive shifts it up. Accepted range: -20 to 20.",
    };

    private static Option<int?> VariantId { get; } = new(
        name: @"--variant-id")
    {
        Description = @"Model 4 quality variant from the variants array on Get Skybox Styles. 1 is Balance (3 credits, about 60s). 2 is Detail (6 credits, about 120s). If omitted, the style default is used. Required for Model 4 batches. Model 4 variants require a Standard or Business plan.",
    };

    private static Option<bool?> SoftLines { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--soft-lines",
        description: @"Model 4 only. Softer line rendering while preserving structural geometry. Default: false.");

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"Send 0 for a random seed. Any other number freezes the generator for a similar result with the same settings. Model 3 accepts 1-2147483647. Model 4 accepts 1-4294967295.",
    };

    private static Option<string?> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"Optional URL for generation progress updates.",
    };

    private static Option<int?> MaxWait { get; } = new(
        name: @"--max-wait")
    {
        Description = @"Maximum seconds to wait for the generation. If it does not finish in time, status is set to error and credits are refunded. Accepted range: 30-1800. Model 3 and Model 4.",
    };

    private static Option<int?> RemixImagineId { get; } = new(
        name: @"--remix-imagine-id")
    {
        Description = @"Model 3. ID of a previously generated skybox to remix.",
    };

    private static Option<int?> RemixCollectionId { get; } = new(
        name: @"--remix-collection-id")
    {
        Description = @"Model 3. ID of a project created in the web app. A random skybox from that project is used as the remix starting point.",
    };

    private static Option<byte[]?> ControlImage { get; } = new(
        name: @"--control-image")
    {
        Description = @"Model 3. Control image (binary, Base64, or absolute URL) that influences structure. Use with control_model set to remix.",
    };

    private static Option<string?> ControlImagename { get; } = new(
        name: @"--control-imagename")
    {
        Description = @"Model 3. Control image (binary, Base64, or absolute URL) that influences structure. Use with control_model set to remix.",
    };

    private static Option<string?> ControlImageHash { get; } = new(
        name: @"--control-image-hash")
    {
        Description = @"Model 3. obfuscated_id of an existing skybox whose control image should be reused, instead of uploading control_image again.",
    };

    private static Option<string?> ControlModel { get; } = new(
        name: @"--control-model")
    {
        Description = @"Model 3. Model used for control_image. The only option is ""remix"".",
    };

    private static Option<byte[]?> InitImage { get; } = new(
        name: @"--init-image")
    {
        Description = @"Model 3. Init image (binary, Base64, or absolute URL). Equirectangular images. Guides color and composition.",
    };

    private static Option<string?> InitImagename { get; } = new(
        name: @"--init-imagename")
    {
        Description = @"Model 3. Init image (binary, Base64, or absolute URL). Equirectangular images. Guides color and composition.",
    };

    private static Option<string?> InitImageHash { get; } = new(
        name: @"--init-image-hash")
    {
        Description = @"Model 3. obfuscated_id of an existing skybox whose init image should be reused, instead of uploading init_image again.",
    };

    private static Option<double?> InitStrength { get; } = new(
        name: @"--init-strength")
    {
        Description = @"Model 3. Inverted influence of init_image. 0.11 is lots of influence, 0.9 is no influence. Only applies when init_image is sent.",
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

                    private static string FormatResponse(ParseResult parseResult, global::BlockadeLabs.GenerateSkyboxResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BlockadeLabs.GenerateSkyboxResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"generate-skybox", @"Generate Skybox
Generate a Model 3 or Model 4 skybox on the same endpoint. Send application/json, or multipart/form-data when uploading an image. Model 4 styles and variant_id require a Standard or Business plan (Essential and Free receive 403). Remix, control, and init parameters are documented for Model 3. Model 2 is discontinued.");
                        command.Options.Add(SkyboxStyleId);
                        command.Options.Add(Prompt);
                        command.Options.Add(NegativeText);
                        command.Options.Add(EnhancePrompt);
                        command.Options.Add(HorizonShift);
                        command.Options.Add(VariantId);
                        command.Options.Add(SoftLines);
                        command.Options.Add(Seed);
                        command.Options.Add(WebhookUrl);
                        command.Options.Add(MaxWait);
                        command.Options.Add(RemixImagineId);
                        command.Options.Add(RemixCollectionId);
                        command.Options.Add(ControlImage);
                        command.Options.Add(ControlImagename);
                        command.Options.Add(ControlImageHash);
                        command.Options.Add(ControlModel);
                        command.Options.Add(InitImage);
                        command.Options.Add(InitImagename);
                        command.Options.Add(InitImageHash);
                        command.Options.Add(InitStrength);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlockadeLabs.GenerateSkyboxRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlockadeLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var skyboxStyleId = parseResult.GetRequiredValue(SkyboxStyleId);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var negativeText = CliRuntime.WasSpecified(parseResult, NegativeText) ? parseResult.GetValue(NegativeText) : (__requestBase is { } __NegativeTextBaseValue ? __NegativeTextBaseValue.NegativeText : default);
                        var enhancePrompt = CliRuntime.WasSpecified(parseResult, EnhancePrompt) ? parseResult.GetValue(EnhancePrompt) : (__requestBase is { } __EnhancePromptBaseValue ? __EnhancePromptBaseValue.EnhancePrompt : default);
                        var horizonShift = CliRuntime.WasSpecified(parseResult, HorizonShift) ? parseResult.GetValue(HorizonShift) : (__requestBase is { } __HorizonShiftBaseValue ? __HorizonShiftBaseValue.HorizonShift : default);
                        var variantId = CliRuntime.WasSpecified(parseResult, VariantId) ? parseResult.GetValue(VariantId) : (__requestBase is { } __VariantIdBaseValue ? __VariantIdBaseValue.VariantId : default);
                        var softLines = CliRuntime.WasSpecified(parseResult, SoftLines) ? parseResult.GetValue(SoftLines) : (__requestBase is { } __SoftLinesBaseValue ? __SoftLinesBaseValue.SoftLines : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                        var maxWait = CliRuntime.WasSpecified(parseResult, MaxWait) ? parseResult.GetValue(MaxWait) : (__requestBase is { } __MaxWaitBaseValue ? __MaxWaitBaseValue.MaxWait : default);
                        var remixImagineId = CliRuntime.WasSpecified(parseResult, RemixImagineId) ? parseResult.GetValue(RemixImagineId) : (__requestBase is { } __RemixImagineIdBaseValue ? __RemixImagineIdBaseValue.RemixImagineId : default);
                        var remixCollectionId = CliRuntime.WasSpecified(parseResult, RemixCollectionId) ? parseResult.GetValue(RemixCollectionId) : (__requestBase is { } __RemixCollectionIdBaseValue ? __RemixCollectionIdBaseValue.RemixCollectionId : default);
                        var controlImage = CliRuntime.WasSpecified(parseResult, ControlImage) ? parseResult.GetValue(ControlImage) : (__requestBase is { } __ControlImageBaseValue ? __ControlImageBaseValue.ControlImage : default);
                        var controlImagename = CliRuntime.WasSpecified(parseResult, ControlImagename) ? parseResult.GetValue(ControlImagename) : (__requestBase is { } __ControlImagenameBaseValue ? __ControlImagenameBaseValue.ControlImagename : default);
                        var controlImageHash = CliRuntime.WasSpecified(parseResult, ControlImageHash) ? parseResult.GetValue(ControlImageHash) : (__requestBase is { } __ControlImageHashBaseValue ? __ControlImageHashBaseValue.ControlImageHash : default);
                        var controlModel = CliRuntime.WasSpecified(parseResult, ControlModel) ? parseResult.GetValue(ControlModel) : (__requestBase is { } __ControlModelBaseValue ? __ControlModelBaseValue.ControlModel : default);
                        var initImage = CliRuntime.WasSpecified(parseResult, InitImage) ? parseResult.GetValue(InitImage) : (__requestBase is { } __InitImageBaseValue ? __InitImageBaseValue.InitImage : default);
                        var initImagename = CliRuntime.WasSpecified(parseResult, InitImagename) ? parseResult.GetValue(InitImagename) : (__requestBase is { } __InitImagenameBaseValue ? __InitImagenameBaseValue.InitImagename : default);
                        var initImageHash = CliRuntime.WasSpecified(parseResult, InitImageHash) ? parseResult.GetValue(InitImageHash) : (__requestBase is { } __InitImageHashBaseValue ? __InitImageHashBaseValue.InitImageHash : default);
                        var initStrength = CliRuntime.WasSpecified(parseResult, InitStrength) ? parseResult.GetValue(InitStrength) : (__requestBase is { } __InitStrengthBaseValue ? __InitStrengthBaseValue.InitStrength : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Skyboxes.GenerateSkyboxAsync(
                                    skyboxStyleId: skyboxStyleId,
                                    prompt: prompt,
                                    negativeText: negativeText,
                                    enhancePrompt: enhancePrompt,
                                    horizonShift: horizonShift,
                                    variantId: variantId,
                                    softLines: softLines,
                                    seed: seed,
                                    webhookUrl: webhookUrl,
                                    maxWait: maxWait,
                                    remixImagineId: remixImagineId,
                                    remixCollectionId: remixCollectionId,
                                    controlImage: controlImage,
                                    controlImagename: controlImagename,
                                    controlImageHash: controlImageHash,
                                    controlModel: controlModel,
                                    initImage: initImage,
                                    initImagename: initImagename,
                                    initImageHash: initImageHash,
                                    initStrength: initStrength,
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