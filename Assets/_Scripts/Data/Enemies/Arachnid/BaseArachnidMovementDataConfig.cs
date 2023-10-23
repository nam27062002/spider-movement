using System;
using UnityEngine;

namespace Data.Enemies.Arachnid
{
    [Serializable]
    public class BaseArachnidMovementDataConfig
    {
        [Range(1f,10f)] public float baseSpeed = 5;
        [Range(1f,2f)] public float speedModifier = 1f;
        [Range(0f,1f)] public float strideLength = 0.5f;
        [Range(0f,1f)] public float maxHeightFromGround = 0.5f;
    }
}