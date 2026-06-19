using UnityEngine;
 public class SoundButton : MonoBehaviour
  { 
  public AudioSource fuenteDeAudio; 
  public AudioClip sonidoDelBoton; 
  public void ReproducirSonido() 
  { 
     if (fuenteDeAudio != null && sonidoDelBoton != null) 
     { 
        fuenteDeAudio.PlayOneShot(sonidoDelBoton); 
    } 
} 
}
