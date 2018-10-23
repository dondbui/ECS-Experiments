using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class ECSSpawner : MonoBehaviour
{
    public EntityManager manager;

    // Use this for initialization
    void Start ()
    {
        manager = World.Active.GetOrCreateManager<EntityManager>();

        GameObject refGO = Resources.Load("Prefabs/ecsCube") as GameObject;

        NativeArray<Entity> entities = new NativeArray<Entity>(Config.NUM_CUBES, Allocator.Temp);

        // This strips all of the components FROM a game object to make a new Entity 
        manager.Instantiate(refGO, entities);

        for (int i = 0; i < entities.Length; i++)
        {
            Position p = new Position();
            float3 f = new float3();
            f.x = UnityEngine.Random.Range(-50f, 50f);
            f.y = UnityEngine.Random.Range(-50f, 50f);
            f.z = UnityEngine.Random.Range(-50f, 50f);

            p.Value = f;

            manager.SetComponentData(entities[i], p);

            if (manager.HasComponent<ECSCubeRotationData>(entities[i]))
            {
                manager.SetComponentData(entities[i], new ECSCubeRotationData { speed = 10});
            }

                //inst.transform.position = new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f), Random.Range(-50f, 50f));
        }
    }
}
