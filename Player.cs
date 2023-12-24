using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour


{
    public GameObject fireballPrefab;
    public Transform attackPoint;
    private int health = 10;
    public int coins = 0;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print ("�������� ������: " + health);

    }

    void Update()
    {
       if (Input.GetMouseButton(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    public void CollectCoins(int coin)
    {
        coins += coin;
        print("���-�� �������: " + coins);

    }
}
