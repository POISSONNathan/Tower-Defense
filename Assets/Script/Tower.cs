using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : DetectionCompatible
{

    [SerializeField]
    private Bullet _bulletPrefab;
    public override void OnDetection(Enemy enemy)
    {
        StartCoroutine(InflictDamage(enemy));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Temporaire 
    private IEnumerator InflictDamage(Enemy enemy)
    {
        while (enemy != null)
        {
            var bullet = Instantiate(_bulletPrefab, this.transform);
            bullet.transform.LookAt(enemy.transform);

            yield return new WaitForSeconds(0.5f);
        }
    }
}
