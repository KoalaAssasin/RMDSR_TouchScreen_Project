using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

public class PictureChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public string[] CityNames = new string[] { "Brisbane", "Adelaide", "Canberaa", "Darwin", "Hobart", "Melbourne", "Perth", "Sydney" };
    public TMP_Text CityName;
    int cityNum = 4;
    OpacityController opacityController;



    void Start()
    {
        // Assuming your GameObject has a SpriteRenderer component
        spriteRenderer = GetComponent<SpriteRenderer>();

        opacityController = FindObjectOfType<OpacityController>();

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string formattedCityName = textInfo.ToTitleCase(CityNames[cityNum].ToLower());
        CityName.text = formattedCityName;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //testing
            cityNum++;
            ImageChange(cityNum);
            opacityController.CityValueChanger(cityNum);

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            string formattedCityName = textInfo.ToTitleCase(CityNames[cityNum].ToLower());
            CityName.text = formattedCityName;

        }
    }

    public void NextCity()
    {
        cityNum++;
        if (cityNum > 7)
        {
            cityNum = 0;
        }

        ImageChange(cityNum);
        opacityController.CityValueChanger(cityNum);

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string formattedCityName = textInfo.ToTitleCase(CityNames[cityNum].ToLower());
        CityName.text = formattedCityName;

    }

    public void LastCity()
    {
        cityNum--;
        if (cityNum < 0)
        {
            cityNum = 7;
        }

        ImageChange(cityNum);
        opacityController.CityValueChanger(cityNum);

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string formattedCityName = textInfo.ToTitleCase(CityNames[cityNum].ToLower());
        CityName.text = formattedCityName;

    }

    public void ImageChange(int city)
    {
        // Get the current scale of the GameObject
        Vector3 currentScale = transform.localScale;

        // Load your new sprite 
        Sprite newSprite = Resources.Load<Sprite>(CityNames[city]);

        // Assign the new sprite to the SpriteRenderer
        spriteRenderer.sprite = newSprite;

        // Preserve the original scale of the GameObject
        transform.localScale = currentScale;
    }
}