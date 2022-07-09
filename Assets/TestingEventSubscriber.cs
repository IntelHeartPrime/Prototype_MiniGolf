using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TestingEventSubscriber : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        TestingEvents testingEvents = GetComponent<TestingEvents>();
        testingEvents.OnSpacePressed += Testing_OnSpacePressed;
        testingEvents.OnFloatEvent += TestingEvent_OnFloatEvent;
        testingEvents.OnActionEvent += TestingEvent_ActionEvent;
    }

    private void TestingEvent_ActionEvent(bool arg1, int arg2)
    {
        Debug.Log(arg1 + " " + arg2);
    }
    private void TestingEvent_OnFloatEvent(float f)
    {
        Debug.Log("Float " + f);
    }
    
    
    // Subscriber 的必须格式吗？ 两个参数： 1.sender 2.EventArgs
    private void Testing_OnSpacePressed(object sender,  TestingEvents.OnSpacePressedEventArgs e)
    {
        //TestingEvents.OnSpacePressedEventArgs e = (TestingEvents.OnSpacePressedEventArgs)eventArgs;
        Debug.Log("Space!" + e.spaceCount);
        
        //TestingEvents testingEvents = GetComponent<TestingEvents>();
        //testingEvents.OnSpacePressed -= this.Testing_OnSpacePressed;
        //Debug.Log("  delete subscribe Event ");
        
    }

    public void Testing_OnUnityEvent()
    {
        Debug.Log("so carzy -- UnityEvents");
    }
    
}
