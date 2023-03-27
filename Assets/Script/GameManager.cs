using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> allTower;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            startGame();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            endGame();
        }
    }

    void startGame()
    {
        setCollider(true);
    }

    void endGame()
    {
        setCollider(false);
    }

    public void setCollider(bool actibeOrNot)
    {
        for (int i = 0; i < allTower.Count; i++)
        {
            allTower[i].GetComponent<Collider>().enabled = actibeOrNot;
        }
    }
}
