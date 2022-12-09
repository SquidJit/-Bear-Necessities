using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerMenu : MonoBehaviour
{
    public GameObject Buttons;

    // Start is called before the first frame update
    void Start()
    {
        Buttons.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.Escape))
        {
            Buttons.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Tab))
            {
                CancelMenu();
            }

        }

    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void CancelMenu()
    {
        Buttons.gameObject.SetActive(false);
    }
}
