﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerManager : MonoBehaviour
{
    #region Singleton
    public static CustomerManager Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = gameObject.GetComponent<CustomerManager>();
    }
    #endregion

    public Customer[] gameCustomers = new Customer[20];

    public Text TextTitle;
    public Text TextVirtue;
    public Text TextVici;
    public Text TextJob;
    public Text TextChildren;
    public Text TextPets;

    public void ShowCustomer(int gameCustomerIndex)
    {

    }

    public int CalculateCustomerMoney(int gameCustomerIndex)
    {
        //Para BEA: Esto es solo de ejemplo. Hacerlo con la fórmula que sea
        return gameCustomers[gameCustomerIndex].CustomerChildren + gameCustomers[gameCustomerIndex].CustomerJob;
    }



    bool appIn = false;

    //Variables de totales que no vera el jugador
    int total1;
    int total2;
    int total3;
    int total_final;


    //Variables 
    int zone;
    int furniture;
    int type;

    int max_next;

    int job;
    int virtue;
    int vice;

    public Button button_next;


    // Use this for initialization
    void Start () {
        /*
        zone = Random.Range(-5, 5);
        furniture = Random.Range(-5, 5);
        type = Random.Range(-5, 5);

        Debug.Log("Total1: " + total1);
        Debug.Log("Total2: " + total2);
        Debug.Log("Total3: " + total3);
        Debug.Log("Total Final: " + total_final);

        zone_Text.text = zone.ToString();
        furniture_Text.text = furniture.ToString();
        type_Text.text = type.ToString();
        */
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Randomize()
    {



    }

    public void fill_total()
    {


        if (max_next < 10)
        {

            job = Random.Range(-5, 5);
            virtue = Random.Range(-5, 5);
            vice = Random.Range(-5, 5);

            total1 = zone * job;
            total2 = furniture * virtue;
            total3 = type * vice;
            total_final = total1 + total2 + total3;

            Debug.Log("Total1: " + total1);
            Debug.Log("Total2: " + total2);
            Debug.Log("Total3: " + total3);
            Debug.Log("Total Final: " + total_final);

            ++max_next;

        }

        else
        {

            button_next.interactable = false;

        }


}

    public void IntroHouses()
    {
        if (appIn == false)
        {
            this.GetComponent<Animator>().Play("AppIntro");
            appIn = true;
        }

    }

    public void OutroHouses()
    {
        if (appIn == true)
        {
            this.GetComponent<Animator>().Play("AppOutro");
            appIn = false;
        }

    }

}
