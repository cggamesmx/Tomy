using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class VideoPlaying: MonoBehaviour
{
    [Tooltip("Set the time to delay before start playing sound after Trigger Event")]
    public float TimeBeforeStartPlaying = 0;    //Sets the delay to play clip after trigger event.
    public VideoClip videoClip;
    private bool isPlaying = false;
    #region Bloque copiado de la documentacion de Unity
    private VideoPlayer videoPlayer;                        // IMPORTANTE eliminar el fragmento 'var' de la documentacion de unity de https://docs.unity3d.com/ScriptReference/Video.VideoPlayer.html

    void Start()
        {
            GameObject camera = GameObject.Find("Main Camera");
            videoPlayer = camera.AddComponent<VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = VideoRenderMode.CameraNearPlane;
            videoPlayer.clip = videoClip;
        }
    #endregion

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")                           // Plays the video when Trigger Event happens  only
        {
            if (!isPlaying)
            {
                isPlaying = true;
                {
                    videoPlayer.Play();
                }
            }
          
        }
    }
}
