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

    private void Start()
    {
        CreatePhysicsScene();
    }

    // create PhysicsScene, copy physics gameobjects into it 
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
}
