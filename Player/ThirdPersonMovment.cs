using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovment : MonoBehaviour
{
    //�������� ������
    public float speed = 6.0f;
    //�������� ����
    public float runSpeed = 12.0f;
    //������� ��������� ��� ����� ��������� ����� ������� � �����
    float targetMovementSpeed;
    //����������� ������������ �������� ����
    public bool canRun = true;
    //�������� �� ������� �������
    public bool isRunning;
    //������� ����
    public KeyCode runButton = KeyCode.LeftShift;
    //��������� rigidbody ��� ������
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //�������� �� ����������� ����
        if(canRun == true)
        {
            //�������� �� ������� �������
            if (Input.GetKey(runButton))
            {
                isRunning = true;
            }
            else
            {
                isRunning = false;
            }
            //� ����������� �� ����������� ���������� isRunning ����� 1 �� 2 ��������
            targetMovementSpeed = isRunning ? runSpeed : speed;
            //�������� ���������� �������� ������� � �� ����� ������(�������������� ���,������� �������� velocity.y,������������ ��� ���������� �� ������� ��������)
            rb.velocity = transform.rotation * new Vector3(Input.GetAxis("Horizontal"), rb.velocity.y, Input.GetAxis("Vertical") * targetMovementSpeed);
            //������� ��������� �� ��� � ��������� �� �������������� ��� ��������� �� 100 ��������� �� 1 ������� ��������� ������� � ��������� ������� ���������
            transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * (100f * Time.deltaTime), Space.Self);
        }
    }
}
