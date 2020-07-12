using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    [SerializeField]
    private IntReference m_maxHealth = null;

    [SerializeField]
    private IntReference m_currentHealth = null;

    [SerializeField]
    private Slider m_slider = null;

    public void Refresh()
    {
        m_slider.value = (float)m_currentHealth / (float)m_maxHealth;
    }

}
