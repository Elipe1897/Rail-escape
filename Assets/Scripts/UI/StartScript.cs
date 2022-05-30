using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    public bool startGame = false;

    public GameObject StartGameUi;
    public GameObject StartTextUi;

    void Update()
    {
        if (startGame == false)
        { Time.timeScale = 0; }

        if (startGame == false && Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 1;

            StartGameUi.SetActive(false);
            StartTextUi.SetActive(false);
            startGame = true;
        }
    }
}
