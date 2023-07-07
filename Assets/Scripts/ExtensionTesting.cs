using UnityEngine;

public class ExtensionTesting : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer meshRenderer;
    [SerializeField] private TMPro.TextMeshProUGUI _textMP;

    private void Start()
    {
        //meshRenderer.DOBlendShapeWeight(6, 100, 3f);
        //_textMP.DOCountdown(5, 1, 5).OnComplete(() => _textMP.text = "Start!");

        //_textMP.text = "Delay Starting";
        //DOVirtual.DelayedCall(2f, () => _textMP.text = "Finished!");

        //_textMP.text = "Delay Starting";
        //_textMP.DODelay(2f, "Finished");

    }
}
