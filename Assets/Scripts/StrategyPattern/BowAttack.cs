using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowAttack : IAttackBehavior
{
    private GameObject _prefab;

    public BowAttack(GameObject prefab)
    {
        _prefab = prefab;
    }

    public void Attack(Vector3 position, Quaternion rotation)
    {
        Object.Instantiate(_prefab, position, rotation);
    }
}