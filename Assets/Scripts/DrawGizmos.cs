using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmos : MonoBehaviour
{
    [SerializeField] private Color _color = Color.magenta;
    [SerializeField] private Transform _transform;


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = _color;
        Gizmos.DrawWireCube(_transform.position, _transform.localScale);
    }
}
