using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    [SerializeField]
    private LayerMask _acceptedLayer;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckForSpawnerAndCreateTower();
        }
    }

    public void CheckForSpawnerAndCreateTower()
    {
        var mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
        var mouseStartingPoint = Camera.main.ScreenToWorldPoint(mousePosition);

        if (Physics.Raycast(Camera.main.transform.position, mouseStartingPoint - Camera.main.transform.position,out var HitTower ,120, _acceptedLayer))
        {
            if (HitTower.transform.GetComponent<TowerSpawner>())
            {
                HitTower.transform.GetComponent<TowerSpawner>().CreateTower();
            }
        }
    }
}
