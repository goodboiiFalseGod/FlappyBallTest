using System;
using UnityEngine;

public class PlayerInputEvents : MonoBehaviour
{
    public event Action UpPressed;
    public event Action UpReleased;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) UpPressed?.Invoke();
        
        if (Input.GetKeyUp(KeyCode.UpArrow)) UpReleased?.Invoke();
    }
}
