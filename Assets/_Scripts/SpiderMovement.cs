using UnityEngine;
public class SpiderMovement : MonoBehaviour
{
    public Transform legTarget;
    public Transform legCurrent;
    public LayerMask layerMask;
    private Vector3 _currentPosition;
    public float _distance = 0.1f;
    RaycastHit _hit;
    void Start()
    {
        _currentPosition = legTarget.position;
    }
    
    void Update()
    {
        legTarget.position = _currentPosition;
        if (Vector3.Distance(legTarget.position, legCurrent.position) > _distance)
        {
            Vector3 A = legTarget.position;
            Vector3 B = legCurrent.position;

            // Tính tâm O của đường tròn
            Vector3 O = (A + B) / 2;

            // Tính bán kính R của đường tròn
            float R = Vector3.Distance(A, O);

            // Tính góc hiện tại dựa trên thời gian
            float angle = Time.deltaTime; // Thay đổi giá trị này để làm cho chuyển động nhanh hơn hoặc chậm hơn

            // Tính tọa độ mới dựa trên góc và bán kính R
            Vector3 offset = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle)) * R;
            legCurrent.position = O + offset;
        }
    }
    
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        var position = legCurrent.position;
        
        Gizmos.DrawSphere(position,0.01f);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(position, _distance);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(legTarget.position,position);
    }
    
}
