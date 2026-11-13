
#nullable enable

namespace BlockadeLabs
{
    public partial class SkyboxesClient
    {


        private static readonly global::BlockadeLabs.EndPointSecurityRequirement s_GenerateSkyboxSecurityRequirement0 =
            new global::BlockadeLabs.EndPointSecurityRequirement
            {
                Authorizations = new global::BlockadeLabs.EndPointAuthorizationRequirement[]
                {                    new global::BlockadeLabs.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXApiKey",
                        Location = "Header",
                        Name = "x-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::BlockadeLabs.EndPointSecurityRequirement[] s_GenerateSkyboxSecurityRequirements =
            new global::BlockadeLabs.EndPointSecurityRequirement[]
            {                s_GenerateSkyboxSecurityRequirement0,
            };
        partial void PrepareGenerateSkyboxArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::BlockadeLabs.GenerateSkyboxRequest request);
        partial void PrepareGenerateSkyboxRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::BlockadeLabs.GenerateSkyboxRequest request);
        partial void ProcessGenerateSkyboxResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateSkyboxResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate Skybox<br/>
        /// Generate a Model 3 or Model 4 skybox on the same endpoint. Send application/json, or multipart/form-data when uploading an image. Model 4 styles and variant_id require a Standard or Business plan (Essential and Free receive 403). Remix, control, and init parameters are documented for Model 3. Model 2 is discontinued.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::BlockadeLabs.GenerateSkyboxResponse> GenerateSkyboxAsync(

            global::BlockadeLabs.GenerateSkyboxRequest request,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GenerateSkyboxAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Generate Skybox<br/>
        /// Generate a Model 3 or Model 4 skybox on the same endpoint. Send application/json, or multipart/form-data when uploading an image. Model 4 styles and variant_id require a Standard or Business plan (Essential and Free receive 403). Remix, control, and init parameters are documented for Model 3. Model 2 is discontinued.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlockadeLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::BlockadeLabs.AutoSDKHttpResponse<global::BlockadeLabs.GenerateSkyboxResponse>> GenerateSkyboxAsResponseAsync(

            global::BlockadeLabs.GenerateSkyboxRequest request,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGenerateSkyboxArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::BlockadeLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GenerateSkyboxSecurityRequirements,
                operationName: "GenerateSkyboxAsync");

