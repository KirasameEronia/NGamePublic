using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����ģʽ����
/// </summary>
/// �������һ������ĵ���ģʽ��,�̳д������ӵ���޲ι��캯��
/// ����Ϊ������ģʽ�������ڶ��߳���ʹ�á�
public class SingletonBase<T> where T : SingletonBase<T> ,new()
{
    private static T instance = null;
    /// <summary>
    /// ���� <typeparamref name="T"/>�ĵ�������
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
