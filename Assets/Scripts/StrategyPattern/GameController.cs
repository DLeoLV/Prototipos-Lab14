using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject swordPrefab;
    public GameObject bowPrefab;
    public GameObject magicPrefab;
    public Character _character;

    private void Awake()
    {
        _character = GetComponent<Character>();
    }

    private void SetSwordAttack()
    {
        _character.SetAttackBehavior(new SwordAttack(swordPrefab));
    }

    private void SetBowAttack()
    {
        _character.SetAttackBehavior(new BowAttack(bowPrefab));
    }

    private void SetMagicAttack()
    {
        _character.SetAttackBehavior(new MagicAttack(magicPrefab));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetSwordAttack();
            _character.PerformAttack();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetBowAttack();
            _character.PerformAttack();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetMagicAttack();
            _character.PerformAttack();
        }
    }
}