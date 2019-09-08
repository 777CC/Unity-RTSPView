using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMP;

public class RTSPView : View
{
    [SerializeField]
    private UniversalMediaPlayer player;
    const string rtspScheme = "rtsp://";
    public override void Play(string path)
    {
        base.Play(path);
        player.Path = rtspScheme + path;
        player.Play();
        Debug.Log("Startttt : " + path);
    }
}
