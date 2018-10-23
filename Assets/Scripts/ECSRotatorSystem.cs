using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class ECSRotatorSystem : ComponentSystem
{

    public struct Filter
    {
        public ComponentDataArray<Position> positions;
        public ComponentDataArray<Rotation> rotations;
        [ReadOnly] public ComponentDataArray<ECSCubeRotationData> data;
        public readonly int Length;
    }

    [Inject]
    Filter components;

    protected override void OnUpdate()
    {
        float deltaTime = Time.deltaTime;

        for (int i = 0; i < components.Length; i++)
        {
            Rotation r = components.rotations[i];

            quaternion q = quaternion.RotateY(Time.frameCount/10f);

            r.Value = q;
            components.rotations[i] = r;
        }
    }
}
