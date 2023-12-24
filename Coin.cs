using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coin = 1;
    //������ "�������" �������
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")

        {
            Player player = other.GetComponent<Player>();
            player.CollectCoins(coin);

        }
        Destroy(gameObject);
    }


}
