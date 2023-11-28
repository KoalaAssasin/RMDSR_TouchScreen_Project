using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityButtons : MonoBehaviour
{

    public int cityNum = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextCity()
    {
        cityNum++;
        if (cityNum > 7)
        {
            cityNum = 0;
        }

        PictureChanger PC = gameObject.GetComponent<PictureChanger>();
        PC.ImageChange(cityNum);

    }

    public void LastCity()
    {
        cityNum--;
        if (cityNum < 0)
        {
            cityNum = 7;
        }

        PictureChanger PC = gameObject.GetComponent<PictureChanger>();
        PC.ImageChange(cityNum);

    }
}
