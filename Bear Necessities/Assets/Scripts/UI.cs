using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    private int health;
    private int maxhealth;
    public TextMeshProUGUI healthNumber;
    public GameManager healthinstance;


    void Start()
    {
        //health = GameObject.Find("Bear").GetComponent<PlayerBehavior>().
        //health = healthinstance._playerHealth;
        //maxhealth = GameManager.gameManager._playerHealth.MaxHealth;
    }


    void Update()
    {
        healthNumber.SetText(health + "/" + maxhealth);
    }
}
