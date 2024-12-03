using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicAttack : IAttackBehavior
{
    private GameObject _prefab;

    public MagicAttack(GameObject prefab)
    {
        _prefab = prefab;
    }

    public void Attack(Vector3 position, Quaternion rotation)
    {
        Object.Instantiate(_prefab, position, rotation);
    }
}