using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage()
    {

    }
  
}
