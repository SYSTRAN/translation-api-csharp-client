using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.TranslationClientLib.Model {

  /// <summary>
  /// Profile identifier
  /// </summary>
  [DataContract]
  public class ProfileId {
    
    /* Profile identifier */
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /* Public or private profile */
    [DataMember(Name="private", EmitDefaultValue=false)]
    public bool? Private { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProfileId {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Private: ").Append(Private).Append("\n");
      
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