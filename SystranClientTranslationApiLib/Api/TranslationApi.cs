using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Systran;
using Systran.TranslationClientLib.Client;
using Systran.TranslationClientLib.Model;

namespace Systran.TranslationClientLib.Api
{
  

  public interface ITranslationApi {
    
    /// <summary>
    /// Batch Cancel Cancel a translation batch\n
    /// </summary>
    /// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchCancel</returns>
    BatchCancel TranslationBatchCancelGet (string BatchId, string Callback);

    /// <summary>
    /// Batch Cancel Cancel a translation batch\n
    /// </summary>
    /// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchCancel</returns>
    Task<BatchCancel> TranslationBatchCancelGetAsync (string BatchId, string Callback);
    
    /// <summary>
    /// Batch Close Close a translation batch\n
    /// </summary>
    /// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchClose</returns>
    BatchClose TranslationBatchCloseGet (string BatchId, string Callback);

    /// <summary>
    /// Batch Close Close a translation batch\n
    /// </summary>
    /// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchClose</returns>
    Task<BatchClose> TranslationBatchCloseGetAsync (string BatchId, string Callback);
    
    /// <summary>
    /// Batch Create Create a new translation batch\n
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchCreate</returns>
    BatchCreate TranslationBatchCreateGet (string Callback);

    /// <summary>
    /// Batch Create Create a new translation batch\n
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchCreate</returns>
    Task<BatchCreate> TranslationBatchCreateGetAsync (string Callback);
    
    /// <summary>
    /// Batch Status Get the status of a translation batch\n
    /// </summary>
    /// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchStatus</returns>
    BatchStatus TranslationBatchStatusGet (string BatchId, string Callback);

    /// <summary>
    /// Batch Status Get the status of a translation batch\n
    /// </summary>
    /// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchStatus</returns>
    Task<BatchStatus> TranslationBatchStatusGetAsync (string BatchId, string Callback);
    
    /// <summary>
    /// List of profiles List of profiles available for translation.\n
    /// </summary>
    /// <param name="Source">Source language code of the profile</param>/// <param name="Target">Target Language code of the profile\n</param>/// <param name="Id">Identifier of the profile\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>ProfilesResponse</returns>
    ProfilesResponse TranslationProfileGet (string Source, string Target, List<int?> Id, string Callback);

    /// <summary>
    /// List of profiles List of profiles available for translation.\n
    /// </summary>
    /// <param name="Source">Source language code of the profile</param>/// <param name="Target">Target Language code of the profile\n</param>/// <param name="Id">Identifier of the profile\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>ProfilesResponse</returns>
    Task<ProfilesResponse> TranslationProfileGetAsync (string Source, string Target, List<int?> Id, string Callback);
    
    /// <summary>
    /// Supported Languages List of language pairs in which translation is supported.\n\nThis list can be limited to a specific source language or target language.\n
    /// </summary>
    /// <param name="Source">Language code of the source text\n</param>/// <param name="Target">Language code into which to translate the source text\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguageResponse</returns>
    SupportedLanguageResponse TranslationSupportedLanguagesGet (List<string> Source, List<string> Target, string Callback);

    /// <summary>
    /// Supported Languages List of language pairs in which translation is supported.\n\nThis list can be limited to a specific source language or target language.\n
    /// </summary>
    /// <param name="Source">Language code of the source text\n</param>/// <param name="Target">Language code into which to translate the source text\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguageResponse</returns>
    Task<SupportedLanguageResponse> TranslationSupportedLanguagesGetAsync (List<string> Source, List<string> Target, string Callback);
    
    /// <summary>
    /// Translate Translate text from source language to target language\n
    /// </summary>
    /// <param name="Input">Input text (this parameter can be repeated)\n</param>/// <param name="Source">Source language code ([details](#description_langage_code_values)) or `auto`.\n\nWhen the value is set to `auto`, the language will be automatically detected, used to enhance the translation, and returned in output.\n</param>/// <param name="Target">Target language code ([details](#description_langage_code_values))</param>/// <param name="Format">Format of the source text.\n\nValid values are `text` for plain text, `html` for HTML pages, and `auto` for automatic detection. The MIME type of file format supported by SYSTRAN can also be used (application/vnd.openxmlformats, application/vnd.oasis.opendocument, ...)\n</param>/// <param name="Profile">Profile id\n</param>/// <param name="WithSource">If `true`, the source will also be sent back in the response message. It can be useful when used with the withAnnotations option to align the source document with the translated document\n</param>/// <param name="WithAnnotations">If `true`, different annotations will be provided in the translated document. If the option &#39;withSource&#39; is used, the annotations will also be provided in the source document. It will provide segments, tokens, not found words,...\n</param>/// <param name="WithDictionary">User Dictionary or/and Normalization Dictionary ids to be applied to the translation result. Each dictionary &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="WithCorpus">Corpus to be applied to the translation result. Each corpus &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="BackTranslation">If `true`, the translated text will be translated back in source language\n</param>/// <param name="Options">Additional options.\n\nAn option can be a JSON object containing a set of key/value generic options supported by the translator. It can also be a string with the syntax &#39;&lt;key&gt;:&lt;value&gt;&#39; to pass a key/value generic option to the translator.\n</param>/// <param name="Encoding">Encoding. `base64` can be useful to send binary documents in the JSON body. Please note that another alternative is to use translateFile\n</param>/// <param name="Async">If `true`, the translation is performed asynchronously.\n\nThe \&quot;/translate/status\&quot; service must be used to wait for the completion of the request and the \&quot;translate/result\&quot; service must be used to get the final result. The \&quot;/translate/cancel\&quot; can be used to cancel the request.\n</param>/// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationResponse</returns>
    TranslationResponse TranslationTranslateGet (List<string> Input, string Source, string Target, string Format, int? Profile, bool? WithSource, bool? WithAnnotations, string WithDictionary, string WithCorpus, bool? BackTranslation, List<string> Options, string Encoding, bool? Async, string BatchId, string Callback);

