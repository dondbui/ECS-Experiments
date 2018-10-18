using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class HybridRotatorComponent : ComponentSystem
{
    struct Components
    {
        public DataBehavior data;
        public Transform transform;

    }

    protected override void OnUpdate()
    {
        int speed = 100;

        ComponentGroupArray<Components> eList = GetEntities<Components>();

        float d = Time.deltaTime;

        int count = eList.Length;
        for (int i = 0; i < count; i++)
        {
            Components c = eList[i];

            c.transform.Rotate(0f, c.data.speed * d, 0f);
        }
    }
}
