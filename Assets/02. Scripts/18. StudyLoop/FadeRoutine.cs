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
public class FadeRoutine : MonoBehaviour
{
	public Image fadePanel;		// 페이드 이미지

	void Start()
	{
		StartCoroutine(FadeRoutineA(1f, true));
	}
	
	IEnumerator FadeRoutineA(float fadeTime, bool isFadeIn)
	{
		float timer = 0f;
		float percent = 0f;
		float value = 0f;
		
		while(percent < 1f)
		{
			timer += Time.deltaTime;
			percent = timer / fadeTime;	// Fade 퍼센트
			value = isFadeIn ? percent : 1 - percent;
			
			fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, value);
			yield return null;
		}
	}
}