    /// <summary>
    /// Translate Translate text from source language to target language\n
    /// </summary>
    /// <param name="Input">Input text (this parameter can be repeated)\n</param>/// <param name="Source">Source language code ([details](#description_langage_code_values)) or `auto`.\n\nWhen the value is set to `auto`, the language will be automatically detected, used to enhance the translation, and returned in output.\n</param>/// <param name="Target">Target language code ([details](#description_langage_code_values))</param>/// <param name="Format">Format of the source text.\n\nValid values are `text` for plain text, `html` for HTML pages, and `auto` for automatic detection. The MIME type of file format supported by SYSTRAN can also be used (application/vnd.openxmlformats, application/vnd.oasis.opendocument, ...)\n</param>/// <param name="Profile">Profile id\n</param>/// <param name="WithSource">If `true`, the source will also be sent back in the response message. It can be useful when used with the withAnnotations option to align the source document with the translated document\n</param>/// <param name="WithAnnotations">If `true`, different annotations will be provided in the translated document. If the option &#39;withSource&#39; is used, the annotations will also be provided in the source document. It will provide segments, tokens, not found words,...\n</param>/// <param name="WithDictionary">User Dictionary or/and Normalization Dictionary ids to be applied to the translation result. Each dictionary &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="WithCorpus">Corpus to be applied to the translation result. Each corpus &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="BackTranslation">If `true`, the translated text will be translated back in source language\n</param>/// <param name="Options">Additional options.\n\nAn option can be a JSON object containing a set of key/value generic options supported by the translator. It can also be a string with the syntax &#39;&lt;key&gt;:&lt;value&gt;&#39; to pass a key/value generic option to the translator.\n</param>/// <param name="Encoding">Encoding. `base64` can be useful to send binary documents in the JSON body. Please note that another alternative is to use translateFile\n</param>/// <param name="Async">If `true`, the translation is performed asynchronously.\n\nThe \&quot;/translate/status\&quot; service must be used to wait for the completion of the request and the \&quot;translate/result\&quot; service must be used to get the final result. The \&quot;/translate/cancel\&quot; can be used to cancel the request.\n</param>/// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationResponse</returns>
    Task<TranslationResponse> TranslationTranslateGetAsync (List<string> Input, string Source, string Target, string Format, int? Profile, bool? WithSource, bool? WithAnnotations, string WithDictionary, string WithCorpus, bool? BackTranslation, List<string> Options, string Encoding, bool? Async, string BatchId, string Callback);
    
    /// <summary>
    /// Translate Cancel Cancel an asynchronous translation request\n
    /// </summary>
    /// <param name="RequestId">Request Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationCancel</returns>
    TranslationCancel TranslationTranslateCancelGet (string RequestId, string Callback);

    /// <summary>
    /// Translate Cancel Cancel an asynchronous translation request\n
    /// </summary>
    /// <param name="RequestId">Request Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationCancel</returns>
    Task<TranslationCancel> TranslationTranslateCancelGetAsync (string RequestId, string Callback);
    
    /// <summary>
    /// Translate File Translate a file from source language to target language\n\n\n* In asynchronous mode (async=true), the response will be a JSON containing a request identifier. This identifier can then be used to poll the request status and its result when completed.\n\n  ```\n  {\n     \&quot;requestId\&quot;: \&quot;54a3d860e62ea467b136eddb\&quot; /* Request identifier to use to get the status,\n                                                the result of the request and to cancel it */\n     \&quot;error\&quot;: \&quot;\&quot;, /* Error at request level */\n  }\n  ```\n\n* In synchronous mode, the response will be either:\n\n  * The **translated document**, directly, if `source` parameters was not `auto` and `withSource` was not true\n  * A `multipart/mixed` document with the following parts:\n\n    1. **Detected language**, if request was done with `auto` source language\n\n      * Header:\n\n        `part-name: detectedLanguage`\n\n      * Body: JSON document\n        ```\n        {\n          detectedLanguage: \&quot;string\&quot;\n          detectedLanguageConfidence : number\n        }\n        ```\n\n    2. **Source document**, if request was done with `withSource`:\n\n      * Header: `part-name: source`\n      * Body: Source document\n\n    3. **Translated document**\n\n      * Header: `part-name: output`\n\n      * Body: Translated document\n
    /// </summary>
    /// <param name="Input">Input file\n</param>/// <param name="Source">Source language code ([details](#description_langage_code_values)) or `auto`.\n\nWhen the value is set to `auto`, the language will be automatically detected, used to enhance the translation, and returned in output.\n</param>/// <param name="Target">Target language code ([details](#description_langage_code_values))</param>/// <param name="Format">Format of the source text.\n\nValid values are `text` for plain text, `html` for HTML pages, and `auto` for automatic detection. The MIME type of file format supported by SYSTRAN can also be used (application/vnd.openxmlformats, application/vnd.oasis.opendocument, ...)\n</param>/// <param name="Profile">Profile id\n</param>/// <param name="WithSource">If `true`, the source will also be sent back in the response message. It can be useful when used with the withAnnotations option to align the source document with the translated document\n</param>/// <param name="WithAnnotations">If `true`, different annotations will be provided in the translated document. If the option &#39;withSource&#39; is used, the annotations will also be provided in the source document. It will provide segments, tokens, not found words,...\n</param>/// <param name="WithDictionary">User Dictionary or/and Normalization Dictionary ids to be applied to the translation result. Each dictionary &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="WithCorpus">Corpus to be applied to the translation result. Each corpus &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="Options">Additional options.\n\nAn option can be a JSON object containing a set of key/value generic options supported by the translator. It can also be a string with the syntax &#39;&lt;key&gt;:&lt;value&gt;&#39; to pass a key/value generic option to the translator.\n</param>/// <param name="Encoding">Encoding. `base64` can be useful to send binary documents in the JSON body. Please note that another alternative is to use translateFile\n</param>/// <param name="Async">If `true`, the translation is performed asynchronously.\n\nThe \&quot;/translate/status\&quot; service must be used to wait for the completion of the request and the \&quot;translate/result\&quot; service must be used to get the final result. The \&quot;/translate/cancel\&quot; can be used to cancel the request.\n</param>/// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationFileResponse</returns>
    TranslationFileResponse TranslationTranslateFileGet (string Input, string Source, string Target, string Format, int? Profile, bool? WithSource, bool? WithAnnotations, string WithDictionary, string WithCorpus, List<string> Options, string Encoding, bool? Async, string BatchId, string Callback);

