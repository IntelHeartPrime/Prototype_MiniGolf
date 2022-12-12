using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    private Rigidbody _rb;
    private LineRenderer _lineRenderer;
    public List<Vector3> testPos;

    // Start is called before the first frame update
    void Start()
    {
        _rb = this.transform.GetComponent<Rigidbody>();
        _lineRenderer = this.transform.GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        _lineRenderer.positionCount = testPos.Count;
        
        for (int i = 0; i < testPos.Count; i++)
        {
            UnityEngine.Debug.Log(i);
            UnityEngine.Debug.Log(testPos.Count);
            _lineRenderer.SetPosition(i, testPos[i]);
        }
    }

}
