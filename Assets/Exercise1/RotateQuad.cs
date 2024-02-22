using UnityEngine;

public class RotateQuad : MonoBehaviour {
    #region Singleton
    public static RotateQuad Instance { get; private set; }

    private void Awake() {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    #endregion
    private readonly float rotationSpeed = 3f;
    private Vector3 lastMousePosition;

    void Update() {
        if (Input.GetMouseButton(0)) {
            Vector3 deltaMousePosition = Input.mousePosition - lastMousePosition;
            float angle = deltaMousePosition.x * rotationSpeed;
            transform.Rotate(0f, 0f, -angle);
        }
        lastMousePosition = Input.mousePosition;
    }
}