    /// <summary>
    /// Translate File Translate a file from source language to target language\n\n\n* In asynchronous mode (async=true), the response will be a JSON containing a request identifier. This identifier can then be used to poll the request status and its result when completed.\n\n  ```\n  {\n     \&quot;requestId\&quot;: \&quot;54a3d860e62ea467b136eddb\&quot; /* Request identifier to use to get the status,\n                                                the result of the request and to cancel it */\n     \&quot;error\&quot;: \&quot;\&quot;, /* Error at request level */\n  }\n  ```\n\n* In synchronous mode, the response will be either:\n\n  * The **translated document**, directly, if `source` parameters was not `auto` and `withSource` was not true\n  * A `multipart/mixed` document with the following parts:\n\n    1. **Detected language**, if request was done with `auto` source language\n\n      * Header:\n\n        `part-name: detectedLanguage`\n\n      * Body: JSON document\n        ```\n        {\n          detectedLanguage: \&quot;string\&quot;\n          detectedLanguageConfidence : number\n        }\n        ```\n\n    2. **Source document**, if request was done with `withSource`:\n\n      * Header: `part-name: source`\n      * Body: Source document\n\n    3. **Translated document**\n\n      * Header: `part-name: output`\n\n      * Body: Translated document\n
    /// </summary>
    /// <param name="Input">Input file\n</param>/// <param name="Source">Source language code ([details](#description_langage_code_values)) or `auto`.\n\nWhen the value is set to `auto`, the language will be automatically detected, used to enhance the translation, and returned in output.\n</param>/// <param name="Target">Target language code ([details](#description_langage_code_values))</param>/// <param name="Format">Format of the source text.\n\nValid values are `text` for plain text, `html` for HTML pages, and `auto` for automatic detection. The MIME type of file format supported by SYSTRAN can also be used (application/vnd.openxmlformats, application/vnd.oasis.opendocument, ...)\n</param>/// <param name="Profile">Profile id\n</param>/// <param name="WithSource">If `true`, the source will also be sent back in the response message. It can be useful when used with the withAnnotations option to align the source document with the translated document\n</param>/// <param name="WithAnnotations">If `true`, different annotations will be provided in the translated document. If the option &#39;withSource&#39; is used, the annotations will also be provided in the source document. It will provide segments, tokens, not found words,...\n</param>/// <param name="WithDictionary">User Dictionary or/and Normalization Dictionary ids to be applied to the translation result. Each dictionary &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="WithCorpus">Corpus to be applied to the translation result. Each corpus &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="Options">Additional options.\n\nAn option can be a JSON object containing a set of key/value generic options supported by the translator. It can also be a string with the syntax &#39;&lt;key&gt;:&lt;value&gt;&#39; to pass a key/value generic option to the translator.\n</param>/// <param name="Encoding">Encoding. `base64` can be useful to send binary documents in the JSON body. Please note that another alternative is to use translateFile\n</param>/// <param name="Async">If `true`, the translation is performed asynchronously.\n\nThe \&quot;/translate/status\&quot; service must be used to wait for the completion of the request and the \&quot;translate/result\&quot; service must be used to get the final result. The \&quot;/translate/cancel\&quot; can be used to cancel the request.\n</param>/// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationFileResponse</returns>
    Task<TranslationFileResponse> TranslationTranslateFileGetAsync (string Input, string Source, string Target, string Format, int? Profile, bool? WithSource, bool? WithAnnotations, string WithDictionary, string WithCorpus, List<string> Options, string Encoding, bool? Async, string BatchId, string Callback);
    
    /// <summary>
    /// Translate Result Get the result of an asynchronous translation request\n\nDepending on the initial request, the response can have multiple formats:\n* `/translation/translate` initiated request\n\n    &amp;#x2192; the response will be a JSON document (model below)\n\n* `/translation/translate/file` initiated request\n\n   &amp;#x2192; the response will be either:\n\n  * The **translated document**, directly, if `source` parameters was not `auto` and `withSource` was not true\n  * A `multipart/mixed` document with the following parts:\n\n    1. **Detected language**, if request was done with `auto` source language\n\n      * Header:\n\n        `part-name: detectedLanguage`\n\n      * Body: JSON document\n        ```\n        {\n          detectedLanguage: \&quot;string\&quot;\n          detectedLanguageConfidence : number\n        }\n        ```\n\n    2. **Source document**, if request was done with `withSource`:\n\n      * Header: `part-name: source`\n      * Body: Source document\n\n    3. **Translated document**\n\n      * Header: `part-name: output`\n\n      * Body: Translated document\n\nAn error can occur in the following cases:\n* Invalid request ID\n* No result available (see request status for more information)\n* Unable to retrieve the result\n* ...\n
    /// </summary>
    /// <param name="RequestId">Request Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationResponse</returns>
    TranslationResponse TranslationTranslateResultGet (string RequestId, string Callback);

    /// <summary>
    /// Translate Result Get the result of an asynchronous translation request\n\nDepending on the initial request, the response can have multiple formats:\n* `/translation/translate` initiated request\n\n    &amp;#x2192; the response will be a JSON document (model below)\n\n* `/translation/translate/file` initiated request\n\n   &amp;#x2192; the response will be either:\n\n  * The **translated document**, directly, if `source` parameters was not `auto` and `withSource` was not true\n  * A `multipart/mixed` document with the following parts:\n\n    1. **Detected language**, if request was done with `auto` source language\n\n      * Header:\n\n        `part-name: detectedLanguage`\n\n      * Body: JSON document\n        ```\n        {\n          detectedLanguage: \&quot;string\&quot;\n          detectedLanguageConfidence : number\n        }\n        ```\n\n    2. **Source document**, if request was done with `withSource`:\n\n      * Header: `part-name: source`\n      * Body: Source document\n\n    3. **Translated document**\n\n      * Header: `part-name: output`\n\n      * Body: Translated document\n\nAn error can occur in the following cases:\n* Invalid request ID\n* No result available (see request status for more information)\n* Unable to retrieve the result\n* ...\n
    /// </summary>
    /// <param name="RequestId">Request Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationResponse</returns>
    Task<TranslationResponse> TranslationTranslateResultGetAsync (string RequestId, string Callback);
    
    /// <summary>
    /// Translate Status Get the status of an asynchronous translation request\n\nThe translation result is available when the value of the status field is `finished`.\n\nThe translation request is unsuccessful when the value of the status field is `error`.\n
    /// </summary>
    /// <param name="RequestId">Request Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationStatus</returns>
    TranslationStatus TranslationTranslateStatusGet (string RequestId, string Callback);

