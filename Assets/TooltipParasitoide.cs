using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TooltipParasitoide : MonoBehaviour
{
    public Transform PointA;

    public Transform PointB;

    private LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.positionCount = 2;

        lineRenderer.SetPosition(0,PointA.position);
        lineRenderer.SetPosition(1,PointB.position);

    }

    public void setvisible() => gameObject.SetActive(true);
    public void setHide() => gameObject.SetActive(false);
}
