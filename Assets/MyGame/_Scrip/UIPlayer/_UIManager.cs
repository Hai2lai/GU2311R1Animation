using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI _textHealth;
    [SerializeField] TextMeshProUGUI _textCoin;
    private _PlayManager playerManager;
    void Start()
    {
        playerManager = GameObject.FindGameObjectWithTag("Player").GetComponent<_PlayManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerManager != null)
        {
            _textHealth.text = "Health :"+ playerManager.UpdateHealth().ToString();
        }
        if(playerManager != null)
        {
            _textCoin.text = "Coin :" + playerManager.UpdateCoin().ToString();
        }
        
    }
}