    /// <summary>
    /// Translate Status Get the status of an asynchronous translation request\n\nThe translation result is available when the value of the status field is `finished`.\n\nThe translation request is unsuccessful when the value of the status field is `error`.\n
    /// </summary>
    /// <param name="RequestId">Request Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationStatus</returns>
    Task<TranslationStatus> TranslationTranslateStatusGetAsync (string RequestId, string Callback);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class TranslationApi : ITranslationApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="TranslationApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public TranslationApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TranslationApi"/> class.
    /// </summary>
    /// <returns></returns>
    public TranslationApi(String basePath)
    {
      this.apiClient = new ApiClient(basePath);
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public void SetBasePath(String basePath) {
      this.apiClient.basePath = basePath;
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public String GetBasePath(String basePath) {
      return this.apiClient.basePath;
    }

    /// <summary>
    /// Gets or sets the API client.
    /// </summary>
    /// <value>The API client</value>
    public ApiClient apiClient {get; set;}


    
    /// <summary>
    /// Batch Cancel Cancel a translation batch\n
    /// </summary>
    /// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchCancel</returns>
    public BatchCancel TranslationBatchCancelGet (string BatchId, string Callback) {

      
      // verify the required parameter 'BatchId' is set
      if (BatchId == null) throw new ApiException(400, "Missing required parameter 'BatchId' when calling TranslationBatchCancelGet");
      

      var path = "/translation/batch/cancel";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (BatchId != null) queryParams.Add("batchId", apiClient.ParameterToString(BatchId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationBatchCancelGet: " + response.Content, response.Content);
      }
      return (BatchCancel) apiClient.Deserialize(response.Content, typeof(BatchCancel));
    }
	
	 /// <summary>
    /// Batch Cancel Cancel a translation batch\n
    /// </summary>
    /// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchCancel</returns>
    public async Task<BatchCancel> TranslationBatchCancelGetAsync (string BatchId, string Callback) {

      
          // verify the required parameter 'BatchId' is set
          if (BatchId == null) throw new ApiException(400, "Missing required parameter 'BatchId' when calling TranslationBatchCancelGet");
      

      var path = "/translation/batch/cancel";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (BatchId != null) queryParams.Add("batchId", apiClient.ParameterToString(BatchId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationBatchCancelGet: " + response.Content, response.Content);
      }
      return (BatchCancel) apiClient.Deserialize(response.Content, typeof(BatchCancel));
    }
    
    /// <summary>
    /// Batch Close Close a translation batch\n
    /// </summary>
    /// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchClose</returns>
    public BatchClose TranslationBatchCloseGet (string BatchId, string Callback) {

      
      // verify the required parameter 'BatchId' is set
      if (BatchId == null) throw new ApiException(400, "Missing required parameter 'BatchId' when calling TranslationBatchCloseGet");
      

      var path = "/translation/batch/close";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (BatchId != null) queryParams.Add("batchId", apiClient.ParameterToString(BatchId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationBatchCloseGet: " + response.Content, response.Content);
      }
      return (BatchClose) apiClient.Deserialize(response.Content, typeof(BatchClose));
    }
	
	 /// <summary>
    /// Batch Close Close a translation batch\n
    /// </summary>
    /// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchClose</returns>
    public async Task<BatchClose> TranslationBatchCloseGetAsync (string BatchId, string Callback) {

      
          // verify the required parameter 'BatchId' is set
          if (BatchId == null) throw new ApiException(400, "Missing required parameter 'BatchId' when calling TranslationBatchCloseGet");
      

      var path = "/translation/batch/close";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (BatchId != null) queryParams.Add("batchId", apiClient.ParameterToString(BatchId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationBatchCloseGet: " + response.Content, response.Content);
      }
      return (BatchClose) apiClient.Deserialize(response.Content, typeof(BatchClose));
    }
    
    /// <summary>
    /// Batch Create Create a new translation batch\n
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchCreate</returns>
    public BatchCreate TranslationBatchCreateGet (string Callback) {

      

      var path = "/translation/batch/create";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationBatchCreateGet: " + response.Content, response.Content);
      }
      return (BatchCreate) apiClient.Deserialize(response.Content, typeof(BatchCreate));
    }
	
	 /// <summary>
    /// Batch Create Create a new translation batch\n
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchCreate</returns>
    public async Task<BatchCreate> TranslationBatchCreateGetAsync (string Callback) {

      

      var path = "/translation/batch/create";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationBatchCreateGet: " + response.Content, response.Content);
      }
      return (BatchCreate) apiClient.Deserialize(response.Content, typeof(BatchCreate));
    }
    
    /// <summary>
    /// Batch Status Get the status of a translation batch\n
    /// </summary>
    /// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchStatus</returns>
    public BatchStatus TranslationBatchStatusGet (string BatchId, string Callback) {

      
      // verify the required parameter 'BatchId' is set
      if (BatchId == null) throw new ApiException(400, "Missing required parameter 'BatchId' when calling TranslationBatchStatusGet");
      

      var path = "/translation/batch/status";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (BatchId != null) queryParams.Add("batchId", apiClient.ParameterToString(BatchId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationBatchStatusGet: " + response.Content, response.Content);
      }
      return (BatchStatus) apiClient.Deserialize(response.Content, typeof(BatchStatus));
    }
	
	 /// <summary>
    /// Batch Status Get the status of a translation batch\n
    /// </summary>
    /// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>BatchStatus</returns>
    public async Task<BatchStatus> TranslationBatchStatusGetAsync (string BatchId, string Callback) {

      
          // verify the required parameter 'BatchId' is set
          if (BatchId == null) throw new ApiException(400, "Missing required parameter 'BatchId' when calling TranslationBatchStatusGet");
      

      var path = "/translation/batch/status";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (BatchId != null) queryParams.Add("batchId", apiClient.ParameterToString(BatchId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationBatchStatusGet: " + response.Content, response.Content);
      }
      return (BatchStatus) apiClient.Deserialize(response.Content, typeof(BatchStatus));
    }
    
    /// <summary>
    /// List of profiles List of profiles available for translation.\n
    /// </summary>
    /// <param name="Source">Source language code of the profile</param>/// <param name="Target">Target Language code of the profile\n</param>/// <param name="Id">Identifier of the profile\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>ProfilesResponse</returns>
    public ProfilesResponse TranslationProfileGet (string Source, string Target, List<int?> Id, string Callback) {

      

      var path = "/translation/profile";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Id != null) queryParams.Add("id", apiClient.ParameterToString(Id)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationProfileGet: " + response.Content, response.Content);
      }
      return (ProfilesResponse) apiClient.Deserialize(response.Content, typeof(ProfilesResponse));
    }
	
	 /// <summary>
    /// List of profiles List of profiles available for translation.\n
    /// </summary>
    /// <param name="Source">Source language code of the profile</param>/// <param name="Target">Target Language code of the profile\n</param>/// <param name="Id">Identifier of the profile\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>ProfilesResponse</returns>
    public async Task<ProfilesResponse> TranslationProfileGetAsync (string Source, string Target, List<int?> Id, string Callback) {

      

      var path = "/translation/profile";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Id != null) queryParams.Add("id", apiClient.ParameterToString(Id)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationProfileGet: " + response.Content, response.Content);
      }
      return (ProfilesResponse) apiClient.Deserialize(response.Content, typeof(ProfilesResponse));
    }
    
    /// <summary>
    /// Supported Languages List of language pairs in which translation is supported.\n\nThis list can be limited to a specific source language or target language.\n
    /// </summary>
    /// <param name="Source">Language code of the source text\n</param>/// <param name="Target">Language code into which to translate the source text\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguageResponse</returns>
    public SupportedLanguageResponse TranslationSupportedLanguagesGet (List<string> Source, List<string> Target, string Callback) {

      

      var path = "/translation/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        //throw new ApiException ((int)response.StatusCode, "Error calling TranslationSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SupportedLanguageResponse) apiClient.Deserialize(response.Content, typeof(SupportedLanguageResponse));
    }
	
	 /// <summary>
    /// Supported Languages List of language pairs in which translation is supported.\n\nThis list can be limited to a specific source language or target language.\n
    /// </summary>
    /// <param name="Source">Language code of the source text\n</param>/// <param name="Target">Language code into which to translate the source text\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SupportedLanguageResponse</returns>
    public async Task<SupportedLanguageResponse> TranslationSupportedLanguagesGetAsync (List<string> Source, List<string> Target, string Callback) {

      

      var path = "/translation/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SupportedLanguageResponse) apiClient.Deserialize(response.Content, typeof(SupportedLanguageResponse));
    }
    
    /// <summary>
    /// Translate Translate text from source language to target language\n
    /// </summary>
    /// <param name="Input">Input text (this parameter can be repeated)\n</param>/// <param name="Source">Source language code ([details](#description_langage_code_values)) or `auto`.\n\nWhen the value is set to `auto`, the language will be automatically detected, used to enhance the translation, and returned in output.\n</param>/// <param name="Target">Target language code ([details](#description_langage_code_values))</param>/// <param name="Format">Format of the source text.\n\nValid values are `text` for plain text, `html` for HTML pages, and `auto` for automatic detection. The MIME type of file format supported by SYSTRAN can also be used (application/vnd.openxmlformats, application/vnd.oasis.opendocument, ...)\n</param>/// <param name="Profile">Profile id\n</param>/// <param name="WithSource">If `true`, the source will also be sent back in the response message. It can be useful when used with the withAnnotations option to align the source document with the translated document\n</param>/// <param name="WithAnnotations">If `true`, different annotations will be provided in the translated document. If the option &#39;withSource&#39; is used, the annotations will also be provided in the source document. It will provide segments, tokens, not found words,...\n</param>/// <param name="WithDictionary">User Dictionary or/and Normalization Dictionary ids to be applied to the translation result. Each dictionary &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="WithCorpus">Corpus to be applied to the translation result. Each corpus &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="BackTranslation">If `true`, the translated text will be translated back in source language\n</param>/// <param name="Options">Additional options.\n\nAn option can be a JSON object containing a set of key/value generic options supported by the translator. It can also be a string with the syntax &#39;&lt;key&gt;:&lt;value&gt;&#39; to pass a key/value generic option to the translator.\n</param>/// <param name="Encoding">Encoding. `base64` can be useful to send binary documents in the JSON body. Please note that another alternative is to use translateFile\n</param>/// <param name="Async">If `true`, the translation is performed asynchronously.\n\nThe \&quot;/translate/status\&quot; service must be used to wait for the completion of the request and the \&quot;translate/result\&quot; service must be used to get the final result. The \&quot;/translate/cancel\&quot; can be used to cancel the request.\n</param>/// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationResponse</returns>
    public TranslationResponse TranslationTranslateGet (List<string> Input, string Source, string Target, string Format, int? Profile, bool? WithSource, bool? WithAnnotations, string WithDictionary, string WithCorpus, bool? BackTranslation, List<string> Options, string Encoding, bool? Async, string BatchId, string Callback) {

      
      // verify the required parameter 'Input' is set
      if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling TranslationTranslateGet");
      
      // verify the required parameter 'Target' is set
      if (Target == null) throw new ApiException(400, "Missing required parameter 'Target' when calling TranslationTranslateGet");
      

      var path = "/translation/translate";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Format != null) queryParams.Add("format", apiClient.ParameterToString(Format)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (WithSource != null) queryParams.Add("withSource", apiClient.ParameterToString(WithSource)); // query parameter
       if (WithAnnotations != null) queryParams.Add("withAnnotations", apiClient.ParameterToString(WithAnnotations)); // query parameter
       if (WithDictionary != null) queryParams.Add("withDictionary", apiClient.ParameterToString(WithDictionary)); // query parameter
       if (WithCorpus != null) queryParams.Add("withCorpus", apiClient.ParameterToString(WithCorpus)); // query parameter
       if (BackTranslation != null) queryParams.Add("backTranslation", apiClient.ParameterToString(BackTranslation)); // query parameter
       if (Options != null) queryParams.Add("options", apiClient.ParameterToString(Options)); // query parameter
       if (Encoding != null) queryParams.Add("encoding", apiClient.ParameterToString(Encoding)); // query parameter
       if (Async != null) queryParams.Add("async", apiClient.ParameterToString(Async)); // query parameter
       if (BatchId != null) queryParams.Add("batchId", apiClient.ParameterToString(BatchId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationTranslateGet: " + response.Content, response.Content);
      }
      return (TranslationResponse) apiClient.Deserialize(response.Content, typeof(TranslationResponse));
    }
	
	 /// <summary>
    /// Translate Translate text from source language to target language\n
    /// </summary>
    /// <param name="Input">Input text (this parameter can be repeated)\n</param>/// <param name="Source">Source language code ([details](#description_langage_code_values)) or `auto`.\n\nWhen the value is set to `auto`, the language will be automatically detected, used to enhance the translation, and returned in output.\n</param>/// <param name="Target">Target language code ([details](#description_langage_code_values))</param>/// <param name="Format">Format of the source text.\n\nValid values are `text` for plain text, `html` for HTML pages, and `auto` for automatic detection. The MIME type of file format supported by SYSTRAN can also be used (application/vnd.openxmlformats, application/vnd.oasis.opendocument, ...)\n</param>/// <param name="Profile">Profile id\n</param>/// <param name="WithSource">If `true`, the source will also be sent back in the response message. It can be useful when used with the withAnnotations option to align the source document with the translated document\n</param>/// <param name="WithAnnotations">If `true`, different annotations will be provided in the translated document. If the option &#39;withSource&#39; is used, the annotations will also be provided in the source document. It will provide segments, tokens, not found words,...\n</param>/// <param name="WithDictionary">User Dictionary or/and Normalization Dictionary ids to be applied to the translation result. Each dictionary &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="WithCorpus">Corpus to be applied to the translation result. Each corpus &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="BackTranslation">If `true`, the translated text will be translated back in source language\n</param>/// <param name="Options">Additional options.\n\nAn option can be a JSON object containing a set of key/value generic options supported by the translator. It can also be a string with the syntax &#39;&lt;key&gt;:&lt;value&gt;&#39; to pass a key/value generic option to the translator.\n</param>/// <param name="Encoding">Encoding. `base64` can be useful to send binary documents in the JSON body. Please note that another alternative is to use translateFile\n</param>/// <param name="Async">If `true`, the translation is performed asynchronously.\n\nThe \&quot;/translate/status\&quot; service must be used to wait for the completion of the request and the \&quot;translate/result\&quot; service must be used to get the final result. The \&quot;/translate/cancel\&quot; can be used to cancel the request.\n</param>/// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationResponse</returns>
    public async Task<TranslationResponse> TranslationTranslateGetAsync (List<string> Input, string Source, string Target, string Format, int? Profile, bool? WithSource, bool? WithAnnotations, string WithDictionary, string WithCorpus, bool? BackTranslation, List<string> Options, string Encoding, bool? Async, string BatchId, string Callback) {

      
          // verify the required parameter 'Input' is set
          if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling TranslationTranslateGet");
      
          // verify the required parameter 'Target' is set
          if (Target == null) throw new ApiException(400, "Missing required parameter 'Target' when calling TranslationTranslateGet");
      

      var path = "/translation/translate";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Input != null) queryParams.Add("input", apiClient.ParameterToString(Input)); // query parameter
       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Format != null) queryParams.Add("format", apiClient.ParameterToString(Format)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (WithSource != null) queryParams.Add("withSource", apiClient.ParameterToString(WithSource)); // query parameter
       if (WithAnnotations != null) queryParams.Add("withAnnotations", apiClient.ParameterToString(WithAnnotations)); // query parameter
       if (WithDictionary != null) queryParams.Add("withDictionary", apiClient.ParameterToString(WithDictionary)); // query parameter
       if (WithCorpus != null) queryParams.Add("withCorpus", apiClient.ParameterToString(WithCorpus)); // query parameter
       if (BackTranslation != null) queryParams.Add("backTranslation", apiClient.ParameterToString(BackTranslation)); // query parameter
       if (Options != null) queryParams.Add("options", apiClient.ParameterToString(Options)); // query parameter
       if (Encoding != null) queryParams.Add("encoding", apiClient.ParameterToString(Encoding)); // query parameter
       if (Async != null) queryParams.Add("async", apiClient.ParameterToString(Async)); // query parameter
       if (BatchId != null) queryParams.Add("batchId", apiClient.ParameterToString(BatchId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationTranslateGet: " + response.Content, response.Content);
      }
      return (TranslationResponse) apiClient.Deserialize(response.Content, typeof(TranslationResponse));
    }
    
    /// <summary>
    /// Translate Cancel Cancel an asynchronous translation request\n
    /// </summary>
    /// <param name="RequestId">Request Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationCancel</returns>
    public TranslationCancel TranslationTranslateCancelGet (string RequestId, string Callback) {

      
      // verify the required parameter 'RequestId' is set
      if (RequestId == null) throw new ApiException(400, "Missing required parameter 'RequestId' when calling TranslationTranslateCancelGet");
      

      var path = "/translation/translate/cancel";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (RequestId != null) queryParams.Add("requestId", apiClient.ParameterToString(RequestId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationTranslateCancelGet: " + response.Content, response.Content);
      }
      return (TranslationCancel) apiClient.Deserialize(response.Content, typeof(TranslationCancel));
    }
	
	 /// <summary>
    /// Translate Cancel Cancel an asynchronous translation request\n
    /// </summary>
    /// <param name="RequestId">Request Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationCancel</returns>
    public async Task<TranslationCancel> TranslationTranslateCancelGetAsync (string RequestId, string Callback) {

      
          // verify the required parameter 'RequestId' is set
          if (RequestId == null) throw new ApiException(400, "Missing required parameter 'RequestId' when calling TranslationTranslateCancelGet");
      

      var path = "/translation/translate/cancel";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (RequestId != null) queryParams.Add("requestId", apiClient.ParameterToString(RequestId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationTranslateCancelGet: " + response.Content, response.Content);
      }
      return (TranslationCancel) apiClient.Deserialize(response.Content, typeof(TranslationCancel));
    }
    
    /// <summary>
    /// Translate File Translate a file from source language to target language\n\n\n* In asynchronous mode (async=true), the response will be a JSON containing a request identifier. This identifier can then be used to poll the request status and its result when completed.\n\n  ```\n  {\n     \&quot;requestId\&quot;: \&quot;54a3d860e62ea467b136eddb\&quot; /* Request identifier to use to get the status,\n                                                the result of the request and to cancel it */\n     \&quot;error\&quot;: \&quot;\&quot;, /* Error at request level */\n  }\n  ```\n\n* In synchronous mode, the response will be either:\n\n  * The **translated document**, directly, if `source` parameters was not `auto` and `withSource` was not true\n  * A `multipart/mixed` document with the following parts:\n\n    1. **Detected language**, if request was done with `auto` source language\n\n      * Header:\n\n        `part-name: detectedLanguage`\n\n      * Body: JSON document\n        ```\n        {\n          detectedLanguage: \&quot;string\&quot;\n          detectedLanguageConfidence : number\n        }\n        ```\n\n    2. **Source document**, if request was done with `withSource`:\n\n      * Header: `part-name: source`\n      * Body: Source document\n\n    3. **Translated document**\n\n      * Header: `part-name: output`\n\n      * Body: Translated document\n
    /// </summary>
    /// <param name="Input">Input file\n</param>/// <param name="Source">Source language code ([details](#description_langage_code_values)) or `auto`.\n\nWhen the value is set to `auto`, the language will be automatically detected, used to enhance the translation, and returned in output.\n</param>/// <param name="Target">Target language code ([details](#description_langage_code_values))</param>/// <param name="Format">Format of the source text.\n\nValid values are `text` for plain text, `html` for HTML pages, and `auto` for automatic detection. The MIME type of file format supported by SYSTRAN can also be used (application/vnd.openxmlformats, application/vnd.oasis.opendocument, ...)\n</param>/// <param name="Profile">Profile id\n</param>/// <param name="WithSource">If `true`, the source will also be sent back in the response message. It can be useful when used with the withAnnotations option to align the source document with the translated document\n</param>/// <param name="WithAnnotations">If `true`, different annotations will be provided in the translated document. If the option &#39;withSource&#39; is used, the annotations will also be provided in the source document. It will provide segments, tokens, not found words,...\n</param>/// <param name="WithDictionary">User Dictionary or/and Normalization Dictionary ids to be applied to the translation result. Each dictionary &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="WithCorpus">Corpus to be applied to the translation result. Each corpus &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="Options">Additional options.\n\nAn option can be a JSON object containing a set of key/value generic options supported by the translator. It can also be a string with the syntax &#39;&lt;key&gt;:&lt;value&gt;&#39; to pass a key/value generic option to the translator.\n</param>/// <param name="Encoding">Encoding. `base64` can be useful to send binary documents in the JSON body. Please note that another alternative is to use translateFile\n</param>/// <param name="Async">If `true`, the translation is performed asynchronously.\n\nThe \&quot;/translate/status\&quot; service must be used to wait for the completion of the request and the \&quot;translate/result\&quot; service must be used to get the final result. The \&quot;/translate/cancel\&quot; can be used to cancel the request.\n</param>/// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationFileResponse</returns>
    public TranslationFileResponse TranslationTranslateFileGet (string Input, string Source, string Target, string Format, int? Profile, bool? WithSource, bool? WithAnnotations, string WithDictionary, string WithCorpus, List<string> Options, string Encoding, bool? Async, string BatchId, string Callback) {

      
      // verify the required parameter 'Input' is set
      if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling TranslationTranslateFileGet");
      
      // verify the required parameter 'Target' is set
      if (Target == null) throw new ApiException(400, "Missing required parameter 'Target' when calling TranslationTranslateFileGet");
      

      var path = "/translation/translate/file";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Format != null) queryParams.Add("format", apiClient.ParameterToString(Format)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (WithSource != null) queryParams.Add("withSource", apiClient.ParameterToString(WithSource)); // query parameter
       if (WithAnnotations != null) queryParams.Add("withAnnotations", apiClient.ParameterToString(WithAnnotations)); // query parameter
       if (WithDictionary != null) queryParams.Add("withDictionary", apiClient.ParameterToString(WithDictionary)); // query parameter
       if (WithCorpus != null) queryParams.Add("withCorpus", apiClient.ParameterToString(WithCorpus)); // query parameter
       if (Options != null) queryParams.Add("options", apiClient.ParameterToString(Options)); // query parameter
       if (Encoding != null) queryParams.Add("encoding", apiClient.ParameterToString(Encoding)); // query parameter
       if (Async != null) queryParams.Add("async", apiClient.ParameterToString(Async)); // query parameter
       if (BatchId != null) queryParams.Add("batchId", apiClient.ParameterToString(BatchId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (Input != null) fileParams.Add("input", Input);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationTranslateFileGet: " + response.Content, response.Content);
      }
      return (TranslationFileResponse) apiClient.Deserialize(response.Content, typeof(TranslationFileResponse));
    }
	
	 /// <summary>
    /// Translate File Translate a file from source language to target language\n\n\n* In asynchronous mode (async=true), the response will be a JSON containing a request identifier. This identifier can then be used to poll the request status and its result when completed.\n\n  ```\n  {\n     \&quot;requestId\&quot;: \&quot;54a3d860e62ea467b136eddb\&quot; /* Request identifier to use to get the status,\n                                                the result of the request and to cancel it */\n     \&quot;error\&quot;: \&quot;\&quot;, /* Error at request level */\n  }\n  ```\n\n* In synchronous mode, the response will be either:\n\n  * The **translated document**, directly, if `source` parameters was not `auto` and `withSource` was not true\n  * A `multipart/mixed` document with the following parts:\n\n    1. **Detected language**, if request was done with `auto` source language\n\n      * Header:\n\n        `part-name: detectedLanguage`\n\n      * Body: JSON document\n        ```\n        {\n          detectedLanguage: \&quot;string\&quot;\n          detectedLanguageConfidence : number\n        }\n        ```\n\n    2. **Source document**, if request was done with `withSource`:\n\n      * Header: `part-name: source`\n      * Body: Source document\n\n    3. **Translated document**\n\n      * Header: `part-name: output`\n\n      * Body: Translated document\n
    /// </summary>
    /// <param name="Input">Input file\n</param>/// <param name="Source">Source language code ([details](#description_langage_code_values)) or `auto`.\n\nWhen the value is set to `auto`, the language will be automatically detected, used to enhance the translation, and returned in output.\n</param>/// <param name="Target">Target language code ([details](#description_langage_code_values))</param>/// <param name="Format">Format of the source text.\n\nValid values are `text` for plain text, `html` for HTML pages, and `auto` for automatic detection. The MIME type of file format supported by SYSTRAN can also be used (application/vnd.openxmlformats, application/vnd.oasis.opendocument, ...)\n</param>/// <param name="Profile">Profile id\n</param>/// <param name="WithSource">If `true`, the source will also be sent back in the response message. It can be useful when used with the withAnnotations option to align the source document with the translated document\n</param>/// <param name="WithAnnotations">If `true`, different annotations will be provided in the translated document. If the option &#39;withSource&#39; is used, the annotations will also be provided in the source document. It will provide segments, tokens, not found words,...\n</param>/// <param name="WithDictionary">User Dictionary or/and Normalization Dictionary ids to be applied to the translation result. Each dictionary &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="WithCorpus">Corpus to be applied to the translation result. Each corpus &#39;id&#39; has to be separate by a comma.\n</param>/// <param name="Options">Additional options.\n\nAn option can be a JSON object containing a set of key/value generic options supported by the translator. It can also be a string with the syntax &#39;&lt;key&gt;:&lt;value&gt;&#39; to pass a key/value generic option to the translator.\n</param>/// <param name="Encoding">Encoding. `base64` can be useful to send binary documents in the JSON body. Please note that another alternative is to use translateFile\n</param>/// <param name="Async">If `true`, the translation is performed asynchronously.\n\nThe \&quot;/translate/status\&quot; service must be used to wait for the completion of the request and the \&quot;translate/result\&quot; service must be used to get the final result. The \&quot;/translate/cancel\&quot; can be used to cancel the request.\n</param>/// <param name="BatchId">Batch Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationFileResponse</returns>
    public async Task<TranslationFileResponse> TranslationTranslateFileGetAsync (string Input, string Source, string Target, string Format, int? Profile, bool? WithSource, bool? WithAnnotations, string WithDictionary, string WithCorpus, List<string> Options, string Encoding, bool? Async, string BatchId, string Callback) {

      
          // verify the required parameter 'Input' is set
          if (Input == null) throw new ApiException(400, "Missing required parameter 'Input' when calling TranslationTranslateFileGet");
      
          // verify the required parameter 'Target' is set
          if (Target == null) throw new ApiException(400, "Missing required parameter 'Target' when calling TranslationTranslateFileGet");
      

      var path = "/translation/translate/file";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Source != null) queryParams.Add("source", apiClient.ParameterToString(Source)); // query parameter
       if (Target != null) queryParams.Add("target", apiClient.ParameterToString(Target)); // query parameter
       if (Format != null) queryParams.Add("format", apiClient.ParameterToString(Format)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (WithSource != null) queryParams.Add("withSource", apiClient.ParameterToString(WithSource)); // query parameter
       if (WithAnnotations != null) queryParams.Add("withAnnotations", apiClient.ParameterToString(WithAnnotations)); // query parameter
       if (WithDictionary != null) queryParams.Add("withDictionary", apiClient.ParameterToString(WithDictionary)); // query parameter
       if (WithCorpus != null) queryParams.Add("withCorpus", apiClient.ParameterToString(WithCorpus)); // query parameter
       if (Options != null) queryParams.Add("options", apiClient.ParameterToString(Options)); // query parameter
       if (Encoding != null) queryParams.Add("encoding", apiClient.ParameterToString(Encoding)); // query parameter
       if (Async != null) queryParams.Add("async", apiClient.ParameterToString(Async)); // query parameter
       if (BatchId != null) queryParams.Add("batchId", apiClient.ParameterToString(BatchId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (Input != null) fileParams.Add("input", Input);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationTranslateFileGet: " + response.Content, response.Content);
      }
      return (TranslationFileResponse) apiClient.Deserialize(response.Content, typeof(TranslationFileResponse));
    }
    
    /// <summary>
    /// Translate Result Get the result of an asynchronous translation request\n\nDepending on the initial request, the response can have multiple formats:\n* `/translation/translate` initiated request\n\n    &amp;#x2192; the response will be a JSON document (model below)\n\n* `/translation/translate/file` initiated request\n\n   &amp;#x2192; the response will be either:\n\n  * The **translated document**, directly, if `source` parameters was not `auto` and `withSource` was not true\n  * A `multipart/mixed` document with the following parts:\n\n    1. **Detected language**, if request was done with `auto` source language\n\n      * Header:\n\n        `part-name: detectedLanguage`\n\n      * Body: JSON document\n        ```\n        {\n          detectedLanguage: \&quot;string\&quot;\n          detectedLanguageConfidence : number\n        }\n        ```\n\n    2. **Source document**, if request was done with `withSource`:\n\n      * Header: `part-name: source`\n      * Body: Source document\n\n    3. **Translated document**\n\n      * Header: `part-name: output`\n\n      * Body: Translated document\n\nAn error can occur in the following cases:\n* Invalid request ID\n* No result available (see request status for more information)\n* Unable to retrieve the result\n* ...\n
    /// </summary>
    /// <param name="RequestId">Request Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationResponse</returns>
    public TranslationResponse TranslationTranslateResultGet (string RequestId, string Callback) {

      
      // verify the required parameter 'RequestId' is set
      if (RequestId == null) throw new ApiException(400, "Missing required parameter 'RequestId' when calling TranslationTranslateResultGet");
      

      var path = "/translation/translate/result";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (RequestId != null) queryParams.Add("requestId", apiClient.ParameterToString(RequestId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationTranslateResultGet: " + response.Content, response.Content);
      }
      return (TranslationResponse) apiClient.Deserialize(response.Content, typeof(TranslationResponse));
    }
	
	 /// <summary>
    /// Translate Result Get the result of an asynchronous translation request\n\nDepending on the initial request, the response can have multiple formats:\n* `/translation/translate` initiated request\n\n    &amp;#x2192; the response will be a JSON document (model below)\n\n* `/translation/translate/file` initiated request\n\n   &amp;#x2192; the response will be either:\n\n  * The **translated document**, directly, if `source` parameters was not `auto` and `withSource` was not true\n  * A `multipart/mixed` document with the following parts:\n\n    1. **Detected language**, if request was done with `auto` source language\n\n      * Header:\n\n        `part-name: detectedLanguage`\n\n      * Body: JSON document\n        ```\n        {\n          detectedLanguage: \&quot;string\&quot;\n          detectedLanguageConfidence : number\n        }\n        ```\n\n    2. **Source document**, if request was done with `withSource`:\n\n      * Header: `part-name: source`\n      * Body: Source document\n\n    3. **Translated document**\n\n      * Header: `part-name: output`\n\n      * Body: Translated document\n\nAn error can occur in the following cases:\n* Invalid request ID\n* No result available (see request status for more information)\n* Unable to retrieve the result\n* ...\n
    /// </summary>
    /// <param name="RequestId">Request Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationResponse</returns>
    public async Task<TranslationResponse> TranslationTranslateResultGetAsync (string RequestId, string Callback) {

      
          // verify the required parameter 'RequestId' is set
          if (RequestId == null) throw new ApiException(400, "Missing required parameter 'RequestId' when calling TranslationTranslateResultGet");
      

      var path = "/translation/translate/result";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (RequestId != null) queryParams.Add("requestId", apiClient.ParameterToString(RequestId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationTranslateResultGet: " + response.Content, response.Content);
      }
      return (TranslationResponse) apiClient.Deserialize(response.Content, typeof(TranslationResponse));
    }
    
    /// <summary>
    /// Translate Status Get the status of an asynchronous translation request\n\nThe translation result is available when the value of the status field is `finished`.\n\nThe translation request is unsuccessful when the value of the status field is `error`.\n
    /// </summary>
    /// <param name="RequestId">Request Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationStatus</returns>
    public TranslationStatus TranslationTranslateStatusGet (string RequestId, string Callback) {

      
      // verify the required parameter 'RequestId' is set
      if (RequestId == null) throw new ApiException(400, "Missing required parameter 'RequestId' when calling TranslationTranslateStatusGet");
      

      var path = "/translation/translate/status";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (RequestId != null) queryParams.Add("requestId", apiClient.ParameterToString(RequestId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationTranslateStatusGet: " + response.Content, response.Content);
      }
      return (TranslationStatus) apiClient.Deserialize(response.Content, typeof(TranslationStatus));
    }
	
	 /// <summary>
    /// Translate Status Get the status of an asynchronous translation request\n\nThe translation result is available when the value of the status field is `finished`.\n\nThe translation request is unsuccessful when the value of the status field is `error`.\n
    /// </summary>
    /// <param name="RequestId">Request Identifier\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>TranslationStatus</returns>
    public async Task<TranslationStatus> TranslationTranslateStatusGetAsync (string RequestId, string Callback) {

      
          // verify the required parameter 'RequestId' is set
          if (RequestId == null) throw new ApiException(400, "Missing required parameter 'RequestId' when calling TranslationTranslateStatusGet");
      

      var path = "/translation/translate/status";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (RequestId != null) queryParams.Add("requestId", apiClient.ParameterToString(RequestId)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling TranslationTranslateStatusGet: " + response.Content, response.Content);
      }
      return (TranslationStatus) apiClient.Deserialize(response.Content, typeof(TranslationStatus));
    }
    
  }  
  
}
