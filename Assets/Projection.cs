using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projection : MonoBehaviour
{
    private Scene _simulationScene;
    private PhysicsScene _physicsScene;
    [SerializeField] private Transform _obstacleParent;

    [SerializeField] private GameObject _ball;
    
    private void Start()
    {
        CreatePhysicsScene();
        SimulateTrajectory(_ball.GetComponent<Ball>(), _ball.transform.position, new Vector3(0, 10, 10));
    }

    // create PhysicsScene, copy physics game objects into it 
    void CreatePhysicsScene()
    {
        _simulationScene =
            SceneManager.CreateScene("Simulation", new CreateSceneParameters(LocalPhysicsMode.Physics3D));
        _physicsScene = _simulationScene.GetPhysicsScene();

        foreach (Transform obj in _obstacleParent)
        {
            var ghostObj = Instantiate(obj.gameObject, obj.position, obj.rotation);
            ghostObj.GetComponent<Renderer>().enabled = false;
            SceneManager.MoveGameObjectToScene(ghostObj, _simulationScene);
        }
    }

    [SerializeField] private LineRenderer _line;
    [SerializeField] private int _maxPhysicsFrameIterations;
    
    public void SimulateTrajectory(Ball balLPrefab, Vector3 pos, Vector3 velocity)
    {   
        Debug.Log(pos);
        // create Ball and move it into PhysicsScene
        var ghostObj = Instantiate(balLPrefab, pos, Quaternion.identity);
        ghostObj.GetComponent<Renderer>().enabled = false;
        SceneManager.MoveGameObjectToScene(ghostObj.gameObject, _simulationScene);
        
        ghostObj.Init(velocity);

        _line.positionCount = _maxPhysicsFrameIterations;
        for (int i = 0; i < _maxPhysicsFrameIterations; i++)
        {
            _physicsScene.Simulate(Time.deltaTime);
            _line.SetPosition(i, ghostObj.transform.position);
        }
        
        Destroy(ghostObj.gameObject);
    }

    private void Update()
    {
        //SimulateTrajectory(_ball.GetComponent<Ball>(), _ball.transform.position, new Vector3(0, 10, 10));
    }
}
