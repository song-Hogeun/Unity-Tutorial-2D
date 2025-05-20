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
/// 계산기 기능을 하는 클래스입니다.
/// <summary>
public class Calculator : MonoBehaviour
{
 	public int number1, number2;	// 멤버 변수 ( 필드 )

    void Start()
    {
	    int addResult = AddMethod();
	    int minusResutl = MinusMethod();
	    
	    AddMethod();	// 함수 호출
	    MinusMethod();	// 함수 호출
	    
	    Debug.Log($"더한 값 : {addResult} / 뺀 값 : {minusResutl}");
    }

    int AddMethod()
    {
	    // 지역 변수 result
	    int result = number1 + number2;
		
	    return result;
    }

    int MinusMethod()
    {
	    // 지역 변수 result
	    int result = number1 - number2;

	    return result;
    }
}
