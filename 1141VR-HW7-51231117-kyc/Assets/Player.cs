using UnityEngine;
using UnityEngine.InputSystem;  // 新輸入系統

public class Player : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 按下左鍵
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            transform.Translate(-3, 0, 0);
        }

        // 按下右鍵
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            transform.Translate(3, 0, 0);
        }
    }
}


