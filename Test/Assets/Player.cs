using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // キーボードの状態を取得
        Keyboard kb = Keyboard.current;

        // キーボードが存在しない場合は何もしない
        if (kb == null) return;

        // Dキーが押されている間、右に移動
        if (kb.dKey.isPressed)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        // Aキーが押されている間、左に移動
        if (kb.aKey.isPressed)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}
