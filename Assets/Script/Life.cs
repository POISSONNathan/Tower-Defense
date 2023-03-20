using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField]
    private int _maxHealthPoints;

    public int _healthPoints;

    public void ResetLife()
    {
        _healthPoints = _maxHealthPoints;
    }

    public void ChangeHP(int amount)
    {
        _healthPoints += amount;
    }

    public void DecreaseHP(int amount)
    {
        ChangeHP(-amount);
    }


    public bool IsDead()
    {
        return _healthPoints <= 0;
    }
}
