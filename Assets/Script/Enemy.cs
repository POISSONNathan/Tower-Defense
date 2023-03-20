using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Movement _movement;
    public Life EnemyLife;
    
    // Start is called before the first frame update
    void Start()
    {
        EnemyLife.ResetLife();
    }

    // Update is called once per frame
    void Update()
    {
        //Temporaire
        _movement.SimpleMovement(Vector3.left);
    }


}
