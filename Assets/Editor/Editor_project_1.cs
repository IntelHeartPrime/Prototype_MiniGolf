using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// 拓展 project菜单
public class Editor_project_1
{
    
    // 关键是Assets/xxxx, 被标记方法使用static函数
    [MenuItem("Assets/My Tools/Tools 1", false, 2)]
    static void MyTools1()
    {
        Debug.Log(Selection.activeObject.name);
    }
    
    [MenuItem("Assets/My Tools/Tools 2", false, 1)]
    static void MyTools2()
    {
        Debug.Log(Selection.activeObject.name);
    }
    

}
