#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlockadeLabs.CLI.Commands;

internal static partial class SkyboxesGenerateSkyboxCommandApiCommand
{
    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Text prompt describing the skybox world you wish to create. Maximum number of characters: 550. If you are using skybox_style_id then the maximum number of characters is defined in the max-char response parameter defined for each style.",
        Required = true,
    };

    private static Option<string?> NegativeText { get; } = new(
        name: @"--negative-text")
    {
        Description = @"Describe things to avoid in the skybox world you wish to create. Maximum number of characters: 200. If you are using skybox_style_id then the maximum number of characters is defined in the negative-text-max-char response parameter defined for each style.",
    };

    private static Option<bool?> EnhancePrompt { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enhance-prompt",
        description: @"Have an AI automatically improve your prompt to generate pro-level results every time (default: false)");

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"Send 0 for a random seed generation. Any other number (1-2147483647) set will be used to ""freeze"" the image generator and create similar images when run again with the same seed and settings.",
    };

    private static Option<int?> SkyboxStyleId { get; } = new(
        name: @"--skybox-style-id")
    {
        Description = @"Predefined styles that influence the overall aesthetic of your skybox generation (Fantasy landscape, Anime art style, etc...).",
    };

    private static Option<int?> RemixImagineId { get; } = new(
        name: @"--remix-imagine-id")
    {
        Description = @"ID of a previously generated skybox",
    };

    private static Option<byte[]?> ControlImage { get; } = new(
        name: @"--control-image")
    {
        Description = @"Control image used to influence the generation. The image needs to be exacly 1024 pixels wide and 512 pixels tall PNG equirectangular projection image of a scribble with black (#00000) background and white (#ffffff) brush strokes. For ""scribble"" effect you will also need to send control_model=""scribble"".",
    };

    private static Option<string?> ControlImagename { get; } = new(
        name: @"--control-imagename")
    {
        Description = @"Control image used to influence the generation. The image needs to be exacly 1024 pixels wide and 512 pixels tall PNG equirectangular projection image of a scribble with black (#00000) background and white (#ffffff) brush strokes. For ""scribble"" effect you will also need to send control_model=""scribble"".",
    };

    private static Option<string?> ControlModel { get; } = new(
        name: @"--control-model")
    {
        Description = @"Model used for the control_image. Currently, the only option is: ""scribble"".",
    };

    private static Option<byte[]?> InitImage { get; } = new(
        name: @"--init-image")
    {
        Description = @"Image (Binary/Base64 string/Absolute URL) to be used as initial image for Skybox generation. Please use equirectangular 360° images. 2:1 aspect ratio recommended. Maximum file size is 50 megabytes.",
    };

    private static Option<string?> InitImagename { get; } = new(
        name: @"--init-imagename")
    {
        Description = @"Image (Binary/Base64 string/Absolute URL) to be used as initial image for Skybox generation. Please use equirectangular 360° images. 2:1 aspect ratio recommended. Maximum file size is 50 megabytes.",
    };

    private static Option<double?> InitStrength { get; } = new(
        name: @"--init-strength")
    {
        Description = @"Scale to be used as initial influence of the ""Init Image"" for Skybox generation. The default value is 0, allowed range is between 0 and 0.97, where 0 represents no influence and 0.97 represents lots of influence. Only has an effect when using an init_image parameter.",
    };

    private static Option<bool?> ReturnDepthHq { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--return-depth-hq",
        description: @"Request for high quality depth map. It will be returned in the depth_map_url parameter. (default: false)");

    private static Option<string?> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"Optionally, you may specify a webhook url to specify the destination for progress updates",
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


    public static Command Create()
    {
        var command = new Command(@"generate-skybox", @"Generate Skybox
Used for generating skyboxes, skybox remixes and depth maps.");
                        command.Options.Add(Prompt);
                        command.Options.Add(NegativeText);
                        command.Options.Add(EnhancePrompt);
                        command.Options.Add(Seed);
                        command.Options.Add(SkyboxStyleId);
                        command.Options.Add(RemixImagineId);
                        command.Options.Add(ControlImage);
                        command.Options.Add(ControlImagename);
                        command.Options.Add(ControlModel);
                        command.Options.Add(InitImage);
                        command.Options.Add(InitImagename);
                        command.Options.Add(InitStrength);
                        command.Options.Add(ReturnDepthHq);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlockadeLabs.GenerateSkyboxRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlockadeLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var negativeText = CliRuntime.WasSpecified(parseResult, NegativeText) ? parseResult.GetValue(NegativeText) : (__requestBase is { } __NegativeTextBaseValue ? __NegativeTextBaseValue.NegativeText : default);
                        var enhancePrompt = CliRuntime.WasSpecified(parseResult, EnhancePrompt) ? parseResult.GetValue(EnhancePrompt) : (__requestBase is { } __EnhancePromptBaseValue ? __EnhancePromptBaseValue.EnhancePrompt : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var skyboxStyleId = CliRuntime.WasSpecified(parseResult, SkyboxStyleId) ? parseResult.GetValue(SkyboxStyleId) : (__requestBase is { } __SkyboxStyleIdBaseValue ? __SkyboxStyleIdBaseValue.SkyboxStyleId : default);
                        var remixImagineId = CliRuntime.WasSpecified(parseResult, RemixImagineId) ? parseResult.GetValue(RemixImagineId) : (__requestBase is { } __RemixImagineIdBaseValue ? __RemixImagineIdBaseValue.RemixImagineId : default);
                        var controlImage = CliRuntime.WasSpecified(parseResult, ControlImage) ? parseResult.GetValue(ControlImage) : (__requestBase is { } __ControlImageBaseValue ? __ControlImageBaseValue.ControlImage : default);
                        var controlImagename = CliRuntime.WasSpecified(parseResult, ControlImagename) ? parseResult.GetValue(ControlImagename) : (__requestBase is { } __ControlImagenameBaseValue ? __ControlImagenameBaseValue.ControlImagename : default);
                        var controlModel = CliRuntime.WasSpecified(parseResult, ControlModel) ? parseResult.GetValue(ControlModel) : (__requestBase is { } __ControlModelBaseValue ? __ControlModelBaseValue.ControlModel : default);
                        var initImage = CliRuntime.WasSpecified(parseResult, InitImage) ? parseResult.GetValue(InitImage) : (__requestBase is { } __InitImageBaseValue ? __InitImageBaseValue.InitImage : default);
                        var initImagename = CliRuntime.WasSpecified(parseResult, InitImagename) ? parseResult.GetValue(InitImagename) : (__requestBase is { } __InitImagenameBaseValue ? __InitImagenameBaseValue.InitImagename : default);
                        var initStrength = CliRuntime.WasSpecified(parseResult, InitStrength) ? parseResult.GetValue(InitStrength) : (__requestBase is { } __InitStrengthBaseValue ? __InitStrengthBaseValue.InitStrength : default);
                        var returnDepthHq = CliRuntime.WasSpecified(parseResult, ReturnDepthHq) ? parseResult.GetValue(ReturnDepthHq) : (__requestBase is { } __ReturnDepthHqBaseValue ? __ReturnDepthHqBaseValue.ReturnDepthHq : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Skyboxes.GenerateSkyboxAsync(
                                    prompt: prompt,
                                    negativeText: negativeText,
                                    enhancePrompt: enhancePrompt,
                                    seed: seed,
                                    skyboxStyleId: skyboxStyleId,
                                    remixImagineId: remixImagineId,
                                    controlImage: controlImage,
                                    controlImagename: controlImagename,
                                    controlModel: controlModel,
                                    initImage: initImage,
                                    initImagename: initImagename,
                                    initStrength: initStrength,
                                    returnDepthHq: returnDepthHq,
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