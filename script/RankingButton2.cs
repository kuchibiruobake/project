using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RankingButton2 : MonoBehaviour
{
    [SerializeField] GameObject rankingPanel2;
    public void RankingPanel()
    {
        rankingPanel2.SetActive(true);
    }
        public void HideRankingPanel()
    {
        rankingPanel2.SetActive(false);
    }
}
