using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlockLogic : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;
    private bool movingToEnd = true;
 

    // Update is called once per frame
    void FixedUpdate()
    {
        if (movingToEnd)
        {
            // Move towards Point B
            transform.position = Vector3.MoveTowards(transform.position, _endPoint.position, _speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, _endPoint.position) < 0.1f)
            {
                movingToEnd = false; // Switch direction
            }
        }
        else
        {
            // Move towards Point A
            transform.position = Vector3.MoveTowards(transform.position, _startPoint.position, _speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, _startPoint.position) < 0.1f)
            {
                movingToEnd = true; // Switch direction
            }
        }
    }
}
