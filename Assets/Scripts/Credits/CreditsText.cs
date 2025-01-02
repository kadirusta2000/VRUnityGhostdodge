using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class CreditsText : MonoBehaviour
{
    public TMP_Text textMeshPro;
    string[] creditsText;
    string myFilePath;

    void Start()
    {
        textMeshPro.text = null;
        myFilePath = Application.dataPath + "/Misc/" + "attribution.txt";
        ReadFromApplications();
    }

    public void ReadFromApplications(){
        creditsText = File.ReadAllLines(myFilePath);
        foreach(string line in creditsText){
            if(line.Equals("")){
                textMeshPro.text += "\n";
                print("empty");
            }
            else{
                textMeshPro.text += line;
            }
            print(line);
            }
        
    }
}
