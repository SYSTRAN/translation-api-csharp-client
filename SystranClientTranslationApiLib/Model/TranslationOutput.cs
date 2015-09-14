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
  public class TranslationOutput {
    
    /* Warning at output level */
    [DataMember(Name="warning", EmitDefaultValue=false)]
    public string Warning { get; set; }

    
    /* Error at output level */
    [DataMember(Name="error", EmitDefaultValue=false)]
    public string Error { get; set; }

    
    /* Result of the automatic language detection if `auto` was specified as source language */
    [DataMember(Name="detectedLanguage", EmitDefaultValue=false)]
    public string DetectedLanguage { get; set; }

    
    /* Automatic language detection confidence */
    [DataMember(Name="detectedLanguageConfidence", EmitDefaultValue=false)]
    public double? DetectedLanguageConfidence { get; set; }

    
    /* Translated text */
    [DataMember(Name="output", EmitDefaultValue=false)]
    public string Output { get; set; }

    
    /* Retranslation of output in source language, if backTranslation was specified */
    [DataMember(Name="backTranslation", EmitDefaultValue=false)]
    public string BackTranslation { get; set; }

    
    /* Source text, if withSource was specified */
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TranslationOutput {\n");
      
      sb.Append("  Warning: ").Append(Warning).Append("\n");
      
      sb.Append("  Error: ").Append(Error).Append("\n");
      
      sb.Append("  DetectedLanguage: ").Append(DetectedLanguage).Append("\n");
      
      sb.Append("  DetectedLanguageConfidence: ").Append(DetectedLanguageConfidence).Append("\n");
      
      sb.Append("  Output: ").Append(Output).Append("\n");
      
      sb.Append("  BackTranslation: ").Append(BackTranslation).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
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