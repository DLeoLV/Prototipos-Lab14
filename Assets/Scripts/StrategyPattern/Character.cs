using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public IAttackBehavior _attackBehavior;
    public GameObject _currentWeapon;

    public void SetAttackBehavior(IAttackBehavior attackBehavior)
    {
        _attackBehavior = attackBehavior;
    }

    public void PerformAttack()
    {
        if (_attackBehavior != null)
        {
            if (_currentWeapon != null)
            {
                Destroy(_currentWeapon);
            }
            _attackBehavior.Attack(transform.position, transform.rotation);
        }
        else
        {
            Debug.Log("No hay arma");
        }
    }
}