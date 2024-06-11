using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 单例模式基类
/// </summary>
/// 这个类是一个纯粹的单例模式类,继承此类必须拥有无参构造函数
/// 此类为懒加载模式，请勿在多线程中使用。
public class SingletonBase<T> where T : SingletonBase<T> ,new()
{
    private static T instance = null;
    /// <summary>
    /// 类型 <typeparamref name="T"/>的单例对象
    /// </summary> 
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
            }
            return instance;
        }
    }
}
