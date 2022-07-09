using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// 委托 -> event -> 事件 ， 事件还不是泛型 ,泛型是事件的基础，或者说事件是一个特殊的委托变量
public class TestingEvents : MonoBehaviour
{   
    public event EventHandler<OnSpacePressedEventArgs> OnSpacePressed;   // 此EventHandler具备特殊泛型，此泛型必要
    
    // EventArgs
    public class OnSpacePressedEventArgs: EventArgs
    {
        public int spaceCount;
    }

    public event TestEventDelegate OnFloatEvent;  //将委托包装为一个event  So Good 
    //创建一个委托
    public delegate void TestEventDelegate(float f);
    
    private int spaceCount;
    public UnityEvent OnUnityEvent;   // UnityEvent 允许开发者通过GameObject拖拽的方式可视化的建立委托，方法覆盖各类
    
    
    //Action
    public event Action<bool, int> OnActionEvent; 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            //Space pressed
            // so cool Rider is cool tool for Unity Development 
            this.spaceCount++;
            OnSpacePressed?.Invoke(this, new OnSpacePressedEventArgs { spaceCount = spaceCount});
            
            OnFloatEvent?.Invoke(5.5f);
            OnActionEvent?.Invoke(true, 100);
            OnUnityEvent?.Invoke();
        }
    }
}
