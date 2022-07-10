using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Editor_project_processor1 : UnityEditor.AssetModificationProcessor
{
    // 监听资源的变化，重写各类监听方法即可达成效果, 需要继承的是 UnityEditor.AssetModificationProcessor 哦
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod()
    {
        //资源发生任何变化，log
        EditorApplication.projectChanged += () => Debug.Log("Changed");   // Lamuda script
        
    }
    
    /*
    // 监听鼠标左键，打开资源事件
    public static bool IsOpenForEdit(string[] assetPath, List<string> outNotEditablePaths, StatusQueryOptions statusQueryOptions)
    {
        Debug.LogFormat("assetPath: {0}", assetPath);
        
        // true 标示资源可以打开，false标识不允许在Unity中打开该资源
        return true;
    }
    
    // 监听资源被创建事件 
    public static void OnWillCreateAsset(string path)
    {
        Debug.LogFormat("path: {0}", path);
    }
    
    // 监听资源即将被保存事件
    public static string[] OnWillSaveAssets(string[] paths)
    {
        if (paths != null)
        {
            Debug.LogFormat("path: {0}", string.Join(",",paths));
        }

        return paths;
    }
    
    
    // 坏了，写完这些监听后，原来的移动却不好使了，也就是说资源无法移动了， are u kidding me ？  可以认为是bug吧
    // 监听资源即将被移动事件
    public static AssetMoveResult OnWillMoveAsset(string sourcePath, string destinationPath)
    {
        Debug.LogFormat("from: {0} to : {1}", sourcePath, destinationPath);
        // DidMove 标示该资源可以被移动
        return AssetMoveResult.DidMove;
    }
    
    
    //   坏了，写完这些监听后，原来的移动却不好使了，也就是说资源无法删除了， are u kidding me ？ 

    // 监听资源即将被删除事件
    public static AssetDeleteResult OnWillDeleteAsset(string assetPath, RemoveAssetOptions options)
    {
        Debug.LogFormat("delete: {0}", assetPath);
        // DidDelete 标识资源可以被删除
        return AssetDeleteResult.DidDelete;
    }
    */
}   
