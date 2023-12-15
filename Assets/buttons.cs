using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnMouseDown()
    {
        if(gameObject.name == "Reset")
        {
            gameflow.emptyPlateNow = 0;
        }
        
        if(gameObject.name == "Add to Menu")
        {
            gameflow.FullMenu[gameflow.menuIndex] = gameflow.createdMenuItem;
            gameflow.emptyPlateNow = 0;
            Debug.Log(gameflow.createdMenuItem);
            gameflow.menuIndex++;
            gameflow.createdMenuItem = 0;
            StartCoroutine(platereset());
        }

        if(gameObject.name == "Start Day")
        {
            SceneManager.LoadScene("food");
        }

        IEnumerator platereset()
        {
            yield return new WaitForSeconds(.2f);
            gameflow.emptyPlateNow = -5;
        }
    }

}
