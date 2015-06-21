using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

    /// <summary>
    /// http://www.atmarkit.co.jp/ait/articles/1501/15/news059_3.html
    /// </summary>

    void OnMouseDown()
    {
        this.gameObject.GetComponent<Detonator>().Explode();
    }
}
