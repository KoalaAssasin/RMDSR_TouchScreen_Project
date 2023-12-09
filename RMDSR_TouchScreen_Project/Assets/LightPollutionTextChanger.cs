using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LightPollutionTextChanger : MonoBehaviour
{

    public int SlideNum;
    public GameObject Dot1Filled;
    public GameObject Dot2Filled;
    public GameObject Dot3Filled;
    public GameObject Dot4Filled;

    public GameObject LPPart1;
    public GameObject LPPart2;
    public GameObject LPPart3;
    public GameObject LPPart4;

    // Start is called before the first frame update
    void Start()
    {
        SlideNum = 1;
        Dot1Filled.SetActive(true);
        Dot2Filled.SetActive(false);
        Dot3Filled.SetActive(false);
        Dot4Filled.SetActive(false);

        LPPart1.SetActive(true);
        LPPart2.SetActive(false);
        LPPart3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void NextSlide()
    {
        if (SlideNum < 4)
        {
            SlideNum++;
        }

        DotChanger();
    }

    public void LastSlide()
    {
        if (SlideNum > 1)
        {
            SlideNum--;
        }

        DotChanger();
    }

    public void DotChanger()
    {
        if (SlideNum == 1)
        {
            Dot1Filled.SetActive(true);
            Dot2Filled.SetActive(false);
            Dot3Filled.SetActive(false);
            Dot4Filled.SetActive(false);

            LPPart1.SetActive(true);
            LPPart2.SetActive(false);
            LPPart3.SetActive(false);
            LPPart4.SetActive(false);

        }
        else if (SlideNum == 2)
        {
            Dot1Filled.SetActive(false);
            Dot2Filled.SetActive(true);
            Dot3Filled.SetActive(false);
            Dot4Filled.SetActive(false);

            LPPart1.SetActive(false);
            LPPart2.SetActive(true);
            LPPart3.SetActive(false);
            LPPart4.SetActive(false);
        }
        else if (SlideNum ==3)
        {
            Dot1Filled.SetActive(false);
            Dot2Filled.SetActive(false);
            Dot3Filled.SetActive(true);
            Dot4Filled.SetActive(false);

            LPPart1.SetActive(false);
            LPPart2.SetActive(false);
            LPPart3.SetActive(true);
            LPPart4.SetActive(false);
        }
        else if (SlideNum == 4)
        {
            Dot1Filled.SetActive(false);
            Dot2Filled.SetActive(false);
            Dot3Filled.SetActive(false);
            Dot4Filled.SetActive(true);

            LPPart1.SetActive(false);
            LPPart2.SetActive(false);
            LPPart3.SetActive(false);
            LPPart4.SetActive(true);
        }
        else
        {
            Debug.Log("According to all known laws of aviation, there's no way a bee should be able to fly");
        }
    }

}
