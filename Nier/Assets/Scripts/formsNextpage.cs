using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class formsNextpage : MonoBehaviour
{
    public GameObject currentScreen;
    public GameObject nextScreen;

    public Text warning;

    public Text users;
    public Text names;
    public Text lastname;
    public Text password;

    public bool continueToNextPage;

    public void Update()
    {
        InformationVal();
    }
    public void InformationVal()
    {
        if (names.text != "" && lastname.text != "" && users.text != "" && password.text != "")
        {
            continueToNextPage = true;
        }
    }

    public void nextPage()
    {
        if (continueToNextPage)
        {
            currentScreen.SetActive(false);
            nextScreen.SetActive(true);
        }
        else
        {
            warning.text = "You have forgoten some information";
        }
    }
}
