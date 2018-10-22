using UnityEngine;

public class SingleBehaviorComponent : MonoBehaviour
{
    public GameObject[] allCubes;

    // Use this for initialization
    void Start ()
    {
        allCubes = new GameObject[Config.NUM_CUBES];

        for (int i = 0; i < Config.NUM_CUBES; i++)
        {
            GameObject inst = Instantiate(Resources.Load("Prefabs/basicCube")) as GameObject;

            allCubes[i] = inst;

            inst.transform.position = new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f), Random.Range(-50f, 50f));
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        int speed = 100;

        float d = Time.deltaTime;

        int count = allCubes.Length;
        for (int i = 0; i < count; i++)
        {
            GameObject go = allCubes[i];

            go.transform.Rotate(0f, speed * d, 0f);
        }
    }
}
