using UnityEngine;
using UnityEngine.InputSystem;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Player : MonoBehaviour
{
    
    public float speed;
    [SerializeField] private InputActionAsset inputActions;

    private Rigidbody2D rig;
    private Vector2 direction;
    private InputAction moveAction;

    private void Start() 
    {
        rig = GetComponent<Rigidbody2D>();
        if (inputActions == null)
        {
#if UNITY_EDITOR
            string[] guids = AssetDatabase.FindAssets("InputSystem_Actions t:InputActionAsset");
            if (guids.Length > 0)
            {
                string path = AssetDatabase.GUIDToAssetPath(guids[0]);
                inputActions = AssetDatabase.LoadAssetAtPath<InputActionAsset>(path);
            }
#endif
        }
        if (inputActions != null)
        {
            moveAction = inputActions.FindAction("Move");
            if (moveAction != null)
            {
                moveAction.Enable();
            }
            else
            {
                Debug.LogError("Move action not found in InputActionAsset");
            }
        }
        else
        {
            Debug.LogError("InputActionAsset not found");
        }
    }

    private void Update() 
    {
        if (moveAction != null)
        {
            direction = moveAction.ReadValue<Vector2>();
        }
    }

    private void FixedUpdate() 
    {
        rig.MovePosition(rig.position + direction * speed * Time.fixedDeltaTime);
    }
}
