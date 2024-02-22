using UnityEngine;

public class QuadMovement : MonoBehaviour {
    public GameObject cube;

    void Update() {
        if (Input.GetMouseButton(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask.GetMask("Quad"))) {
                Vector3 currentCubePosition = cube.transform.position;
                Vector3 newPosition = new Vector3(hit.point.x, currentCubePosition.y, hit.point.z);
                cube.transform.position = newPosition;
            }
        }
    }
}
