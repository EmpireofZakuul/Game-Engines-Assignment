using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{
    private AudioSource audioSource;
    public static float[] AudioSamples = new float[512];
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        AudioSpectrum();
        //audioSource.GetSpectrumData(AudioSamples, 0, FFTWindow.Blackman);
    }

    public void AudioSpectrum()
    {
        audioSource.GetSpectrumData(AudioSamples, 0, FFTWindow.Blackman);
    }
}
