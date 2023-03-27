using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : DetectionCompatible
{
    [SerializeField]
    private Movement _movement;
    [SerializeField]
    private int _dammage = 2;

    [SerializeField]
    private float _lifeSpan = 5.0f;
    private float timer;


    public override void OnDetection(Enemy enemy)
    {
        enemy.EnemyLife.DecreaseHP(_dammage);

        //Detruire les bullet au contact d'un ennemy.
        Destroy(gameObject);
    }



    // Update is called once per frame
    void Update()
    {
        //Je me deplace
        _movement.SimpleMovement(transform.forward);

        //Check si j'ai vecu assez longtemps
        CheckLifeSpan();

    }

    private void CheckLifeSpan()
    {
        timer += Time.deltaTime;
        if (timer >= _lifeSpan)
        {
            Destroy(gameObject);
        }
    }


}
