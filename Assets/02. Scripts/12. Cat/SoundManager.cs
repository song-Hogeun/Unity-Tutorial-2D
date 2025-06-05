// System
	using System;
	using System.Collections;
	using System.Collections.Generic;
	
// Unity
	using UnityEngine;
	using UnityEngine.UI;

// Project
// Alias

/// <summary>
/// 클래스 설명을 적는 곳 입니다.
/// <summary>

namespace Cat
{
	public class SoundManager : MonoBehaviour
	{
		public AudioSource audioSource;
		public AudioClip bgmClip;
		public AudioClip jumpClip;
		public AudioClip introClip;
		public AudioClip collClip;

		void Init()
		{
			audioSource.loop = true;			// 반복 기능
			audioSource.volume = 0.1f;			// 소리 음량
		}
		
		public void SetIntroSound()
		{
			Init();
			audioSource.clip = introClip;		// 오디오 소스에 사운드 파일 설정
			audioSource.Play();					// 시작
		}
		
		public void SetBGMSound()
		{
			Init();
			audioSource.clip = bgmClip;			// 오디오 소스에 사운드 파일 설정
			audioSource.Play();					// 시작
		}

		public void OnJumpSound()
		{
			audioSource.PlayOneShot(jumpClip);
		}

		public void OnCollisionSound()
		{
			audioSource.PlayOneShot(collClip);
		}
	}	
}
