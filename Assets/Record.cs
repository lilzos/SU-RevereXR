using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Transformers;
using UnityEngine.XR.Interaction.Toolkit;

public class Record : MonoBehaviour
{
    public int trackIndex;

    public AudioClip recordAudioClip;
    //private XRSocketGrabTransformer r;
    //private IXRInteractor recordNum;
    public InteractorRegisteredEventArgs record;
    //private RPController rp;
    
    public void Music()
    {
        
        trackIndex = 0;
        //rp.Start();
        //trackIndex = 0;
        //recordAudioClip = GetComponent<AudioClip>();
        //recordNum = r.socketInteractor;
        //recordNum.OnRegistered(Index());

        //recordAudioClip = audioTracks[trackIndex].trackAudioClip;
    }
    

}
