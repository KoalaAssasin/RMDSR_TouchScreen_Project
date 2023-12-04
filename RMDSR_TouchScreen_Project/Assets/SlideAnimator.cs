using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideAnimator : MonoBehaviour
{
    public RectTransform textBox;
    public float slideDistance = 200f;
    public float slideSpeed = 5f;

    private bool isSliding = false;
    private bool isDown = false;

    [SerializeField]
    public bool goesDown;

    public void StartSlideAnimation()
    {
        if (!isSliding)
        {
            isSliding = true;
            StartCoroutine(SlideIn());
        }
    }

    IEnumerator SlideIn()
    {

        if (goesDown)
        {

            float currentDistance = 0f;

            if (isDown == false)
            {
                while (currentDistance < slideDistance)
                {
                    float step = slideSpeed * Time.deltaTime;
                    textBox.anchoredPosition += new Vector2(0, -step);
                    currentDistance += step;

                    yield return null;
                }

                isDown = true;
            }

            else if (isDown == true)
            {
                while (currentDistance < slideDistance)
                {
                    float step = slideSpeed * Time.deltaTime;
                    textBox.anchoredPosition += new Vector2(0, step);
                    currentDistance += step;

                    yield return null;
                }

                isDown = false;
            }

            isSliding = false;
        }

        else
        {
            float currentDistance = 0f;

            if (isDown == false)
            {
                while (currentDistance < slideDistance)
                {
                    float step = slideSpeed * Time.deltaTime;
                    textBox.anchoredPosition += new Vector2(-step, 0);
                    currentDistance += step;

                    yield return null;
                }

                isDown = true;
            }

            else if (isDown == true)
            {
                while (currentDistance < slideDistance)
                {
                    float step = slideSpeed * Time.deltaTime;
                    textBox.anchoredPosition += new Vector2(step, 0);
                    currentDistance += step;

                    yield return null;
                }

                isDown = false;
            }

            isSliding = false;
        }
    }
}