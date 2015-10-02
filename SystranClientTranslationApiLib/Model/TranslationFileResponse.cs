using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.TranslationClientLib.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
    //public class TranslationFileResponse : MultipartResponse {
    public class TranslationFileResponse
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

    /* Translated text */
    /* Outputs of translation */
    [DataMember(Name = "outputs", EmitDefaultValue = false)]
    public List<TranslationOutput> Outputs { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TranslationFileResponse {\n");
      
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