using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public GameManager gameManager;
    private Text scoreText;

	private void Start()
	{
        scoreText = GetComponentInChildren<Text>();
	}

	void Update()
    {
        
        scoreText.text = "Score: " + gameManager.score.ToString();

    }
}