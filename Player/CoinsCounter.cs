using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    //Монеты
    public int coin = 0;

    public void CollectCoins()
    {
        coin += 1;
        print("coins" + coin);
    }
}
