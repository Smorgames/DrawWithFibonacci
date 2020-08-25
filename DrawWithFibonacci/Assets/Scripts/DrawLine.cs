using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    public Transform point;

    public GameObject linePrefab;
    private GameObject currentLine;
    private LineRenderer lineRenderer;
    public List<Vector2> fingerPosition;

    private void Start()
    {
        CreateLine();
    }

    void Update()
    {
        //if(Input.GetMouseButton(0))
        //{
            Vector2 tempFingerPos = point.position;
            if (Vector2.Distance(tempFingerPos, fingerPosition[fingerPosition.Count - 1]) > 0.01f)
            {
                UpdateLine(tempFingerPos);
            }
        //}
    }

    void CreateLine()
    {
        currentLine = Instantiate(linePrefab, transform.position, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        fingerPosition.Clear();
        fingerPosition.Add(point.position);
        fingerPosition.Add(point.position);
        lineRenderer.SetPosition(0, fingerPosition[0]);
        lineRenderer.SetPosition(1, fingerPosition[1]);
    }

    void UpdateLine(Vector2 newFingerPosition)
    {
        fingerPosition.Add(newFingerPosition);
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newFingerPosition);
    }
}
