using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : DetectionCompatible
{

    public List<Enemy> EnemiesToTarget;

    [SerializeField]
    private Bullet _bulletPrefab;

    private void Start()
    {
        StartCoroutine(InflictDamage());

    }

    public override void OnDetection(Enemy enemy)
    {
        EnemiesToTarget.Add(enemy);
        enemy.TowersAttackingMe.Add(this);
    }

    public override void OnDetectionEnd(Enemy enemy)
    {
        EnemiesToTarget.Remove(enemy);
        enemy.TowersAttackingMe.Remove(this);
    }

    //Temporaire 
    private IEnumerator InflictDamage()
    {
        while (true)
        {

            yield return new WaitUntil(DoIHaveAValidTarget);

            var targetEnemy = EnemiesToTarget[0];

            var bullet = Instantiate(_bulletPrefab, this.transform);
            bullet.transform.LookAt(targetEnemy.transform);

            yield return new WaitForSeconds(0.5f);
        }
    }


    private bool DoIHaveAValidTarget()
    {
        bool isMyListNotNull = EnemiesToTarget != null;
        bool isMyListNotEmpty = EnemiesToTarget.Count > 0;

        return isMyListNotNull && isMyListNotEmpty;
    }
}
