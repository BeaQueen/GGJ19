using System.Collections;
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
    public Text TextVice;
    public Text TextJob;
    public Text TextChildren;
    public Text TextPets;

    public void ShowCustomer(int gameCustomerIndex)
    {
        TextVirtue.text = gameCustomers[gameCustomerIndex].CustomerVirtue.ToString();
        TextVice.text = gameCustomers[gameCustomerIndex].CustomerVice.ToString();
        TextJob.text = gameCustomers[gameCustomerIndex].CustomerJob.ToString();
    }

    public int CalculateCustomerMoney(int gameCustomerIndex)
    {
        //Para BEA: Esto es solo de ejemplo. Hacerlo con la fórmula que sea
        return gameCustomers[gameCustomerIndex].CustomerChildren + gameCustomers[gameCustomerIndex].CustomerJob;
    }



    bool appIn = false;

    int max_next;

    //Para desactivar a los 10 NEXT
    public Button button_next;


    // Use this for initialization
    void Start () {
 
    }
	
	// Update is called once per frame
	void Update () {
		
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
