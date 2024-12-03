using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackBehavior
{
    void Attack(Vector3 position, Quaternion rotation);
}