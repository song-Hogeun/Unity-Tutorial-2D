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
		public UIManager uiManager;
		public SoundManager soundManager;
		
		public GameObject[] gameSet;
		public GameObject catCharacter;
		public GameObject catName;
		public GameObject oiiaiVideo;
		
		public TextMeshProUGUI playTimeUI;
		public TextMeshProUGUI scoreUI;
		
		public float playTime;
		public float saveTime;

		public static int score;
		
		public bool isReady;
		public bool gameOver;

		void Start()
		{
			playTime = 0f;
			score = 0;
			
			oiiaiVideo.SetActive(true);
			
			soundManager.SetIntroSound();	// 인트로 BGM 사운드 실행
			
			CatSetOnActive(false, false);
			GameSetOnActive(true, false, false);
		}

		private void Update()
		{
			if(!gameOver && isReady)	// 게임 오버 상태가 아니면서 준비 상태일 때
			{
				oiiaiVideo.SetActive(false);
				playTime += Time.deltaTime;	// 게임 플레이 타임을 계산
				playTimeUI.text = string.Format($"플레이 타임 : {playTime:N1} 초");
				scoreUI.text = string.Format($"X {score}");
			}
			
			if (gameOver)				// 게임 오버 상태일 때
			{
				GameEnd();				// 게임 오버 로직 실행
				saveTime = playTime;	// 생존 시간 저장
			}
		}

		void CatSetOnActive(bool isActiveOne, bool isActiveTwo)
		{
			catName.SetActive(isActiveOne);
			catCharacter.SetActive(isActiveTwo);
		}

		void GameSetOnActive(bool isActiveOne, bool isActiveTwo, bool isActiveThree)
		{
			gameSet[0].SetActive(isActiveOne);		// Game Start Set Off
			gameSet[1].SetActive(isActiveTwo);		// Ready Text On
			gameSet[2].SetActive(isActiveThree);	// Game End Set Off
		}
		
		public void GameStart()
		{
			isReady = false;				// Ready 상태 초기화
			gameOver = false;				// GameOver 상태 초기화
			
			soundManager.SetBGMSound();		// BGM 사운드 재생
			
			CatSetOnActive(true, true);
			GameSetOnActive(false, true, false);

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
			uiManager.SetUITextSetting();	// 플레이 타임 표시
			
			GameSetOnActive(false, false, true);
		}
	}
}
