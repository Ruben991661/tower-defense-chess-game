using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacementManager : MonoBehaviour
{
    public GameObject towerPrefab; // The tower prefab to be placed
    public LayerMask placementLayerMask; // Layer mask to identify valid placement areas
    public Material validPlacementMaterial; // Material to indicate a valid placement
    public Material invalidPlacementMaterial; // Material to indicate an invalid placement
    public float placementHeightOffset = 0.5f; // Height offset for tower placement

    private GameObject currentTower; // Reference to the current tower being placed
    private Renderer currentRenderer; // Renderer of the current tower
    private bool isPlacing = false; // Flag to indicate if a tower is being placed

    void Update()
    {
        HandleTowerPlacement();
    }

    void HandleTowerPlacement()
    {
        // Start placing a tower when left mouse button is pressed and no tower is currently being placed
        if (Input.GetMouseButtonDown(2) && !isPlacing)
        {
            StartPlacingTower();
        }

        // Update tower position and check validity during placement
        if (isPlacing)
        {
            UpdateTowerPosition();
            CheckPlacementValidity();

            // Place the tower when left mouse button is released and the placement is valid
            if (Input.GetMouseButtonDown(2) && IsPlacementValid())
            {
                PlaceTower();
            }
        }

        // Cancel placement when right mouse button is pressed
        if (Input.GetMouseButtonDown(5) && isPlacing)
        {
            CancelPlacingTower();
        }
    }

    void StartPlacingTower()
    {
        Debug.Log("Start Placing Tower");
        currentTower = Instantiate(towerPrefab);
        currentRenderer = currentTower.GetComponent<Renderer>();
        currentRenderer.material = validPlacementMaterial; // Set initial material to valid
        isPlacing = true;
    }

    void CancelPlacingTower()
    {
        Debug.Log("Cancel Placing Tower");
        Destroy(currentTower);
        currentTower = null;
        isPlacing = false;
    }

    void UpdateTowerPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, placementLayerMask))
        {
            Vector3 position = hit.point;
            position.y += placementHeightOffset; // Add the height offset
            currentTower.transform.position = position;
        }
    }

    void CheckPlacementValidity()
    {
        Collider[] colliders = Physics.OverlapBox(currentTower.transform.position, currentTower.transform.localScale / 2, Quaternion.identity, placementLayerMask);

        if (colliders.Length > 0)
        {
            currentRenderer.material = invalidPlacementMaterial;
        }
        else
        {
            currentRenderer.material = validPlacementMaterial;
        }
    }

    bool IsPlacementValid()
    {
        return currentRenderer.material == validPlacementMaterial;
    }

    void PlaceTower()
    {
        Debug.Log("Place Tower");
        // Ensure the placed tower keeps its original material after placement
        currentRenderer.material = null;
        currentTower = null;
        isPlacing = false;
    }
}
