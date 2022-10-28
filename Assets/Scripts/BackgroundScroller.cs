﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
  void OnTriggerExit2D(Collider2D col) {
      if (col.gameObject.tag == "Player")
        {
          transform.position += 2*Vector3.right * GetComponent<SpriteRenderer>().bounds.size.x;
         }
  }
}
