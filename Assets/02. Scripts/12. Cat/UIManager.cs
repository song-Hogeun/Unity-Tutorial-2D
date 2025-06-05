// System
	using System;
	using System.Collections;
	using System.Collections.Generic;
	
// Unity
	using UnityEngine;
	using UnityEngine.UI;
	using Cat;
	using TMPro;

// Project
// Alias

/// <summary>
/// 클래스 설명을 적는 곳 입니다.
/// <summary>
namespace Cat
{
	public class UIManager : MonoBehaviour
	{
		public GameManager gameManager;
		
		public TMP_InputField nameInputField;
		public TMP_Text saveTimeText;
		public TMP_Text nickNameText;

		public GameObject fadePanel;
		public Animator fadeAnim;
		
		public void SetSaveTimeText()
		{
			saveTimeText.text = $"생존 시간 : {Mathf.CeilToInt(gameManager.saveTime)} 초";	
		}

		public void SetName()
		{
			nickNameText.text = nameInputField.text;
			nameInputField.text = "";
		}

		public void FadePanel()
		{
			gameManager.isReady = false;
			fadePanel.SetActive(true);
			StartCoroutine(IFadeInDelay());
		}

		IEnumerator IFadeInDelay()
		{
			fadeAnim.SetTrigger("Fade Out");
			yield return new WaitForSeconds(2f);
			
			fadeAnim.SetTrigger("Fade In");
			yield return new WaitForSeconds(1.5f);
			
			gameManager.GameStart();
			fadePanel.SetActive(false);
			
			StopCoroutine(IFadeInDelay());
		}
	}
}
