using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{
    public static GameplayController instance;

    [SerializeField]
    private Text killCountText;

    public int killCount;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void EnemyKilled()
    {
        killCount++;
        killCountText.text = "Enemies killed: " + killCount;
    }

    public void RestartGame()
    {
        Invoke("Restart", 3f);
    }

    void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}
