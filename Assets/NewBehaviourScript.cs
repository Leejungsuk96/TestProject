using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //�ʱ�ȭ - 1
    private void Awake()
    {
        Debug.Log("�ʱ�ȭ 1"); 
    }
    // Start is called before the first frame update
   //�ʱ�ȭ - 2
   private void Start()
    {
        Debug.Log("�ʱ�ȭ 2");
    }

    // Update is called once per frame
    // �� Frame ���� -4
    private void Update()
    {
        //transform.Position
        //Time.deltatime
    }
    // �������� ������ ȣ�� -3
    private void FixedUpdate()
    {
        //rigidbody
    }
    // ���� �ֵ� �� ������ -5
    private void LateUpdate()
    {
        //ī�޶� ���
    }
    private void OnEnable()
    {
        Debug.Log("������.");
        //���� ������Ʈ�� ������
    }
    private void OnDisable()
    {
        Debug.Log("������.");
        //���� ������Ʈ�� ������
    }
}
