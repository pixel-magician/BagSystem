using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IJsonStringConvert
{
    void ToObj(string json);
    string ToJson();
}
