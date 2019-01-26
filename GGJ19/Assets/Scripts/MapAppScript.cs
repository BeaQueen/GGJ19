using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapAppScript : MonoBehaviour {

    bool appIn = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
