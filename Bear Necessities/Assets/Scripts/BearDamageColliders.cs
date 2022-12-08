using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearDamageColliders : MonoBehaviour
{
    private void Awake()
    {

    }
    void Start()
    {

    }


    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DamageableNPC"))
        {

        }
    }
}
