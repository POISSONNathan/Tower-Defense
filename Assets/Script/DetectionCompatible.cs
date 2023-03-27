using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCompatible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var _enemyComponent = other.GetComponent<Enemy>();
        if (_enemyComponent != null)
        {
            OnDetection(_enemyComponent);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        var _enemyComponent = other.GetComponent<Enemy>();
        if (_enemyComponent != null)
        {
            OnDetectionEnd(_enemyComponent);
        }
    }
    public virtual void OnDetection(Enemy enemy)
    {
        //Do stuff withEnnemy
    }
    public virtual void OnDetectionEnd(Enemy enemy)
    {
        //Do stuff withEnnemy
    }
}
