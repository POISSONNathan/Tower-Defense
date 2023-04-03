using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{

    [SerializeField]
    private Tower _towerPrefab;

    private bool doIHaveATower;

    public void CreateTower()
    {
        if (!doIHaveATower)
        {
            Instantiate(_towerPrefab, transform.position, Quaternion.Euler(Vector3.zero));
            doIHaveATower = true;
        }
    }
}
