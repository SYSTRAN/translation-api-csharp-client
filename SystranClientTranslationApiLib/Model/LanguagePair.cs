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
  public class LanguagePair {
    
    /* Source language */
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    
    /* Target language */
    [DataMember(Name="target", EmitDefaultValue=false)]
    public string Target { get; set; }

    
    /* Array of profile identifiers */
    [DataMember(Name="profiles", EmitDefaultValue=false)]
    public List<ProfileId> Profiles { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LanguagePair {\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Target: ").Append(Target).Append("\n");
      
      sb.Append("  Profiles: ").Append(Profiles).Append("\n");
      
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