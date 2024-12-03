using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : IAttackBehavior
{
    private GameObject _prefab;

    public SwordAttack(GameObject prefab)
    {
        _prefab = prefab;
    }

    public void Attack(Vector3 position, Quaternion rotation)
    {
        Object.Instantiate(_prefab, position, rotation);
    }
}