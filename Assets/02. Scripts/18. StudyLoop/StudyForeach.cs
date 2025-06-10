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
public class StudyForeach : MonoBehaviour
{
 	public string[] persons = new string[5] {"철수", "영희", "동수", "마이콜", "존"};

    public string findName;
    
    private void Start()
    {
		FindPerson(findName);   
    }

    private void FindPerson(string name)
    {
	    bool isFind = false;
	    foreach (var person in persons)
	    {
		    if (person == name)
		    {
			    isFind = true;
			    Debug.Log($"인원 중에 {name} 님이 존재합니다.");
		    }
	    }
	    
	    if(!isFind)
			Debug.Log($"{name} 님을 찾지 못했습니다.");
    }
}
