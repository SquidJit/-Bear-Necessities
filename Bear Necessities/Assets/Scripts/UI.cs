using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public int health;
    public TMPro.TextMeshProUGUI myText;
    public BearHealth currenthealth;



    void Update()
    {
        myText.text = "Health =" + " " + currenthealth.health.ToString();
    }


}