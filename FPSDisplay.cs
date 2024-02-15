using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class FPSDisplay : MonoBehaviour
{
    TMP_Text _fpsText;

    int _frameCount = 0;
    float _timeCounter = 0.0f;
    float _lastFramerate = 0.0f;
    public float _refreshTime = 0.5f;

    void Start()
    {
        _fpsText = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if( _timeCounter < _refreshTime )
        {
            _timeCounter += Time.deltaTime;
            _frameCount++;
        }
        else
        {
            _lastFramerate = (float)_frameCount/_timeCounter;
            _frameCount = 0;
            _timeCounter = 0.0f;
            RefreshDisplay();
        }
    }

    void RefreshDisplay()
    {
        _fpsText.text = "IPS : " + _lastFramerate.ToString("F0");
        if (_lastFramerate < 37)
            _fpsText.color = Color.red;
        else if (_lastFramerate < 71)
            _fpsText.color = Color.yellow;
        else
            _fpsText.color = Color.green;
    }
}
