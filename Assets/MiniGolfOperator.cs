using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGolfOperator : MonoBehaviour
{
    private GameObject ballPrefab;

    // Start is called before the first frame update
    void Start()
    {
        ballPrefab = GameObject.Find("ball").gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // 实现轨迹线要使用 Simulate
    // shot the ball
}