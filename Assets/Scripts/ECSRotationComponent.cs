using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public struct ECSCubeRotationData : IComponentData
{
    // We all set these at runtime, so [NonSerialized]
    [NonSerialized] public int speed;

}

public class ECSRotationComponent : ComponentDataWrapper<ECSCubeRotationData>
{
}
