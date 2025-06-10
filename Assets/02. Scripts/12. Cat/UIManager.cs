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
		public TMP_Text scoreText;
		public TMP_Text nickNameText;
		
		public void SetUITextSetting()
		{
			saveTimeText.text = $"생존 시간 : {Mathf.CeilToInt(gameManager.saveTime)} 초";
			scoreText.text = $"X : {GameManager.score}";
		}

		public void SetName()
		{
			nickNameText.text = nameInputField.text;
			nameInputField.text = "";
		}
	}
}
