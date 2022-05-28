using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{
    public TextMeshProUGUI FpsText;

    private float pollingTime = 1f;
    private float time;
    private int frameCount;
    void Update()
    {
        time += Time.deltaTime;

        frameCount++;

        if (time >= pollingTime)
        {
            int framerate = Mathf.RoundToInt(frameCount / time);
            FpsText.text = framerate.ToString() + " FPS";

            time -= pollingTime;
            frameCount = 0;
        }
    }
}