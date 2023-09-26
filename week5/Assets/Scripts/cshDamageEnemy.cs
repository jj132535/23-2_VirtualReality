using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshDamageEnemy : MonoBehaviour
{
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "BULLET")
        {
            Destroy(gameObject);
        }
    }
}
