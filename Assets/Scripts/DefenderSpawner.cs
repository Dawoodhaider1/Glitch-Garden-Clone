using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    public Camera myCamera;

    private GameObject DefenderParent;
    private StarDisplay starDisplay;

    void Start()
    {
        DefenderParent = GameObject.Find("Defenders");
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();

        if (!(DefenderParent))
        {
            DefenderParent = new GameObject("Defenders");
        }
    }

    private void OnMouseDown()
    {
        Vector2 rawPosition = MouseClickinWorldPoints();
        Vector2 roundedPosition = SnapToGrid(rawPosition);
        GameObject defender = button.selectedDefender;

        int defenderCost = defender.GetComponent<Defenders>().starCost;
        if (starDisplay.UseStars(defenderCost) == StarDisplay.Status.SUCCESS)
        {
            GameObject NewDefender = Instantiate(defender, roundedPosition, Quaternion.identity) as GameObject;
            NewDefender.transform.parent = DefenderParent.transform;
        }
        else
        {
            Debug.Log("Insufficient Stars to spawn");
        }
    }

    Vector2 SnapToGrid(Vector2 rawWorldPosition)
    {
        float newX = Mathf.RoundToInt(rawWorldPosition.x);
        float newY = Mathf.RoundToInt(rawWorldPosition.y);
        return new Vector2(newX, newY);
    }

    Vector2 MouseClickinWorldPoints()
    {
        float mousepositioninX = Input.mousePosition.x;
        float mousepositioninY = Input.mousePosition.y;
        float distanceFromCamera = 10f;

        Vector3 WeirdTriplet = new Vector3(mousepositioninX, mousepositioninY, distanceFromCamera);
        Vector2 WorldPos = myCamera.ScreenToWorldPoint(WeirdTriplet);
        return WorldPos;
    }
}
