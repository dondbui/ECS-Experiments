using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public void Start ()
    {
        for (int i = 0; i < Config.NUM_CUBES; i++)
        {
            GameObject inst = Instantiate(Resources.Load("Prefabs/behaviorCube")) as GameObject;

            inst.transform.position = new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f), Random.Range(-50f, 50f));
        }
    }
}
