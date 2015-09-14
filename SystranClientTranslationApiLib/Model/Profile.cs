using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.TranslationClientLib.Model {

  /// <summary>
  /// Profile
  /// </summary>
  [DataContract]
  public class Profile {
    
    /* Profile identifier */
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /* Localization of the profile name */
    [DataMember(Name="localization", EmitDefaultValue=false)]
    public Object Localization { get; set; }

    
    /* Name */
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /* Source */
    [DataMember(Name="source", EmitDefaultValue=false)]
    public string Source { get; set; }

    
    /* Target */
    [DataMember(Name="target", EmitDefaultValue=false)]
    public string Target { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Profile {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Localization: ").Append(Localization).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Source: ").Append(Source).Append("\n");
      
      sb.Append("  Target: ").Append(Target).Append("\n");
      
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