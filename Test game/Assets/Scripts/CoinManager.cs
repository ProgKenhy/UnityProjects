using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] int _numberOfCoinsInLevel;
    [SerializeField] TextMeshProUGUI _text;

    public void AddOne()
    {
        _numberOfCoinsInLevel++;
        _text.text = _numberOfCoinsInLevel.ToString();
    }
}
