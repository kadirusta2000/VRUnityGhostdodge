using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Notifications : MonoBehaviour
{

    public TMP_Text Notiftext;


    public void CreateNotification(string input){
        
        Notiftext.text = "help";
        print(input);
    }
}
