using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonMenuMenager : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private GameObject menuObject;
    [SerializeField] private Animator transition;
    [SerializeField] private float transitionTime;
    private GameObject mainMenu;
    private GameObject loadGame;
    private GameObject settings;
    private GameObject aboutGame;
    private GameObject music;

    /*
        MENU BUTTONS
        0 - main menu
        1 - load game
        2 - settings 
        3 - about
    */
    private void Start() {
        menuObject = GameObject.Find("MenuImage");
        music = GameObject.Find("MusicObject");
        mainMenu = menuObject.transform.GetChild(0).gameObject;
        loadGame = menuObject.transform.GetChild(1).gameObject;
        settings = menuObject.transform.GetChild(2).gameObject;
        aboutGame = menuObject.transform.GetChild(3).gameObject;
    }

    public void PlayGame()
    {
        StartCoroutine(LoadSceneTransition());
    }

    private IEnumerator LoadSceneTransition()
    {
        transition.SetTrigger("Fade");
        //delay loading until animation is finished
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneName);
    }

    public void LoadGame()
    {
        //  Turn off main menu, turn on selected button
        mainMenu.SetActive(false);
        loadGame.SetActive(true);
    }

    public void Options()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }

    public void About()
    {
        mainMenu.SetActive(false);
        aboutGame.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void BackButton()
    {
        foreach(Transform child in menuObject.transform)
        {
            child.gameObject.SetActive(false);
        }
        mainMenu.SetActive(true);
    }

    public void MusicVolumeChanged(float value){
        music.GetComponent<AudioSource>().volume = 2f * value;
    }
}