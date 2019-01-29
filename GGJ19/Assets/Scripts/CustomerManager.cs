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

    public Customer[] gameCustomers = new Customer[22];

    public SpriteRenderer SpritePhoto;
    public Text TextVirtue;
    public Text TextVice;
    public Text TextJob;
    public Text TextChildren;
    public Text TextPets;

    bool appIn = false;

    int max_next;

    public void ShowCustomer(int gameCustomerIndex)
    {
        TextVirtue.text = gameCustomers[gameCustomerIndex].CustomerVirtueStr;
        TextVice.text = gameCustomers[gameCustomerIndex].CustomerViceStr;
        TextJob.text = gameCustomers[gameCustomerIndex].CustomerJobStr;
        TextChildren.text = gameCustomers[gameCustomerIndex].CustomerChildrenStr;
        TextPets.text = gameCustomers[gameCustomerIndex].CustomerPetsStr;
        SpritePhoto.sprite = gameCustomers[gameCustomerIndex].CustomerPhoto;
    }

    public int CalculateCustomerMoney(int gameCustomerIndex)
    {
        return gameCustomers[gameCustomerIndex].CustomerChildren + gameCustomers[gameCustomerIndex].CustomerJob + gameCustomers[gameCustomerIndex].CustomerVirtue + gameCustomers[gameCustomerIndex].CustomerVice + gameCustomers[gameCustomerIndex].CustomerPets;
    }

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
