using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public int health;
    public TMPro.TextMeshProUGUI myText;
    public BearHealth currenthealth;
    


    void Start()
    {
        //health = GameObject.Find("Bear").GetComponent<PlayerBehavior>().
        //health = healthinstance._playerHealth;
        //maxhealth = GameManager.gameManager._playerHealth.MaxHealth;
    }


    void Update()
    {
        //healthNumber.SetText(health + "/" + maxhealth);
        myText.text = "Health =" + " " + currenthealth.health.ToString();
    }
   
   
}
