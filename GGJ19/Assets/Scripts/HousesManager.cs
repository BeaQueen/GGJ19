using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HousesManager : MonoBehaviour
{
    #region Singleton
    public static HousesManager Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = gameObject.GetComponent<HousesManager>();
    }
    #endregion

    public House[] gameHouses = new House[20];

    public Text TextTitle;
    public Text TextZone;
    public Text TextFurniture;
    public Text TextType;

    public void ShowHouse(int gameHouseIndex)
    {
        TextZone.text = gameHouses[gameHouseIndex].HouseZone.ToString();
        TextFurniture.text = gameHouses[gameHouseIndex].HouseFurniture.ToString();
        TextType.text = gameHouses[gameHouseIndex].HouseType.ToString();
    }

    public int CalculateHouseMoney(int gameHouseIndex)
    {
        //Para BEA: Esto es solo de ejemplo. Hacerlo con la fórmula que sea
        return gameHouses[gameHouseIndex].HouseZone + gameHouses[gameHouseIndex].HouseType;
    }



    bool appIn = false;
 
    int max_next;

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
