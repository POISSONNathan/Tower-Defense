using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : DetectionCompatible
{
    [SerializeField]
    private Movement _movement;
    [SerializeField]
    private int _dammage;

    private float lifeSpan = 5;
    private float timer;

    public override void OnDetection(Enemy enemy)
    {
        enemy.EnemyLife.DecreaseHP(_dammage);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        _movement.SimpleMovement(transform.forward);

        timer += Time.deltaTime;
        if (timer > lifeSpan)
        {
            Destroy(gameObject);
        }

    }
}
