using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttons : MonoBehaviour
{

    /*Buttons.cs main objective is to allow the buttons within the game menu to be usable, allowing reset,
    new menu items to be added, or a start of a new day.*/

    public textMeshProUGUI enteredName;
    
    void Start()
    {
        
    }

    void Update()
    {

    }

    /* When the mouse is pressed: if on the reset button, the plate with reset, allowing for gamer to 
    start a new meal if they messed up. If they press Add to Menu, the selected ingredient within the 
    catalog will be added to the menu and allows for customers to pick. If the user presses Start Day,
    a new day will be noted a all new cahnges within the restraunt, interactions with customers, and 
    meals created will be noted.*/
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
            //Debug.log(enteredName.text);

            menuflow.menuMealValue[0] = enteredName.text;
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
