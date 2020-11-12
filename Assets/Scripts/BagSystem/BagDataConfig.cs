using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using UnityEngine.Playables;

/// <summary>
/// 保存背包列表所有数据
/// </summary>
public class BagDataConfig : IJsonStringConvert
{
    private List<BagData> _datas = new List<BagData>();
    /// <summary>
    /// 背包物品列表
    /// </summary>
    public List<BagData> Datas { get => _datas; set => _datas = value; }

    void IJsonStringConvert.ToObj(string json)
    {
        Datas = JsonMapper.ToObject<List<BagData>>(json);
    }

    string IJsonStringConvert.ToJson()
    {
        return JsonMapper.ToJson(Datas);
    }
}


/// <summary>
/// 背包的物品数据
/// </summary>
public class BagData
{
    /// <summary>
    /// 物品所属分类的Id
    /// </summary>
    public int CategoryId;
    /// <summary>
    /// 最大叠加数
    /// </summary>
    public int StackTotal;
    /// <summary>
    /// 物品名称
    /// </summary>
    public string Name;
    /// <summary>
    /// 物品图片路径
    /// </summary>
    public string IconPath;
}

/// <summary>
/// 背包分类数据
/// </summary>
public class BagCategory
{
    /// <summary>
    /// 当前分类的id
    /// </summary>
    public int Id;
    /// <summary>
    /// 分类名
    /// </summary>
    public string Name;
    /// <summary>
    /// 分类的图标地址
    /// 没有图标则留空
    /// </summary>
    public string Path;
}

/// <summary>
/// 背包中一个条目的数据
/// </summary>
public class BagDataItem
{
    public BagData Data;
    /// <summary>
    /// 当前叠加数
    /// </summary>
    public int StackCurrent;
}

/// <summary>
/// 背包整体数据
/// </summary>
public class Bag
{
    public List<BagCategory> Category;
    public List<BagDataItem> Data;
}
