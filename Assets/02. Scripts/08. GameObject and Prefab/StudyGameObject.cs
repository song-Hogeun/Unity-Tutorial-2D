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
public class StudyGameObject : MonoBehaviour
{
 	public GameObject prefab;
	
    private void Start()
    {
	    CreateAmongus();
    }

    public void CreateAmongus()
    {
	    GameObject obj = Instantiate(prefab);
	    obj.name = "캐릭터";

	    Transform objTf = obj.transform;
	    int childCount = objTf.childCount;
	    
	    Debug.Log($"캐릭터의 자식 오브젝트의 수 : {obj.transform.childCount}");
	    Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).gameObject.name}");
	    Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.GetChild(childCount-1).name}");
    }
}
