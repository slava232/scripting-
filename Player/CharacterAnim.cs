using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    //Поля аниматора и интовых значений параметров в аниматоре
    public Animator player;
    int iswalkinghash, isrunninghash;
    void Start() {
        //Получаем номера параметров
        iswalkinghash = Animator.StringToHash("isWalking");
        isrunninghash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        //Поля на правдивость ходьбы,бега и нажатия клавиш
        bool isRunning = player.GetBool(isrunninghash);
        bool isWalking = player.GetBool(iswalkinghash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        //Если состояние ходьбы ложь и нажата клавиша ходьбы
        if(!isWalking && forwardPressed)
        {
            player.SetBool("isWalking", true);
            print("walk");
        }
        //Если состояние ходьбы правда и клавиша ходьбы не нажата
        if (isWalking && !forwardPressed)
        {
            player.SetBool("isWalking", false);
            print("!walk");
        }
        //Если состояние бега ложь и нажаты обе клавишы
        if (!isRunning && (runPressed && forwardPressed))
        {
            player.SetBool("isRunning", true);
            print("run");
        }
        //Если состояние бега правда и не нажата хотя бы одна из клавиш
        if (isRunning && (!runPressed || !forwardPressed))
        {
            player.SetBool("isRunning", false);
            print("!run");
        }
    }
}
