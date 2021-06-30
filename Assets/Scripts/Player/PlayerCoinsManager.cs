using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoinsManager : MonoBehaviour
{
    public static int coins;
    public delegate void MoreCoinsDelegate();
    public static MoreCoinsDelegate MoreCoins;
    
}
