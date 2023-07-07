using UnityEngine;
using DG.Tweening;

// Kod Tekrarýný önlemek için kullanýlýr. Ayný zamanda geniþletilebilir metotlardýr.
public static class TweenExtension
{
    // Burada DOTween içine SkinnedMeshRenderer'da kullanýlabilen bir extension kullanýlmýþtýr.
    public static Tween DOBlendShapeWeight(this SkinnedMeshRenderer meshRenderer, int index, float endValue, float duration)
    {
        return DOTween.To(() => meshRenderer.GetBlendShapeWeight(index),
            x => meshRenderer.SetBlendShapeWeight(index, x),
            endValue, duration
            );
    }

    // Burada Tween geri döndürülmesinin sebebi DOTweenin diðer fonksiyonlarýný kullanmak için yapýlýr. 
    public static Tween DOCountdown(this TMPro.TextMeshProUGUI tmp, int startValue, int endValue, float duration)
    {
        return DOVirtual.Int(startValue, endValue, duration, x => tmp.text = x.ToString());
    }

    // Burada direk DOVirtual kullanýlabilirdi. Bunun yerine extension kullanýlmýþtýr. 
    public static Tween DODelay(this TMPro.TextMeshProUGUI tmp, float duration, string value)
    {
        return DOVirtual.DelayedCall(duration, () => tmp.text = value);
    }

}
