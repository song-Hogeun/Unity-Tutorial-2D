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

// enum : 쭉 나열해놓은 상태, 열거형
public enum CalculationType
{
	PLUS,
	MINUS,
	MULTIPLY,
	DIVIDE,
};

public class StudySwitch : MonoBehaviour
{
 	public CalculationType e_calculationType;
    
    public int input1, input2, result;

    void Start()
    {
	    Debug.Log($"계산 결과 : {Calculation()}");
    }

    private int Calculation()
    {
	    switch (e_calculationType)
	    {
		    case CalculationType.PLUS:
			    result = input1 + input2;
			    break;
		    
		    case CalculationType.MINUS:
			    result = input1 - input2;
			    break;
		    
		    case CalculationType.MULTIPLY:
			    result = input1 * input2;
			    break;
		    
		    case CalculationType.DIVIDE:
			    result = input1 / input2;
			    break;
	    }

	    return result;
    }
}
