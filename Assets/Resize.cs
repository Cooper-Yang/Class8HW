using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resize : MonoBehaviour
{
    //work when start the game
    public CanvasScaler cS;
    
    public static Vector2 GetMainGameViewSize()
    {
        System.Type T = System.Type.GetType("UnityEditor.GameView,UnityEditor");
        System.Reflection.MethodInfo GetSizeOfMainGameView = T.GetMethod("GetSizeOfMainGameView",System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
        System.Object Res = GetSizeOfMainGameView.Invoke(null,null);
        return (Vector2)Res;
    }
    private void Awake()
    {
        if (GetMainGameViewSize().x >= 1919)
        {
            cS.matchWidthOrHeight = 0f;
        }
        else if (GetMainGameViewSize().x >= 1124)
        {
            cS.matchWidthOrHeight = .5f;
        }
        else if (GetMainGameViewSize().x >= 749)
        {
            cS.matchWidthOrHeight = 1f;
        }
        print(GetMainGameViewSize().x);
    }
}
