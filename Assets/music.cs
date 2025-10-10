using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class music : MonoBehaviour
{
    string currentsong = "";
    bool isSongPlaying = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        PlaySong("careful what you wish for (the docter said to) - Jack Harris");
        GetcurrentSong();
       
        setVolume(0.5f);

        isPlaying();
        stopsong();




    }

    // Update is called once per frame
    void Update()
    {
       
        

    }
    void PlaySong(string songName)
    {
       currentsong = songName;
        if (isSongPlaying == true)
        {
            currentsong = songName;
            Debug.Log("Playing song:" + songName);
            
        }
    }
    void GetcurrentSong()
    {
        
            Debug.Log("Current song:" + currentsong);
            
        
    }
    void setVolume(float volume)
    {
        if (isSongPlaying == true)
        {
            Debug.Log("Volume set to:" + volume);
            if (Input.GetKeyDown(KeyCode.V))
            {
                volume = volume + 0.1f;
                
            }
            else
            {

            }
        }
    }
    bool isPlaying()
    {
        Debug.Log("Is playing:" + isSongPlaying);
        return isSongPlaying;
        
    }
    void stopsong()
    {
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            isSongPlaying = true;
            Debug.Log("Song Started.");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            isSongPlaying = false;
            Debug.Log("Song stoped.");
        }
    }
}

