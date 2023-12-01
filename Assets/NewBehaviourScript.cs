using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //초기화 - 1
    private void Awake()
    {
        Debug.Log("초기화 1"); 
    }
    // Start is called before the first frame update
   //초기화 - 2
   private void Start()
    {
        Debug.Log("초기화 2");
    }

    // Update is called once per frame
    // 매 Frame 마다 -4
    private void Update()
    {
        //transform.Position
        //Time.deltatime
    }
    // 물리연산 끝나고 호출 -3
    private void FixedUpdate()
    {
        //rigidbody
    }
    // 위에 애들 다 끝나고 -5
    private void LateUpdate()
    {
        //카메라 찍기
    }
    private void OnEnable()
    {
        Debug.Log("켜졌다.");
        //게임 오브젝트가 켜질때
    }
    private void OnDisable()
    {
        Debug.Log("꺼졌다.");
        //게임 오브젝트가 꺼질때
    }
}
