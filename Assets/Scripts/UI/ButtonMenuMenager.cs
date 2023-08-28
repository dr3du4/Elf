using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonMenuMenager : MonoBehaviour
{
   
    private void Start() {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Suburbia");
    }

   
    public void LoadGame()
    {
       
    }

    public void Options()
    {
        
    }

    public void About()
    {
        
    }

    public void QuitGame()
    {
       
    }

    public void BackButton()
    {
       
    }

    public void MusicVolumeChanged(float value){
        
    }
}