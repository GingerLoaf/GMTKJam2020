using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    [SerializeField]
    private IntReference m_maxHealth = null;

    [SerializeField]
    private Slider m_slider = null;

    public void SetHealth(int health)
    {
        m_slider.value = (float)health / (float)m_maxHealth;
    }

}
