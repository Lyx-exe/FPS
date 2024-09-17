using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playersetup : MonoBehaviour
{

    public Movement Movement;

    public GameObject camera;


    public void Islocalplayer()
    {
        Movement.enabled = true;
        camera.SetActive(true);
    }
}
