package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.model.Definition1;
import java.util.ArrayList;
import java.util.List;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * Definition 2
 */
@ApiModel(description = "Definition 2")

public class Definition2   {
  @JsonProperty("Definition1")
  private List<Definition1> definition1 = null;

  @JsonProperty("Id")
  private String id = null;

  public Definition2 definition1(List<Definition1> definition1) {
    this.definition1 = definition1;
    return this;
  }

  public Definition2 addDefinition1Item(Definition1 definition1Item) {
    if (this.definition1 == null) {
      this.definition1 = new ArrayList<Definition1>();
    }
    this.definition1.add(definition1Item);
    return this;
  }

   /**
   * nested Definition1 array
   * @return definition1
  **/
  @ApiModelProperty(value = "nested Definition1 array")

  @Valid
  public List<Definition1> getDefinition1() {
    return definition1;
  }

  public void setDefinition1(List<Definition1> definition1) {
    this.definition1 = definition1;
  }

  public Definition2 id(String id) {
    this.id = id;
    return this;
  }

   /**
   * Content Id for lookup
   * @return id
  **/
  @ApiModelProperty(value = "Content Id for lookup")

  @Valid
  public String getId() {
    return id;
  }

  public void setId(String id) {
    this.id = id;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Definition2 definition2 = (Definition2) o;
    return Objects.equals(this.definition1, definition2.definition1) &&
        Objects.equals(this.id, definition2.id);
  }

  @Override
  public int hashCode() {
    return Objects.hash(definition1, id);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Definition2 {\n");
    
    sb.append("    definition1: ").append(toIndentedString(definition1)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

