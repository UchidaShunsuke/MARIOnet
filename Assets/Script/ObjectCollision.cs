using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    [Header("これを踏んだ時のプレイヤーの跳ねる高さ")] public float boundHeight;

    ///<summary>
    ///このオブジェクトをプレイヤーが踏んだかどうか
    /// </summary>
    [HideInInspector]public float playerStepOn;
}
