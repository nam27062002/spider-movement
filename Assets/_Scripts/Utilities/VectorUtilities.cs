using UnityEngine;

namespace Utilities
{
    public static class VectorUtilities
    {

        public static Vector3 GetApexPoint(Vector3 startPoint, Vector3 endPoint, float height, bool isDirectionUp = true)
        {
            Vector3 midPoint = GetMidPoint(startPoint, endPoint);
            return isDirectionUp
                ? midPoint + GetNormalVector(startPoint, endPoint) * height
                : midPoint - GetNormalVector(startPoint, endPoint) * height;
        }
        
        private static Vector3 GetNormalVector(Vector3 startPoint, Vector3 endPoint)
        {
            Vector3 direction = GetDirectionVector(startPoint, endPoint);
            return Vector3.Cross(direction, Vector3.right).normalized;
        }
        
        private static Vector3 GetDirectionVector(Vector3 startPoint, Vector3 endPoint)
        {
            return (endPoint - startPoint).normalized;
        }
        
        private static Vector3 GetMidPoint(Vector3 startPoint, Vector3 endPoint)
        {
            return (startPoint + endPoint) / 2;
        }
        

        
    }
}