using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapAppScript : MonoBehaviour {

    public int NumMapButtons = 20;

    public GameObject[] mapButtons = new GameObject[20];

    bool appIn = true;

    int rndIndex;

    int numActiveButtons;

    // Use this for initialization
    void Start ()
    {
        active_Buttons();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void active_Buttons()
    {

        while (numActiveButtons < 10)
        {

            rndIndex = Random.Range(0, NumMapButtons - 1);

            if (mapButtons[rndIndex].activeSelf == false)
            {
                mapButtons[rndIndex].SetActive(true);
                numActiveButtons++;
            }
            Debug.Log(mapButtons[rndIndex]);
        }

    }


    public void IntroMap()
    {
        if(appIn == false)
        {
            this.GetComponent<Animator>().Play("AppIntro");
            appIn = true;
        }

    }

    public void OutroMap()
    {
        if (appIn == true)
        {
            this.GetComponent<Animator>().Play("AppOutro");
            appIn = false;
        }

    }
}
