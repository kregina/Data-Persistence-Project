using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public UIMainScene mainScene;

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        mainScene.GameOver();
    }
}
