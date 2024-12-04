using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruccionDeArma : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            Destroy(this.gameObject);
        }
    }
}
