using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCredScore : MonoBehaviour
{
    public Text scoreText;

	public int score;
	public float timer = 0.0f;

    void Update()
    {
		scoreText.text = "Your time was: " + PlayerPrefs.GetString("PlayerTime") + " seconds";
    }
}
