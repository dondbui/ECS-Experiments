using UnityEngine;

public class HybridCubeSpawner : MonoBehaviour
{
    public void Start()
    {
        for (int i = 0; i < Config.NUM_CUBES; i++)
        {
            GameObject inst = Instantiate(Resources.Load("Prefabs/hybridCube")) as GameObject;

            inst.transform.position = new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f), Random.Range(-50f, 50f));
        }
    }
}
