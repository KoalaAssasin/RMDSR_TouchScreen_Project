using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
        
    }
}
