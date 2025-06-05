// System
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using TMPro;

	// Unity
	using UnityEngine;
	using UnityEngine.SceneManagement;
	using UnityEngine.UI;
	using TMPro;
// Project
// Alias

/// <summary>
/// 클래스 설명을 적는 곳 입니다.
/// <summary>
namespace Cat
{
	public class GameManager : MonoBehaviour
	{
		public static GameManager instance;
		
		public UIManager uiManager;
		public SoundManager soundManager;
		
		public GameObject[] gameSet;
		public GameObject catCharacter;
		
		public float playTime;
		public float saveTime;
		
		public bool isReady;
		public bool gameOver;

		void Awake()
		{
			if (instance == null)
			{
				instance = this;
			}
			
			else
			{
				Destroy(gameObject);
				instance = this;
			}
		}
		
		void Start()
		{
			soundManager.SetIntroSound();	// 인트로 BGM 사운드 실행
			
			catCharacter.SetActive(false);	// Cat Off
			gameSet[0].SetActive(true);		// Game Start Set Off
			gameSet[1].SetActive(false);	// Ready Text Off
			gameSet[2].SetActive(false);	// Game End Set Off
		}

		private void Update()
		{
			if(!gameOver && isReady)	// 게임 오버 상태가 아니면서 준비 상태일 때
			{
				playTime += Time.deltaTime;	// 게임 플레이 타임을 계산
			}
			
			if (gameOver)				// 게임 오버 상태일 때
			{
				GameEnd();				// 게임 오버 로직 실행
				saveTime = playTime;	// 생존 시간 저장
			}
		}
		
		public void GameStart()
		{
			isReady = false;				// Ready 상태 초기화
			gameOver = false;				// GameOver 상태 초기화
			
			soundManager.SetBGMSound();		// BGM 사운드 재생
			
			catCharacter.SetActive(true);	// Cat On
			
			gameSet[0].SetActive(false);	// Game Start Set Off
			gameSet[1].SetActive(true);		// Ready Text On
			gameSet[2].SetActive(false);	// Game End Set Off
			isReady = true;
		}

		public void Restart()
		{
			SceneManager.LoadScene(0);		// 로비 복귀
		}

		public void GameEnd()
		{
			gameOver = true;				// gameOver 상태
			
			saveTime = playTime;			// 최종 플레이 타임 저장
			uiManager.SetSaveTimeText();	// 플레이 타임 표시
			gameSet[0].SetActive(false);	// Game Start Set Off
			gameSet[1].SetActive(false);	// Ready Text Off
			gameSet[2].SetActive(true);		// Game End Set On
		}
	}
}
