using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIHpBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform HpBarData;
    public Slider slider;

    private void FixedUpdate()
    {
        this.UpdateHpBar();
    }

    protected virtual void UpdateHpBar()
    {
        if (this.slider == null) return;
        IHpBarInterface hpBarInterface = this.HpBarData.GetComponent<IHpBarInterface>();
        if (hpBarInterface == null) return;
        this.slider.value = hpBarInterface.HP();
    }
}
