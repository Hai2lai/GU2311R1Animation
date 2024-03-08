using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayManager : MonoBehaviour
{
    [SerializeField] private float MaxHealth = 100;
    [SerializeField] private int _coin = 0;
    private float currenHealth;

    // Start is called before the first frame update
    void Start()
    {
        currenHealth = MaxHealth;
    }

    // Update is called once per frame
    public float UpdateHealth()
    {
        return currenHealth;
    }
    public int UpdateCoin()
    {
        return _coin;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Damager")
        {
            currenHealth -= 20;

        }
        if(collision.gameObject.name =="Coin")
        {
            _coin += 1;
            Destroy(collision.gameObject);
        }
    }
}
