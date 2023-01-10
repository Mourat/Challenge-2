using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float _pressDelay = 2f;
    private float _timer;
    public GameObject dogPrefab;

    private void Start()
    {
        _timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        _timer += Time.deltaTime;
        if (_timer >= _pressDelay)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                _timer = 0f;
            }
        }
    }
}