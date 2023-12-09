using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

public class PictureChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public string[] CityNames = new string[] { "Brisbane", "Adelaide", "Canberaa", "Darwin", "Hobart", "Melbourne", "Perth", "Sydney", "Tokyo", "Beijing", "Auckland", "New Delhi", "London", "Singapore", "Seoul", "Washington DC", "Ottawa", "Jakarta", "Kuala Lumpur", "Berlin"  };
    public TMP_Text CityName;
    int cityNum = 4;
    OpacityController opacityController;

    public string[] Fact = new string[] {
        "The RMIDSR is about 29 times darker than the Brisbane City night sky!",
        "The RMIDSR is about 23 times darker than the Adelaide city night sky!",
        "The RMIDSR is about 11 times darker than the Canberra City night sky!",
        "The RMIDSR is about 9 times darker than the Darwin City night sky!",
        "The RMIDSR is about 13 times darker than the Hobart City night sky!",
        "The RMIDSR is about 49 times darker than the Melbourne City night sky!",
        "The RMIDSR is about 37 times darker than the Perth City night sky!",
        "The RMIDSR is about 40 times darker than the Sydney City night sky!",
        "The RMIDSR is about 64 times darker than the Tokyo City night sky!",
        "The RMIDSR is about 43 times darker than the Beijing City night sky!",
        "The RMIDSR is about 34  times darker than the Auckland City night sky!",
        "The RMIDSR is about 49 times darker than the New Dehli City night sky!",
        "The RMIDSR is about 65 times darker than the London City night sky!",
        "The RMIDSR is about 66 times darker than the Singapore City night sky!",
        "The RMIDSR is about 54 times darker than the Seoul City night sky!",
        "The RMIDSR is about 112 times darker than the Washington DC City night sky!",
        "The RMIDSR is about 35 times darker than the Ottawa City night sky!",
        "The RMIDSR is about 30 times darker than the Jakarta City night sky!",
        "The RMIDSR is about 55 times darker than the Kuala Lumpur City night sky!",
        "The RMIDSR is about 33 times darker than the Berlin City night sky!"};
    public TMP_Text FactWords;



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


            TextInfo textInfo2 = new CultureInfo("en-US", false).TextInfo;
            string formattedFact = textInfo2.ToTitleCase(Fact[cityNum].ToLower());
            FactWords.text = formattedFact;

        }
    }

    public void NextCity()
    {
        cityNum++;
        if (cityNum > 19)
        {
            cityNum = 0;
        }

        ImageChange(cityNum);
        opacityController.CityValueChanger(cityNum);

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string formattedCityName = textInfo.ToTitleCase(CityNames[cityNum].ToLower());
        CityName.text = formattedCityName;

        TextInfo textInfo2 = new CultureInfo("en-US", false).TextInfo;
        string formattedFact = textInfo2.ToTitleCase(Fact[cityNum].ToLower());
        FactWords.text = formattedFact;

    }

    public void LastCity()
    {
        cityNum--;
        if (cityNum < 0)
        {
            cityNum = 19;
        }

        ImageChange(cityNum);
        opacityController.CityValueChanger(cityNum);

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string formattedCityName = textInfo.ToTitleCase(CityNames[cityNum].ToLower());
        CityName.text = formattedCityName;

        TextInfo textInfo2 = new CultureInfo("en-US", false).TextInfo;
        string formattedFact = textInfo2.ToTitleCase(Fact[cityNum].ToLower());
        FactWords.text = formattedFact;

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