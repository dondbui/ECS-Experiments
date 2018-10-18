using UnityEngine;

public class HybridCubeSpawner : MonoBehaviour
{
    [Tooltip("How many rotating cubes do we plan on spawning")]
    public const int NUM_TO_SPAWN = 50000;


    public void Start()
    {
        for (int i = 0; i < NUM_TO_SPAWN; i++)
        {
            GameObject inst = Instantiate(Resources.Load("Prefabs/hybridCube")) as GameObject;

            inst.transform.position = new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f), Random.Range(-50f, 50f));
        }
    }
}
