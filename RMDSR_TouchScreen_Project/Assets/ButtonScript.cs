using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public float startTime = 10;
    public float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = startTime;
    }

    public void StartPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void IntroPlay()
    {
        SceneManager.LoadScene("IntroScene");
    }

    public void LightPollutionPlay()
    {
        SceneManager.LoadScene("LPScene");
    }

    public void ComparePlay()
    {
        SceneManager.LoadScene("CompareScene");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            timeRemaining = startTime;
        }

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
