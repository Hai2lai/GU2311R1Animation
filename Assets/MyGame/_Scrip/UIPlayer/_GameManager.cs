using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class _GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textHealth;
    private _PlayManager playerManager;
    void Start()
    {
        playerManager = GameObject.FindGameObjectWithTag("Player").GetComponent<_PlayManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerManager != null && playerManager.UpdateHealth() < 0)
        {
            FixedGame();
        }
    }
    private void FixedGame()
    {
        
    }
}
