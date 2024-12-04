using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public MessageBus _messageBus;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _messageBus.Publish("WeaponChanged", "Sword");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _messageBus.Publish("WeaponChanged", "Bow");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _messageBus.Publish("WeaponChanged", "Magic");
        }
    }

    public MessageBus GetMessageBus()
    {
        return _messageBus;
    }
}