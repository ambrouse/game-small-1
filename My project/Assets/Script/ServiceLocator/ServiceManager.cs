using System;
using System.Collections.Generic;
using UnityEngine;

public class ServiceManager : MonoBehaviour
{
    private static readonly Dictionary<Type, object> services = new();


    public static void Register<T>(T service)
    {
        /*
            Hàm đăng ký một service vào dict.
        */
        

        if (!services.ContainsKey(typeof(T)))
        services.Add(typeof(T), service);
    }


    public static T Get<T>()
    {
        /*
            Hàm gọi service.
        */


        if (services.TryGetValue(typeof(T), out var service))
            return (T)service;
        throw new Exception($"Service not found!");
    }


    public static void Unregister<T>()
    {
        /*
            Hàm xóa service ra khỏi dict.
        */


        if (services.ContainsKey(typeof(T)))
            services.Remove(typeof(T));
    }


    public static void Clear()
    {
        /*
            Hàm xóa toàn bộ service.
        */


        services.Clear();
    }
}
