using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Settings : ScriptableObject
{
    //Audio
    public float masterVolume = Mathf.Clamp(1,0f,1f);
    public float musicVolume = Mathf.Clamp(1,0f,1f);
    public float ambienceVolume = Mathf.Clamp(1,0f,1f);    
    public bool sound3D = false;

    //Video

    public bool fullScreen=false;
    public int crosshair=1;
    public int sideart=0;
    public float screenshake = Mathf.Clamp(1,0f,1f);
    public float frezeeFrames = Mathf.Clamp(1,0,1);
    public bool hideHUD=true;
    public int gamepadStyle = 1;

    //GAME

    public bool bossIntro=true;
    
    
}
