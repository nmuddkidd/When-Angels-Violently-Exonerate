using UnityEngine;

public class weaponSwapper : MonoBehaviour
{
    public GameObject pistols;
    public GameObject shotgun;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SwapToShotgun()
    {
        pistols.SetActive(false);
        shotgun.SetActive(true);
    }
      public void SwapToPistols()
    {
        pistols.SetActive(true);
        shotgun.SetActive(false);
    }
}
