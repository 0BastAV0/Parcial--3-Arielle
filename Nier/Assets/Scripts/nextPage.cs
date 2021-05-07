using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextPage : MonoBehaviour
{
    
   
        public GameObject thisPage;
        public GameObject nextoPage;


        public void ChangeScreen()
        {
            thisPage.SetActive(false);
            nextoPage.SetActive(true);
        }
    
}
