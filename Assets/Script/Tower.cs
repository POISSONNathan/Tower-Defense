using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : DetectionCompatible
{

    [SerializeField]
    private Bullet _bulletPrefab;

    public List<Enemy> listEnemy;

    private bool isShoot = false;

    public override void OnDetection(Enemy enemy)
    {
        listEnemy.Add(enemy);
        if (isShoot == false)
        {
            isShoot = true;
            StartCoroutine(InflictDamage());
        }
    }

    public override void OnExitDetection(Enemy enemy)
    {
        listEnemy.Remove(enemy);
        if (listEnemy.Count != 0)
        {
            isShoot = false;
        }
    }

    private IEnumerator InflictDamage()
    {
        while (listEnemy.Count != 0)
        {
            var bullet = Instantiate(_bulletPrefab, this.transform);
            bullet.transform.LookAt(listEnemy[0].transform);

            if (listEnemy[0].EnemyLife.IsDead())
            {
                Destroy(listEnemy[0].gameObject);
                listEnemy.Remove(listEnemy[0]);
            }

            yield return new WaitForSeconds(0.5f);
        }
    }
}
