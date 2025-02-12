using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Notifications : MonoBehaviour
{

    public static TMP_Text Notiftext;


    private static float timeToLive = 2;

    private static bool NotifAlive = false;


    public void Start(){
        Notiftext = GetComponent<TextMeshProUGUI>();
        Notiftext.text = "";
    }

    public static void CreateNotification(string input){
        
        Notiftext.text = input;
        NotifAlive = true;
        timeToLive = 2;
    }

    public void Update(){
        if(NotifAlive){
        timeToLive -= Time.deltaTime;
        }

        Notiftext.color =  Color.Lerp(Color.red,Color.blue,Mathf.PingPong(Time.time,1));

        if(timeToLive <= 0 && NotifAlive){
            Notiftext.text = "";
            NotifAlive = false;
        }
    }
}
