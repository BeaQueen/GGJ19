using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InterfaceCanvasScript : MonoBehaviour {

    public GameObject map;
    public GameObject houses;
    public Button Match_Button;


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void MapAppIntro()
    {
        map.SendMessage("IntroMap");
    }

    public void MapAppOutro()
    {
        map.SendMessage("OutroMap");
    }

    public void HousesAppIntro()
    {
        houses.SendMessage("IntroHouses");
        Match_Button.interactable = true;
    }

    public void HousesAppOutro()
    {
        houses.SendMessage("OutroHouses");
    }

}
