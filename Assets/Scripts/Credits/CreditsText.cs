using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class CreditsText : MonoBehaviour
{
    public TMP_Text textMeshPro;


    public void howTo(){
        textMeshPro.text =  "The Goal is quite simple: Survive! \nAt least least until your Ghosthunt device has charged up enough \nto fire the Ecto-Flashlight. \nTo do so you need to dodge the ghosts red bullets. \nBut beware!  you need to collect the green plasma shots with the \ndevice or they will hurt you aswell. \nUse the powerups around you to aid your mission by tapping them.";
    }

    public void Credits(){
        textMeshPro.text = "A game by Vivian, Kadir and Mirkan"
        + "\n\n3D Modelling: Burgerboy"
        + "\n\nMusic: From Bensound.com/royalty-free-music"
        + "\n *Main menu theme: Sci Fi by Benjamin Tissot"
        + "\n *Game Theme: Moose by Benjamin Tissot"
        + "\n\nSound Effects: Jes�s Lastra"
        + "\n\nFonts:"
        + "\n *Title: Funky Rundkopf Two - Nicks Fonts"
        + "\n *UI: Zebulon - Pixel Sagas - Neale Davidson"
        + "\n\nImages:"
        + "\n *Cracks: https://www.pngfind.com/download/ibmhwT_png-file-size-cracked-line-png-transparent-png/";
        
    }
}
