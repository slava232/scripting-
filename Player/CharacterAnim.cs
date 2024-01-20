using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    //���� ��������� � ������� �������� ���������� � ���������
    public Animator player;
    int iswalkinghash, isrunninghash;
    void Start() {
        //�������� ������ ����������
        iswalkinghash = Animator.StringToHash("isWalking");
        isrunninghash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        //���� �� ����������� ������,���� � ������� ������
        bool isRunning = player.GetBool(isrunninghash);
        bool isWalking = player.GetBool(iswalkinghash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        //���� ��������� ������ ���� � ������ ������� ������
        if(!isWalking && forwardPressed)
        {
            player.SetBool("isWalking", true);
            print("walk");
        }
        //���� ��������� ������ ������ � ������� ������ �� ������
        if (isWalking && !forwardPressed)
        {
            player.SetBool("isWalking", false);
            print("!walk");
        }
        //���� ��������� ���� ���� � ������ ��� �������
        if (!isRunning && (runPressed && forwardPressed))
        {
            player.SetBool("isRunning", true);
            print("run");
        }
        //���� ��������� ���� ������ � �� ������ ���� �� ���� �� ������
        if (isRunning && (!runPressed || !forwardPressed))
        {
            player.SetBool("isRunning", false);
            print("!run");
        }
    }
}
