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
  public class SupportedLanguageResponse {
    
    /* Warning at request level */
    [DataMember(Name="warning", EmitDefaultValue=false)]
    public string Warning { get; set; }

    
    /* Error at request level */
    [DataMember(Name="error", EmitDefaultValue=false)]
    public string Error { get; set; }

    
    /* Array of language pairs */
    [DataMember(Name="languagePairs", EmitDefaultValue=false)]
    public List<LanguagePair> LanguagePairs { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SupportedLanguageResponse {\n");
      
      sb.Append("  Warning: ").Append(Warning).Append("\n");
      
      sb.Append("  Error: ").Append(Error).Append("\n");
      
      sb.Append("  LanguagePairs: ").Append(LanguagePairs).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}