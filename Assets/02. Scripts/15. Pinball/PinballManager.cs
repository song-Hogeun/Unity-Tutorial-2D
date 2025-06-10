// System
	using System;
	using System.Collections;
	using System.Collections.Generic;
	
// Unity
	using UnityEngine;
	using UnityEngine.SceneManagement;
	using UnityEngine.UI;

// Project
// Alias

	/// <summary>
	/// 클래스 설명을 적는 곳 입니다.
	/// <summary>
	public class PinballManager : MonoBehaviour
	{
		public Pinball pinball;
		
		public GameObject gameOverSet;

		public GameObject[] scoreLeftBlocks;
		public GameObject[] scoreRightBlocks;

		public Rigidbody2D leftBarRb;
		public Rigidbody2D rightBarRb;

		public Text scoreText;
		
		public AudioSource audioSource;

		public int score;
		
		public bool isMove;

		void Start()
		{
			score = 0;
			gameOverSet.SetActive(false);
			
			audioSource = GetComponent<AudioSource>();
		}

		private void Update()
		{
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				// AddTorque : 회전 힘을 가함
				leftBarRb.AddTorque(30f);
			}
			else
			{
				leftBarRb.AddTorque(-25f);
			}

			if (Input.GetKey(KeyCode.RightArrow))
			{
				// AddTorque : 회전 힘을 가함
				rightBarRb.AddTorque(-30f);
			}
			else
			{
				rightBarRb.AddTorque(25f);
			}
			
			GameOver();
		}
		

		public void GameOver()
		{
			if (pinball.gameOver)
			{
				scoreText.text = "Score: " + score;
				gameOverSet.SetActive(true);
			}
		}

		public void Restart()
		{
			SceneManager.LoadScene(0);
		}
	}
