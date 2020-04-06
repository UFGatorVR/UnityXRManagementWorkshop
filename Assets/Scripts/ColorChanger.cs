using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ColorChanger : MonoBehaviour
{

    public Material grey, pink;

    private MeshRenderer rend;
    private XRGrabInteractable grabInteractable;

    void Awake()
    {
        rend = GetComponent<MeshRenderer>();
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.onActivate.AddListener(SetPink);
        grabInteractable.onDeactivate.AddListener(SetGrey);
    }

    private void SetPink(XRBaseInteractor interactor)
    {
        rend.material = pink;
    }

    private void SetGrey(XRBaseInteractor interactor)
    {
        rend.material = grey;
    }

    private void OnDestroy()
    {
        grabInteractable.onActivate.RemoveListener(SetPink);
        grabInteractable.onDeactivate.RemoveListener(SetGrey);
    }
}
