using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public IAttackBehavior _attackBehavior;

    public void SetAttackBehavior(IAttackBehavior attackBehavior)
    {
        _attackBehavior = attackBehavior;
    }

    public void PerformAttack()
    {
        _attackBehavior.Attack(transform.position, transform.rotation);
    }
} 