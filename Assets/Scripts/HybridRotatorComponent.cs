using UnityEngine;
using Unity.Entities;

public class HybridRotatorComponent : ComponentSystem
{
    private ComponentGroupArray<Components> eList;

    private bool hasEntities = false;

    public struct Components
    {
        public DataBehavior data;
        public Transform transform;

    }

    protected override void OnUpdate()
    {
        int speed = 100;

        // Only do a getEntities when we need to.
        if (!hasEntities && eList.Length < 1)
        {
            eList = GetEntities<Components>();
            hasEntities = true;
        }

        float d = Time.deltaTime;

        int count = eList.Length;
        for (int i = 0; i < count; i++)
        {
            Components c = eList[i];

            c.transform.Rotate(0f, c.data.speed * d, 0f);
        }
    }
}
