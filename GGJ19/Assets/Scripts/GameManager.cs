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
    private bool[] m_customerSeen = new bool[21];

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
    int sumTotal;
    int AccgoodMatch;
    int AccwrongMatch;

    int max_Next;
    int max_Match;

    public Button Next_Button;
    public Button Match_Button;
    public GameObject MapApp;
    public GameObject endCanvas;
    public Animator HousesApp;

    public SpriteRenderer spriteEnd;
    public Text totalWrongMatch;
    public Text totalGoodMatch;
    public Text totalMoney;
    public Sprite winSprite;
    public Sprite loseSprite;
    public Sprite spriteEmpty;

    public SpriteRenderer matchResult;
    public Sprite xSprite;
    public Sprite checkSprite;



    // Start is called before the first frame update
    void Start()
    {
        HouseIndex = 0;
        CustomerIndex = 0;

        //Acumulaciones de dinero
        AccHousesMoney = 0;
        AccCustomersMoney = 0;

        max_Next = 0;
        max_Match = 0;

        
}

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame(int gameHouseIndex)
    {
        HouseIndex = gameHouseIndex;
        CustomerIndex = Random.Range(0, 21);

        HousesManager.Instance.ShowHouse(gameHouseIndex);
        CustomerManager.Instance.ShowCustomer(CustomerIndex);

        MapApp.GetComponent<MapAppScript>().mapButtons[gameHouseIndex].SetActive(false);

        for (int i = 0; i < 21; ++i)
            m_customerSeen[i] = false;

        //Mostrar y activar botón siguiente de customers
        Next_Button.interactable = true;
        max_Next = 0;

        matchResult.sprite = null;

    }

    public void NextCustomer()
    {

        if (max_Next < 9)
        {
            //Random customer
            CustomerIndex = Random.Range(0, 21);
            while (m_customerSeen[CustomerIndex])
                CustomerIndex = Random.Range(0, 21);

            m_customerSeen[CustomerIndex] = true;
            CustomerManager.Instance.ShowCustomer(CustomerIndex);
            ++max_Next;


        }
        else
            Next_Button.interactable = false;

    }

    public void Match()
    {
        
        int sumHouseMoney = HousesManager.Instance.CalculateHouseMoney(HouseIndex);
        int sumCustomerMoney = CustomerManager.Instance.CalculateCustomerMoney(CustomerIndex);

        sumTotal = sumCustomerMoney - sumHouseMoney;


        AccTotal += sumTotal;
        AccHousesMoney += sumHouseMoney;
        AccCustomersMoney += sumCustomerMoney;

        Next_Button.interactable = false;

        Debug.Log("AccTotal: " + AccTotal);
        Debug.Log("AccHousesMoney: " + AccHousesMoney);
        Debug.Log("AccCustomersMoney: " + AccCustomersMoney);

        Match_Button.interactable = false;

        //Variable Match antigua (no se usa ahora)
        ++max_Match;

        if(sumTotal >= 0)
        {
            AccgoodMatch++;
            matchResult.sprite = checkSprite;
            this.GetComponent<Animator>().Play("AppWait");
        }
        else
        {
            AccwrongMatch++;
            matchResult.sprite = xSprite;
            HousesApp.Play("AppShake");
            this.GetComponent<Animator>().Play("AppWait");
        }

        Debug.Log("Suma Casa: " + sumHouseMoney);
        Debug.Log("Suma Cliente: " + sumCustomerMoney);

        Debug.Log("Suma TOTAL: " + sumTotal);
        Debug.Log("Match ganados: " + AccgoodMatch);
        Debug.Log("Match perdidos: " + AccwrongMatch);



        if (AccgoodMatch >= 5 || AccwrongMatch >= 5)
            EndGame();
    }

    public void AppsWait()
    {
        HousesApp.SendMessage("OutroHouses");
        MapApp.SendMessage("IntroMap");

    }

    public void EndGame()
    {
        //Hacer los cálculos entre AccHousesMoney y AccCustomersMoney, y
        //mostrar el pop-up con el dinero/puntuación final

        totalWrongMatch.text = AccwrongMatch.ToString();
        totalGoodMatch.text = AccgoodMatch.ToString();
        totalMoney.text = AccTotal.ToString();


        if (AccTotal > 0)
        {
            spriteEnd.sprite = winSprite;
         
        }
        else
        {
            spriteEnd.sprite = loseSprite;
            totalMoney.color = Color.red;
        }

        endCanvas.SendMessage("IntroEndCanvas");

    }


}
