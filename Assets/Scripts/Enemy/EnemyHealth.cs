using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    #region Variables
    public float maxHP = 100, curHP = 100;
    public Slider healthBar;
    public Canvas myCanvas;
    #endregion
    #region Canvas & HealthBar


    //attach healthbar and canvas element
    private void Start()
    {
        myCanvas = transform.Find("Canvas").GetComponent<Canvas>();
        healthBar = myCanvas.transform.Find("Slider").GetComponent<Slider>();

    }
    #endregion
    #region Camera
    //clamp camera to camera angle
    private void Update()
    {
        //sets between min/max value between 0 & 1
        healthBar.value = Mathf.Clamp01(curHP / maxHP);
        //canvas position rotates to match camera
        myCanvas.transform.LookAt(Camera.main.transform);
    }
    #endregion
}







