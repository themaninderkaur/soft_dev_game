using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameflow : MonoBehaviour
{
    /*the gameflow file brings all the other files
    together and flows the game togather, as the name suggests.
    Below are all the objects, ints, etc. that are instantiated.
    From orderValues, to what order, to customers. */
    
    public static int[] orderValue = { 11111, 10001, 12001 };
    public static int[] plateValue = { 0, 0, 0 };
    public static float[] orderTimer = { 60, 60, 60 };

    public static int plateNum = 0;
    public static float plateXPos = 0;
    public Transform plateSelector;

    public MeshRenderer[] currentPic;
    public Texture[] orderPics;

    public static float emptyPlateNow = -1;
    public static float totalCash = 0;

    public static float[] orderCost = { 1, 2.50f, 3.50f};
    public static int createdMenuItem;
    public static int[] FullMenu = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public static int menuIndex = 0;
    public static int showOrder = -10;

    public Trasform homme;
    public Trasform femme;
    public Trasform boy;
    public Trasform girl;

    //represents what character is being played
    public static int[] customers = { 0, 0, 0, 0, 0 };

    /*Before program begins, the customer is spawned.*/
    void Start()
    {
        StartCoroutine(customerSpawn());
    }

    /*based on whatever orderValue the customer is assigned, the speechbubble
    that comes with each customer spawns a picture of that order inn their speechbubble.
    After each customer order is done, the values assigned to the plateNum, timer, 
    etc. is reset.*/
    void Update()
    {
        if(gameflow.showOrder == -1)
        {

        for(int i = 0; i < 3; i++)
        {
            if (orderValue[i] == 11001)
            {
                currentPic[i].GetComponent<MeshRenderer>().material.mainTexture = orderPics[0];
            }

            if (orderValue[i] == 11011)
            {
                currentPic[i].GetComponent<MeshRenderer>().material.mainTexture = orderPics[1];
            }

            if (orderValue[i] == 11101)
            {
                currentPic[i].GetComponent<MeshRenderer>().material.mainTexture = orderPics[2];
            }

            if (orderValue[i] == 11111)
            {
                currentPic[i].GetComponent<MeshRenderer>().material.mainTexture = orderPics[3];
            }

            if (orderValue[i] == 12001)
            {
                currentPic[i].GetComponent<MeshRenderer>().material.mainTexture = orderPics[4];
            }

            if (orderValue[i] == 12011)
            {
                currentPic[i].GetComponent<MeshRenderer>().material.mainTexture = orderPics[5];
            }

            if (orderValue[i] == 12101)
            {
                currentPic[i].GetComponent<MeshRenderer>().material.mainTexture = orderPics[6];
            }

            if (orderValue[i] != 12111)
            {
                 continue;
            }
            currentPic[i].GetComponent<MeshRenderer>().material.mainTexture = orderPics[7];
            }
        }

        if (Input.GetKeyDown("tab"))
        {
            plateNum++;
            plateXPos += 2;

            if(plateNum > 2)
            {
                plateNum = 0;
                plateXPos = 0;
            }
        }

        orderTimer[0] -= Time.deltaTime;
        orderTimer[1] -= Time.deltaTime;
        orderTimer[2] -= Time.deltaTime;

        plateSelector.transform.position = new Vector2(plateNum, 0);
    }

    /*Based on whatever the customer lineup is, this is how each of the
    customers are spawned in the void Start().*/
    private IEnumerator CustomerSpawn()
    {
        get {
            yield return new WaitForSeconds(.5f);
            if(customers[0] == 1)
            {
                Instantiate(homme, homme.position, homme.rotation);
            }
            yield return new WaitForSeconds(2);
            if(customers[1] == 1)
            {
                Instantiate(femme, femme.position, femme.rotation);
            }
        }
    }
    
    /*debug*/ 
    private string GetDebuggerDisplay() 
    {
        return ToString();
    }
    
}
