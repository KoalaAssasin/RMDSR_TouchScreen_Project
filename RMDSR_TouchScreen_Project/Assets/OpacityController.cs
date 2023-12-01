using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpacityController : MonoBehaviour
{
    public Slider opacitySlider;
    public GameObject targetObject;
    public TMP_Text lightValue;
    public float[] CityValues = new float[] {18.32f, 18.56f, 19.34f, 19.55f, 19.18f, 17.75f, 18.04f, 17.96f};
    // above uses the city values in the order of: "brisbane", "adelaide", "canberra", "darwin", "hobart", "melbourne", "perth", "sydney" 

    public float CityValue;

    // Start is called before the first frame update
    void Start()
    {
        // Subscribe to the slider value changed event
        opacitySlider.onValueChanged.AddListener(ChangeOpacity);

        Color objectColor = targetObject.GetComponent<Renderer>().material.color;
        objectColor.a = 0;
        targetObject.GetComponent<Renderer>().material.color = objectColor;

        CityValue = CityValues[4];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function to change the opacity of the target object
    void ChangeOpacity(float value)
    {
        // Ensure the target object exists
        if (targetObject != null)
        {
            // Change the object's opacity using the value from the slider
            Color objectColor = targetObject.GetComponent<Renderer>().material.color;
            objectColor.a = value;
            targetObject.GetComponent<Renderer>().material.color = objectColor;

            //Slider number
            //lightValue.text = (value * 22).ToString("F2");

            // Calculate the difference between 'a' and 22
            float difference = 21.97f - CityValue;

            // Calculate 'b' percent of the difference
            float result = difference * value;

            float result2 = CityValue + result;

            lightValue.text = result2.ToString("F2");
        }
    }

    public void CityValueChanger(int numb)
    {
        CityValue = CityValues[numb];

        float value = opacitySlider.value;
        float difference = 21.97f - CityValue;
        float result = difference * value;
        float result2 = CityValue + result;

        lightValue.text = result2.ToString("F2");
    }
}