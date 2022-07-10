using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Editor_project_btn1
{

    [InitializeOnLoadMethod]  // 在方法前面添加[InitializeOnLoadMethod]表示此方法会在C# 代码每次编译完成后首先调用。
    static void InitializeOnLoadMethod()
    {
        EditorApplication.projectWindowItemOnGUI = delegate(string guid, Rect selectionRect)
        {
            if (Selection.activeObject &&
                guid == AssetDatabase.AssetPathToGUID((AssetDatabase.GetAssetPath(Selection.activeObject))))
            {
                // 开始调整拓展按钮区域
                // 此处疑问？为什么一定要用到 「guid == ~ 」 这段判断呢？ 目的是什么呢

                // 使用句柄绘制btn吗？
                float width = 50f;
                selectionRect.x += (selectionRect.width - width);
                selectionRect.y += 2f;
                selectionRect.width = width;
                GUI.color = Color.red;

                // 点击事件
                if (GUI.Button(selectionRect, "click"))
                {
                    Debug.LogFormat("click: {0}", Selection.activeObject.name);
                }

                GUI.color = Color.white;
            }
        };
    }
}
