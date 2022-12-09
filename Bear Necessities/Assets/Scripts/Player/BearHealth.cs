using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int health;
    public float startWaitTime = 5;

    public float m_WaitTime;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        m_WaitTime = startWaitTime;
    }

   public void Update()
    {
        TakeDamage();
    }
    public void TakeDamage()
    {
        if (m_WaitTime <= 0)
        {
            if (health > 0)
            {
                health = health-1;
                m_WaitTime = startWaitTime;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        else
        {
            m_WaitTime -= Time.deltaTime;
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Animal")
        {
            health = health + 3;
        }
    }
}
   

