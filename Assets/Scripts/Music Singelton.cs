using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameMusicPlayer : MonoBehaviour
{

    private static GameMusicPlayer instance = null;
    public static GameMusicPlayer Instance
    {
        get { return instance; }
    }

    private string currentScene = "";
    private string lastScene = "MainMenu";

    [SerializeField]
    public AudioSource audioSource;


    public AudioClip menuTheme;

    public AudioClip gameTheme;


    void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene().name;
        if(currentScene == "MainMenu" || currentScene == "Credits" && lastScene != "MainMenu" && lastScene != "Credits"){
            if(audioSource.clip != menuTheme){
                audioSource.Pause();
                audioSource.clip = menuTheme;
                audioSource.Play();
            }
        }
        else if(currentScene == "GameScene") {
            audioSource.Pause();
            audioSource.clip = gameTheme;
            audioSource.Play();
        }
        lastScene = currentScene;
    }
}
