using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCanvasScript : MonoBehaviour
{

    bool appIn = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IntroEndCanvas()
    {
        if (appIn == false)
        {
            this.GetComponent<Animator>().Play("AppIntro");
            appIn = true;
        }

    }

}
