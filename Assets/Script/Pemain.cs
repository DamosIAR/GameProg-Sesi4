using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pemain : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator playerAnimator;
    public GameObject rawImageVideo;
    public GantiScene gs;

    void Start(){
        rawImageVideo.SetActive(false);
    }

    public void playerAttack(){
        playerAnimator.SetTrigger("IsAttack");
    }

    public void invokeVideo(){
        Invoke("playVideo", 2.0f);
    }

    public void playVideo(){
        rawImageVideo.SetActive(true);
    }

    
    IEnumerator WaitAndChange(){
        yield return new WaitForSeconds(3.0f);
        gs.gantiscene("Menu");
    }

    public void CallChangeSceneAfterSecond(){
        StartCoroutine("WaitAndChange");
    }

    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
