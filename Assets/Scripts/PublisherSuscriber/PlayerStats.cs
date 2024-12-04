using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Player Stats")]
    [SerializeField] private int health = 100;
    [SerializeField] private int attack = 0;
    [SerializeField] private int speed = 0;

    public PlayerController _playerController;
    public MessageBus _messageBus;

    public int Health => health;
    public int Attack => attack;
    public int Speed => speed;

    void Start()
    {
        _messageBus.Subscribe("WeaponChanged", OnWeaponChanged);
    }

    void OnDisable()
    {
        _messageBus.Unsubscribe("WeaponChanged", OnWeaponChanged);
    }

    private void OnWeaponChanged(string weaponType)
    {
        if (weaponType == "Sword")
        {
            health = 150;
            attack = 100;
            speed = 0;
        }
        else if (weaponType == "Bow")
        {
            health = 100;
            attack = 50;
            speed = 100;
        }
        else if (weaponType == "Magic")
        {
            health = 100;
            attack = 100;
            speed = 100;
        }

        Debug.Log("Mi arma actual es: " + weaponType);
    }
}