using System.Collections;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public bool showDlg;
    public string[] dlgText;
    public Vector2 scr;
    public int index, optionsIndex;

    void Start()
    {

    }

    //Code versions of Canvas
    void OnGUI()
    {
        if (showDlg)
        {
            if (scr.x != Screen.width / 16 || scr.y != Screen.height / 9)
            {
                scr.x = Screen.width / 16;
                scr.y = Screen.height / 9;
            }
            //GUI element of type box 
            //new rectangular position and size
            //Pos x, pos y, size x, size y
            //content of box
            GUI.Box(new Rect(0, 6 * scr.y, Screen.width, 3 * scr.y), dlgText[index]);
            //have a box that touches the left edge and goes to the right edge
            //and startds 2/3rds down the screen and is 1/3rd in size
            //finishing at the bottom of the screen
            if (!(index + 1 >= dlgText.Length || index == optionsIndex))
            //index+1 >= dlgText.Length
            //index < dlgText.Length
            {
                if (GUI.Button(new Rect(15 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Next"))
                {
                    index++;
                }
            }
            else if (index == optionsIndex)
            {
                if (GUI.Button(new Rect(13 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Accept"))
                {
                    index++;
                }

                if (GUI.Button(new Rect(14 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Decline"))
                {
                    index = dlgText.Length - 1;
                }
                

                    if (GUI.Button(new Rect(15 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Bye."))
                    {
                        index = 0;
                        showDlg = false;
                        Cursor.lockState = CursorLockMode.Locked;
                        Cursor.visible = false;
                    Movement.canMove = true;

                    }
                
            }
        }
    }
}
