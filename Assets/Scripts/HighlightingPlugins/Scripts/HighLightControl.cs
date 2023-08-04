// Source: CSDN, 2019. Unity3D物体发光插件 [online] Available at: < https://blog.csdn.net/q764424567/article/details/88062295 > [Accessed 17 Apr. 2021].

using UnityEngine;
using System.Collections;

public class HighLightControl : MonoBehaviour
{

    private HighlightableObject m_ho;

    void Start()
    {
        m_ho = GetComponent<HighlightableObject>();
        m_ho.FlashingOn(Color.green, Color.gray, 1f);
    }

}