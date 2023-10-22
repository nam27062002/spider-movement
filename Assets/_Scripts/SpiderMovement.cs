using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SpiderMovement : MonoBehaviour
{
    public Transform legTarget;
    public Transform legBody;
    public LayerMask layerMask;
    private Vector3 _currentPosition;
    RaycastHit _hit;
    void Start()
    {
        _currentPosition = legTarget.position;
    }
    void Update()
    {
        legTarget.position = _currentPosition;
        Ray ray = new Ray(legBody.position, Vector3.down); 

        if (Physics.Raycast(ray, out _hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(legBody.position, Vector3.down * _hit.distance, Color.red);
            Debug.DrawLine(legTarget.position,_hit.point,Color.yellow);
        } 
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(_hit.point, 0.01f);
    }
}
