using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = gameObject.GetComponent<GameManager>();
    }
    #endregion

    //Indices
    private int m_houseIndex;
    private int m_customerIndex;

    //Dinero
    private int m_accHousesMoney;
    private int m_accCustomersMoney;

    public int HouseIndex
    {
        get { return m_houseIndex; }
        set { m_houseIndex = value; }
    }

    public int CustomerIndex
    {
        get { return m_customerIndex; }
        set { m_customerIndex = value; }
    }

    public int AccHousesMoney
    {
        get { return m_accHousesMoney; }
        set { m_accHousesMoney = value; }
    }

    public int AccCustomersMoney
    {
        get { return m_accCustomersMoney; }
        set { m_accCustomersMoney = value; }
    }

    int AccTotal;
    int max_Next;
    int max_Match;

    public Button Next_Button;
    public Button Match_Button;

    public GameObject EndCanvas;


    // Start is called before the first frame update
    void Start()
    {
        HouseIndex = 0;
        CustomerIndex = 0;

        //Acumulaciones de dinero
        AccHousesMoney = 0;
        AccCustomersMoney = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame(int gameHouseIndex)
    {
        HouseIndex = gameHouseIndex;
        CustomerIndex = 0;

        HousesManager.Instance.ShowHouse(gameHouseIndex);
        CustomerManager.Instance.ShowCustomer(CustomerIndex);

        //Mostrar y activar botón siguiente de customers
        //Mostrar y activar botón match
        //Mostrar y activar botón de comprar pista
    }

    public void NextCustomer()
    {
        if (max_Next < 10)
        {
            CustomerIndex++;
            CustomerManager.Instance.ShowCustomer(CustomerIndex);
            ++max_Next;
            Debug.Log("Next: " + max_Next);
        }
        else
            Next_Button.interactable = false;
    }

    public void Match()
    {

        if (max_Match < 0)
        {
            int sumHouseMoney = HousesManager.Instance.CalculateHouseMoney(HouseIndex);
            int sumCustomerMoney = CustomerManager.Instance.CalculateCustomerMoney(CustomerIndex);

            AccTotal += sumCustomerMoney - sumHouseMoney;

            AccHousesMoney += sumHouseMoney;
            AccCustomersMoney += sumCustomerMoney;

            Debug.Log("AccTotal: " + AccTotal);
            Debug.Log("AccHousesMoney: " + AccHousesMoney);
            Debug.Log("AccCustomersMoney: " + AccCustomersMoney);

            Match_Button.interactable = false;

            ++max_Match;
        }
        else
            EndGame();
    }

    public void EndGame()
    {
        //Hacer los cálculos entre AccHousesMoney y AccCustomersMoney, y
        //mostrar el pop-up con el dinero/puntuación final

        EndCanvas.SendMessage("IntroEndCanvas");

    }
}
