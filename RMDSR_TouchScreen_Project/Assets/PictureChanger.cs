using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public string[] CityNames = new string[] { "brisbane", "adelaide", "canberra", "darwin", "hobart", "melbourne", "perth", "sydney" };
    int cityNum = 0;


    void Start()
    {
        // Assuming your GameObject has a SpriteRenderer component
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //testing
            cityNum++;
            ImageChange(cityNum);

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

    }

    public void LastCity()
    {
        cityNum--;
        if (cityNum < 0)
        {
            cityNum = 7;
        }

        ImageChange(cityNum);

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