            using var __timeoutCancellationTokenSource = global::BlockadeLabs.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::BlockadeLabs.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::BlockadeLabs.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::BlockadeLabs.PathBuilder(
                                path: "/api/v1/skybox",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::BlockadeLabs.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.SkyboxStyleId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                name: "\"skybox_style_id\"");

                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.Prompt ?? string.Empty),
                                name: "\"prompt\"");

                            if (request.NegativeText != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.NegativeText ?? string.Empty),
                                    name: "\"negative_text\"");

                            }
                            if (request.EnhancePrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.EnhancePrompt, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"enhance_prompt\"");

                            }
                            if (request.HorizonShift != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.HorizonShift, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"horizon_shift\"");

                            }
                            if (request.VariantId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.VariantId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"variant_id\"");

                            }
                            if (request.SoftLines != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.SoftLines, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"soft_lines\"");

                            }
                            if (request.Seed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Seed, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"seed\"");

                            }
                            if (request.WebhookUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.WebhookUrl ?? string.Empty),
                                    name: "\"webhook_url\"");

                            }
                            if (request.MaxWait != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.MaxWait, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"max_wait\"");

                            }
                            if (request.RemixImagineId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.RemixImagineId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"remix_imagine_id\"");

                            }
                            if (request.RemixCollectionId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.RemixCollectionId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"remix_collection_id\"");

                            }
                            if (request.ControlImage != default)
                            {

                                var __contentControlImage = new global::System.Net.Http.ByteArrayContent(request.ControlImage ?? global::System.Array.Empty<byte>());
                                __contentControlImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.ControlImagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.ControlImagename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentControlImage,
                                    name: "\"control_image\"",
                                    fileName: request.ControlImagename != null ? $"\"{request.ControlImagename}\"" : string.Empty);
                                if (__contentControlImage.Headers.ContentDisposition != null)
                                {
                                    __contentControlImage.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.ControlImageHash != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ControlImageHash ?? string.Empty),
                                    name: "\"control_image_hash\"");

                            }
                            if (request.ControlModel != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ControlModel ?? string.Empty),
                                    name: "\"control_model\"");

                            }
                            if (request.InitImage != default)
                            {

                                var __contentInitImage = new global::System.Net.Http.ByteArrayContent(request.InitImage ?? global::System.Array.Empty<byte>());
                                __contentInitImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.InitImagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.InitImagename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentInitImage,
                                    name: "\"init_image\"",
                                    fileName: request.InitImagename != null ? $"\"{request.InitImagename}\"" : string.Empty);
                                if (__contentInitImage.Headers.ContentDisposition != null)
                                {
                                    __contentInitImage.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.InitImageHash != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.InitImageHash ?? string.Empty),
                                    name: "\"init_image_hash\"");

                            }
                            if (request.InitStrength != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.InitStrength, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"init_strength\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::BlockadeLabs.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGenerateSkyboxRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::BlockadeLabs.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::BlockadeLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateSkybox",
                                methodName: "GenerateSkyboxAsync",
                                pathTemplate: "\"/api/v1/skybox\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::BlockadeLabs.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::BlockadeLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::BlockadeLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateSkybox",
                                methodName: "GenerateSkyboxAsync",
                                pathTemplate: "\"/api/v1/skybox\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::BlockadeLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::BlockadeLabs.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::BlockadeLabs.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::BlockadeLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::BlockadeLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateSkybox",
                                methodName: "GenerateSkyboxAsync",
                                pathTemplate: "\"/api/v1/skybox\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::BlockadeLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGenerateSkyboxResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::BlockadeLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::BlockadeLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateSkybox",
                                methodName: "GenerateSkyboxAsync",
                                pathTemplate: "\"/api/v1/skybox\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::BlockadeLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::BlockadeLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateSkybox",
                                methodName: "GenerateSkyboxAsync",
                                pathTemplate: "\"/api/v1/skybox\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGenerateSkyboxResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::BlockadeLabs.GenerateSkyboxResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::BlockadeLabs.AutoSDKHttpResponse<global::BlockadeLabs.GenerateSkyboxResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::BlockadeLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::BlockadeLabs.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::BlockadeLabs.GenerateSkyboxResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::BlockadeLabs.AutoSDKHttpResponse<global::BlockadeLabs.GenerateSkyboxResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::BlockadeLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::BlockadeLabs.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Generate Skybox<br/>
        /// Generate a Model 3 or Model 4 skybox on the same endpoint. Send application/json, or multipart/form-data when uploading an image. Model 4 styles and variant_id require a Standard or Business plan (Essential and Free receive 403). Remix, control, and init parameters are documented for Model 3. Model 2 is discontinued.
        /// </summary>
        /// <param name="skyboxStyleId">
        /// Style id from Get Skybox Styles. Chooses the model version and the aesthetic. Required.<br/>
        /// Example: 155
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the skybox world you wish to create. Maximum number of characters: 2000, or the max-char value returned for the chosen style.<br/>
        /// Example: dark forest
        /// </param>
        /// <param name="negativeText">
        /// Things to avoid. Maximum number of characters: 600, or the negative-text-max-char value returned for the chosen style.
        /// </param>
        /// <param name="enhancePrompt">
        /// Have an AI automatically improve the prompt (default: false).<br/>
        /// Example: false
        /// </param>
        /// <param name="horizonShift">
        /// Model 4 only. Not used for Model 3 generations. Defaults to 0. Negative shifts the horizon down, positive shifts it up. Accepted range: -20 to 20.<br/>
        /// Example: 0
        /// </param>
        /// <param name="variantId">
        /// Model 4 quality variant from the variants array on Get Skybox Styles. 1 is Balance (3 credits, about 60s). 2 is Detail (6 credits, about 120s). If omitted, the style default is used. Required for Model 4 batches. Model 4 variants require a Standard or Business plan.<br/>
        /// Example: 1
        /// </param>
        /// <param name="softLines">
        /// Model 4 only. Softer line rendering while preserving structural geometry. Default: false.<br/>
        /// Example: false
        /// </param>
        /// <param name="seed">
        /// Send 0 for a random seed. Any other number freezes the generator for a similar result with the same settings. Model 3 accepts 1-2147483647. Model 4 accepts 1-4294967295.<br/>
        /// Example: 0
        /// </param>
        /// <param name="webhookUrl">
        /// Optional URL for generation progress updates.
        /// </param>
        /// <param name="maxWait">
        /// Maximum seconds to wait for the generation. If it does not finish in time, status is set to error and credits are refunded. Accepted range: 30-1800. Model 3 and Model 4.<br/>
        /// Example: 120
        /// </param>
        /// <param name="remixImagineId">
        /// Model 3. ID of a previously generated skybox to remix.
        /// </param>
        /// <param name="remixCollectionId">
        /// Model 3. ID of a project created in the web app. A random skybox from that project is used as the remix starting point.
        /// </param>
        /// <param name="controlImage">
        /// Model 3. Control image (binary, Base64, or absolute URL) that influences structure. Use with control_model set to remix.
        /// </param>
        /// <param name="controlImagename">
        /// Model 3. Control image (binary, Base64, or absolute URL) that influences structure. Use with control_model set to remix.
        /// </param>
        /// <param name="controlImageHash">
        /// Model 3. obfuscated_id of an existing skybox whose control image should be reused, instead of uploading control_image again.
        /// </param>
        /// <param name="controlModel">
        /// Model 3. Model used for control_image. The only option is "remix".<br/>
        /// Example: remix
        /// </param>
        /// <param name="initImage">
        /// Model 3. Init image (binary, Base64, or absolute URL). Equirectangular images. Guides color and composition.
        /// </param>
        /// <param name="initImagename">
        /// Model 3. Init image (binary, Base64, or absolute URL). Equirectangular images. Guides color and composition.
        /// </param>
        /// <param name="initImageHash">
        /// Model 3. obfuscated_id of an existing skybox whose init image should be reused, instead of uploading init_image again.
        /// </param>
        /// <param name="initStrength">
        /// Model 3. Inverted influence of init_image. 0.11 is lots of influence, 0.9 is no influence. Only applies when init_image is sent.<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::BlockadeLabs.GenerateSkyboxResponse> GenerateSkyboxAsync(
            int skyboxStyleId,
            string prompt,
            string? negativeText = default,
            bool? enhancePrompt = default,
            int? horizonShift = default,
            int? variantId = default,
            bool? softLines = default,
            int? seed = default,
            string? webhookUrl = default,
            int? maxWait = default,
            int? remixImagineId = default,
            int? remixCollectionId = default,
            byte[]? controlImage = default,
            string? controlImagename = default,
            string? controlImageHash = default,
            string? controlModel = default,
            byte[]? initImage = default,
            string? initImagename = default,
            string? initImageHash = default,
            double? initStrength = default,
            global::BlockadeLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::BlockadeLabs.GenerateSkyboxRequest
            {
                SkyboxStyleId = skyboxStyleId,
                Prompt = prompt,
                NegativeText = negativeText,
                EnhancePrompt = enhancePrompt,
                HorizonShift = horizonShift,
                VariantId = variantId,
                SoftLines = softLines,
                Seed = seed,
                WebhookUrl = webhookUrl,
                MaxWait = maxWait,
                RemixImagineId = remixImagineId,
                RemixCollectionId = remixCollectionId,
                ControlImage = controlImage,
                ControlImagename = controlImagename,
                ControlImageHash = controlImageHash,
                ControlModel = controlModel,
                InitImage = initImage,
                InitImagename = initImagename,
                InitImageHash = initImageHash,
                InitStrength = initStrength,
            };

            return await GenerateSkyboxAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}