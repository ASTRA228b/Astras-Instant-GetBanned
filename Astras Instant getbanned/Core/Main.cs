using UnityEngine;
using GorillaLocomotion;
using Photon.Pun;
using UnityEngine.InputSystem;

namespace AI_GT.Core;

public class Main : MonoBehaviour
{
    private bool isopen = false;
    private Rect H = new(300, 300, 300, 300);
    private float HH = 999f;
    private float WW = 1f;
    private bool spedboost = false;

    private void OnGUI()
    {
        if (isopen)
        {
            H = GUILayout.Window(111111, H, Yes, "Astras Trustable mod");
        }
    }

    private void Update()
    {
        if (Keyboard.current.leftAltKey.wasPressedThisFrame)
        {
            isopen = !isopen;
        }
    }

    private void FixedUpdate()
    {
        SpedBooster();
    }

    private void Yes(int i)
    {
        GUILayout.Label("Sped Booster");
        spedboost = GUILayout.Toggle(spedboost, "Sped boost");
        GUILayout.Label("Only Press this if you want to get banned and hate the game (you get banned for 4 weeks)");
        if (GUILayout.Button("Get banned"))
        {
            GetBanned();
        }
        if (GUILayout.Button("Close"))
        {
            isopen = !isopen;
        }
    }

    private void GetBanned()
    {
       PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
    }

    private void SpedBooster()
    {
        if (spedboost)
        {
            GTPlayer.Instance.maxJumpSpeed = HH;
            GTPlayer.Instance.jumpMultiplier = WW;
        }
    }
}