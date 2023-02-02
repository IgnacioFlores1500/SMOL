using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public Text scoreText;

	public int score;
	public float timer = 0.0f;

    void Update()
    {
        timer += Time.deltaTime;
		score = (int)(timer);
        scoreText.text = score.ToString();
		PlayerPrefs.SetString("PlayerTime",scoreText.text);
    }
}
