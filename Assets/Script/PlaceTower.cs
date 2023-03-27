 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    public GameObject prefabTower;

    public GameManager GameManager;

    private void OnMouseDown()
    {
        var newTower = Instantiate(prefabTower, transform.position, Quaternion.identity);
        GameManager.allTower.Add(newTower);
    }
}
