using UnityEngine;
using UnityEngine.UI;

public class OpacityController : MonoBehaviour
{
    public Slider opacitySlider;
    public GameObject targetObject;

    // Start is called before the first frame update
    void Start()
    {
        // Subscribe to the slider value changed event
        opacitySlider.onValueChanged.AddListener(ChangeOpacity);

        Color objectColor = targetObject.GetComponent<Renderer>().material.color;
        objectColor.a = 0;
        targetObject.GetComponent<Renderer>().material.color = objectColor;
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
        }
    }
}