using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class StreamVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public RawImage rawImage;
    public GameObject rawImageGO;

    public bool isTVEnabled = false;
    public Text tvButtonText;


    public void envokeVideoPlayer()
    {
        if (!isTVEnabled)
        {
            StartCoroutine(StartVideo());
        }
        else
        {
            videoPlayer.Stop();
            rawImage.texture = null;
            rawImageGO.SetActive(false);
            tvButtonText.text = "Turn On TV";
            isTVEnabled = false;
        }
    }

    IEnumerator StartVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1f);

        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }

        rawImage.texture = videoPlayer.texture;
        rawImageGO.SetActive(true);
        videoPlayer.Play();
        tvButtonText.text = "Turn Off TV";
        isTVEnabled = true;
    }
}
