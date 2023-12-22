using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerNameText;
    [SerializeField] TextMeshProUGUI highScoreText;

    private int highScore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameManager.Instance.playerName = playerNameText.text;
        highScoreText.text = "High Score: " + GameManager.Instance.highScore.ToString();
    }

    public void StartGame()
    {
        if (playerNameText.text == null || playerNameText.text == "")
        {
            Debug.Log("You must put a name first!");
        }
        else
        {
            SceneManager.LoadScene(1);
        }

    }

}
