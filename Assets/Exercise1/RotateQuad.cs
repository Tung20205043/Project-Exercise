using UnityEngine;

public class RotateQuad : MonoBehaviour {
    

    private readonly float rotationSpeed = 3f;
    private Vector3 lastMousePosition;

    void Update() {
        if (Input.GetMouseButton(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask.GetMask("Quad"))) {
                Vector3 targetDirection = hit.point - transform.position;
                float angle = Vector3.Angle(transform.forward, targetDirection);
                Vector3 cross = Vector3.Cross(transform.forward, targetDirection);
                if (cross.y < 0) {
                    angle = -angle;
                }
                transform.Rotate(0f, 0f, -angle * rotationSpeed * Time.deltaTime);
            }
        }
    }
}
