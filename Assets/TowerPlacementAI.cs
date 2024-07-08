using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacementAI : MonoBehaviour
{
    public GameObject towerPrefab; // Assign your tower prefab in the inspector
    public LayerMask groundLayer; // Layer mask to detect ground

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlaceTower();
        }
    }

    void PlaceTower()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayer))
        {
            Vector3 position = hit.point;
            position = new Vector3(Mathf.Round(position.x), position.y, Mathf.Round(position.z));

            Collider[] colliders = Physics.OverlapSphere(position, 0.5f);
            foreach (Collider collider in colliders)
            {
                if (collider.tag == "Tower")
                {
                    Debug.Log("Cannot place tower here!");
                    return;
                }
            }

            GameObject tower = Instantiate(towerPrefab, position, Quaternion.identity);
            tower.tag = "Tower";
        }
    }
}
