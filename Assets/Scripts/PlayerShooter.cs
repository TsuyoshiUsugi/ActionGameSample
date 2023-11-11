using System;
using UnityEngine;

public class PlayerShooter : Shooter
{
    [SerializeField] Character _character;

    private void Awake()
    {
        this.TryGetComponent<Character>(out var _character);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shot(_character.CoinPower);
        }
    }
}
