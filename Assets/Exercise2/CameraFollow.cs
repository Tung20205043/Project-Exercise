using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    #region Singleton
    public static CameraFollow Instance { get; private set; }

    private void Awake() {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    #endregion

    private float rotateSpeed = 1000f;
    private float minAngle = 68f;
    private float maxAngle = 112f;

    void Start() {

    }

    void Update() {
        if (Input.GetMouseButton(0)) {
            float mouseX = Input.GetAxis("Mouse X");
            Vector3 newRotate = transform.eulerAngles + new Vector3(0, mouseX, 0);
            float clampedY = Mathf.Clamp(newRotate.y, minAngle, maxAngle);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, clampedY, transform.eulerAngles.z);
        }
    }
}
