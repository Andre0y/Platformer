using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    public void OpenYoutubeUrl()
    {
        Application.OpenURL("https://www.youtube.com/channel/UChbwk87aVPaL8w5jnfcaNyA");
    }

    public void OpenGithubUrl()
    {
        Application.OpenURL("https://github.com/Andre0y");
    }
}
