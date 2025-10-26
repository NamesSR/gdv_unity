using System.Runtime.InteropServices.WindowsRuntime;
using Unity.Mathematics;
using UnityEngine;

public class music : MonoBehaviour
{
    string currentsong = "";
    bool isSongPlaying = true;
    float volume = 1.0f;    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        PlaySong("careful what you wish for (the docter said to) - Jack Harris");
        Debug.Log("Current song: " + GetcurrentSong());
       
        setVolume(0.5f);

        isPlaying();
        




    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlaySong("careful what you wish for (the docter said to) - Jack Harris");
            Debug.Log("Current song: " + GetcurrentSong());
            isPlaying();
            setVolume(this.volume);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            stopsong();
            isPlaying();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
         setVolume(this.volume + 0.1f);
        }


    }
    void PlaySong(string songName)
    {
        isSongPlaying = true;   
       currentsong = songName;
        if (isSongPlaying == true)
        {
            currentsong = songName;
            Debug.Log("Playing song:" + songName);
            
        }
    }
    string GetcurrentSong()
    {
        
       return currentsong;
            
        
    }
    void setVolume(float volume)
    {
        if (isSongPlaying)
        {
            
            this.volume = Mathf.Clamp01(volume);
            Debug.Log("Volume set to:" + this.volume);
          
        }
    }
    bool isPlaying()
    {
        Debug.Log("Is playing:" + isSongPlaying);
        return isSongPlaying;
        
    }
    void stopsong()
    {
        if (isSongPlaying)
        {
            isSongPlaying = false;
            Debug.Log("Song stopped.");
            currentsong = "";
        }
        else
        {
            Debug.Log("no song currently playing");
        }
    }
}

