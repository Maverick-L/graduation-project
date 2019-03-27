using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager 
{
    private AudioClip AudioClip;//音乐文件
    public AudioSource Audio;//音乐播放组件

    private string curMusicName = "";//用来检测播放同样的背景音乐

    public AudioManager()
    {

    }
    /// <summary>
    /// 传入音乐名字播放背景音乐
    /// </summary>
    /// <param name="filename"></param>
    public void PlayBG(string filename)
    {
        if (!filename.Equals(curMusicName)) {
			//Resources/AudioClip/filename
            AudioClip = Resources.Load(Myconts.RSOURCE_AUDIOCLIP_PATH + filename) as AudioClip;//寻找到此文件
            Audio.clip = AudioClip;
            Audio.Play();
            curMusicName = filename;
        }
    }
    /// <summary>
    /// 停止播放背景音乐
    /// </summary>
    public void StopBG()
    {
        Audio.Stop();
        curMusicName = "";
    }

    //传入的是Transform变量的局部声音控制

    public AudioSource Play(AudioClip clip, Transform point, bool loop)
    {
        return Play(clip, point, 1f, 1f, loop);
    }
    /// <summary>
    /// 传入三个值播放音乐
    /// </summary>
    /// <returns></returns>
    public AudioSource Play(AudioClip clip, Transform point, float value, bool loop)
    {
        return Play(clip, point, value, 1f, loop);
    }

    /// <summary>
    /// 音乐创建播放
    /// </summary>
    /// <returns></returns>
    public AudioSource Play(AudioClip clip, Transform point, float value, float pitch, bool loop)
    {
        //创建Gamobject
        GameObject go = new GameObject("Audio" + clip.name);
        go.transform.position = point.position;
        go.transform.parent = point;
        AudioSource audio = go.AddComponent<AudioSource>();
        //创建AudioSourse

        audio.clip = clip;
        audio.loop = loop;
        audio.pitch = pitch;
        audio.volume = value;
        //非循环状态播放完毕后销毁
        if (!loop)
        {
            GameObject.Destroy(go, clip.length);
        }
        return audio;
    }

    //传入的是Vector变量的全局声音控制


    /// <summary>
    /// 传入AudioClip和loop
    /// </summary>
    /// <returns></returns>
    public AudioSource Play(AudioClip clip, bool loop)
    {
        return Play(clip,Vector3.zero,1f,1f,loop);
    }
    public AudioSource Play(AudioClip clip,Vector3 point, bool loop)
    {
        return Play(clip, point, 1f, 1f, loop);
    }
    /// <summary>
    /// 传入三个值播放音乐
    /// </summary>
    /// <returns></returns>
    public AudioSource Play(AudioClip clip, Vector3 point, float value, bool loop)
    {
        return Play(clip, point, value, 1f, loop);
    }

    /// <summary>
    /// 音乐创建播放
    /// </summary>
    /// <returns></returns>
    public AudioSource Play(AudioClip clip, Vector3 point, float value, float pitch, bool loop)
    {
        //创建Gamobject
        GameObject go = new GameObject("Audio" + clip.name);
        go.transform.position = point;
        AudioSource audio= go.AddComponent<AudioSource>();
        //创建AudioSourse

        audio.clip = clip;
        audio.loop = loop;
        audio.pitch = pitch;
        audio.volume = value;
//非循环状态播放完毕后销毁
        if (!loop)
        {
            GameObject.Destroy(go, clip.length);
        }
        return audio;
    }
   
}
