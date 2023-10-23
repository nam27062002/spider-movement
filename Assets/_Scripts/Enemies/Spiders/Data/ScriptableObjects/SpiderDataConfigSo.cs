using Data.Enemies.Arachnid;
using UnityEngine;
namespace ScriptableObject.Enemies.Arachnid
{
    [CreateAssetMenu()]
    public class SpiderDataConfigSo : UnityEngine.ScriptableObject
    {
        public BaseArachnidMovementDataConfig spiderMovementConfig;
        
    }
}