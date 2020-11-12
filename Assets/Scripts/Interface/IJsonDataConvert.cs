using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IJsonDataConvert
{
    void ToObj(JsonData json);
    JsonData ToJson();
}
