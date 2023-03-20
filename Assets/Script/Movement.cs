using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    public void SimpleMovement(Vector3 direction)
    {
        //Temporaire
        transform.position += (direction*_speed*Time.deltaTime);
    }
}
