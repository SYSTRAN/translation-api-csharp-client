using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.TranslationClientLib.Model {

  /// <summary>
  /// By default (synchronous mode), the response will be a JSON object containing the result of the translation.\n\n```\n  {\n    \&quot;warning\&quot;: \&quot;\&quot;, /* Warning at request level */\n    \&quot;error\&quot;: \&quot;\&quot;, /* Error at request level */\n    \&quot;outputs\&quot;: [\n       {\n           \&quot;warning\&quot;: \&quot;\&quot;, /* Warning at input level */\n           \&quot;error\&quot;: \&quot;\&quot;, /* Error at input level */\n           \&quot;detectedLanguage\&quot;: \&quot;fr\&quot;, /* Result of the automatic language detection if selected */\n           \&quot;detectedLanguageConfidence\&quot;: 0.73, /* automatic language detection confidence if selected */\n           \&quot;output\&quot;: \&quot;translated text 1\&quot;, /* Translate text */\n           \&quot;backTranslation\&quot;: \&quot;retranslation of output in fr\&quot;\n       },\n       {\n           \&quot;warning\&quot;: \&quot;\&quot;, /* Warning at input level */\n           \&quot;error\&quot;: \&quot;\&quot;, /* Error at input level */\n           \&quot;detectedLanguage\&quot;: \&quot;fr\&quot;, /* Result of the automatic language detection if selected */\n           \&quot;detectedLanguageConfidence\&quot;: 0.75, /* automatic language detection confidence if selected */\n           \&quot;output\&quot;: \&quot;translated text 2\&quot; /* Translate text */\n           \&quot;backTranslation\&quot;: \&quot;retranslation of output in fr\&quot;\n       }\n    ]\n  }\n```\n\nIn asynchronous mode, the response will be a JSON containing a request identifier. This identifier can then be used to poll the request status and its result when completed.\n\n```\n{\n   \&quot;error\&quot;: \&quot;\&quot;, /* Error at request level */\n   \&quot;requestId\&quot;: \&quot;54a3d860e62ea467b136eddb\&quot; /* Request identifier to use to get the status, the result of the request and to cancel it */\n}\n```\n
  /// </summary>
  [DataContract]
 // public class TranslationResponse : MultipartResponse {
        public class TranslationResponse
        {

            /* Warning at request level */
            [DataMember(Name="warning", EmitDefaultValue=false)]
    public string Warning { get; set; }

    
    /* Error at request level */
    [DataMember(Name="error", EmitDefaultValue=false)]
    public string Error { get; set; }

    
    /* Request identifier to use to get the status, the result of the request and to cancel it in asynchronous mode */
    [DataMember(Name="requestId", EmitDefaultValue=false)]
    public string RequestId { get; set; }

    
    /* Outputs of translation */
    [DataMember(Name="outputs", EmitDefaultValue=false)]
    public List<TranslationOutput> Outputs { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TranslationResponse {\n");
      
      sb.Append("  Warning: ").Append(Warning).Append("\n");
      
      sb.Append("  Error: ").Append(Error).Append("\n");
      
      sb.Append("  RequestId: ").Append(RequestId).Append("\n");
      
      sb.Append("  Outputs: ").Append(Outputs).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}