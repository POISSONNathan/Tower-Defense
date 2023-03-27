using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public List<GameObject> allTower;

    public void setCollider(bool actibeOrNot)
    {
        for (int i = 0; i < allTower.Count; i++)
        {
            allTower[i].GetComponent<Collider>().enabled = actibeOrNot;
        }
    }
}
