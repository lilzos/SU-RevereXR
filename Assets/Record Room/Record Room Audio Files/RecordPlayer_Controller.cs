using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.Transformers;
using UnityEngine.XR.Interaction.Toolkit;


public class RPController : MonoBehaviour
{
    [Header("List of Tracks")]
    [SerializeField] private Track[] audioTracks;
    private int trackID;

    [Header("Text UI")]
    [SerializeField] private Text trackTextUI;

    private AudioSource rpAudioSource;
    private XRSocketGrabTransformer r;
    private IXRInteractor recordNum;
    private Record rec;

    public void EjectRecord()
    {
        rpAudioSource.Stop();

        trackID = 0;
        rpAudioSource.clip = audioTracks[trackID].trackAudioClip;
        trackTextUI.text = audioTracks[trackID].name;
    }

    public void LoadRecordOne()
    {
        
        rpAudioSource = GetComponent<AudioSource>();
        //recordNum = r.socketInteractor;
        //recordNum.OnRegistered(rec.Index());

        trackID = 1;
        rpAudioSource.clip = audioTracks[trackID].trackAudioClip;
        trackTextUI.text = audioTracks[trackID].name;
    }

    public void LoadRecordTwo()
    {

        rpAudioSource = GetComponent<AudioSource>();

        trackID = 2;
        rpAudioSource.clip = audioTracks[trackID].trackAudioClip;
        trackTextUI.text = audioTracks[trackID].name;
    }

    public void LoadRecordThree()
    {

        rpAudioSource = GetComponent<AudioSource>();

        trackID = 3;
        rpAudioSource.clip = audioTracks[trackID].trackAudioClip;
        trackTextUI.text = audioTracks[trackID].name;
    }

    public void LoadRecordFour()
    {

        rpAudioSource = GetComponent<AudioSource>();

        trackID = 4;
        rpAudioSource.clip = audioTracks[trackID].trackAudioClip;
        trackTextUI.text = audioTracks[trackID].name;
    }

    public void LoadRecordFive()
    {

        rpAudioSource = GetComponent<AudioSource>();

        trackID = 5;
        rpAudioSource.clip = audioTracks[trackID].trackAudioClip;
        trackTextUI.text = audioTracks[trackID].name;
    }

    public void PlayAudio()
    {
        rpAudioSource.Play();
    }

    public void PauseAudio()
    {
        rpAudioSource.Pause();
    }

    public void StopAudio()
    {
        rpAudioSource.Stop();
    }
}
