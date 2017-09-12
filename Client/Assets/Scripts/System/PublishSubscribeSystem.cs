using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.Collections;

    public delegate void MyAction();
    public delegate void MyAction<T1>(T1 t1);
    public delegate void MyAction<T1, T2>(T1 t1, T2 t2);
    public delegate void MyAction<T1, T2, T3>(T1 t1, T2 t2, T3 t3);
    public delegate void MyAction<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4);
    public delegate void MyAction<T1, T2, T3, T4, T5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
    public delegate void MyAction<T1, T2, T3, T4, T5, T6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6);
    public delegate void MyAction<T1, T2, T3, T4, T5, T6, T7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7);
    public delegate void MyAction<T1, T2, T3, T4, T5, T6, T7, T8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8);
    public delegate void MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9);
    public delegate void MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10);
    public delegate void MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11);
    public delegate void MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12);
    public delegate void MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13);
    public delegate void MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14);
    public delegate void MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15);
    public delegate void MyAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16);




    public class PublishSubscribeSystem : MonoBehaviour
  {
      // private static PublishSubscribeSystem _instance;
      //public static PublishSubscribeSystem Instance
      //{
      //    get
      //    {
      //        if (null == _instance)
      //        {
      //            GameObject PublishSubscribeSystem = new GameObject();
      //            PublishSubscribeSystem.name = "PublishSubscribeSystem";
      //            _instance = PublishSubscribeSystem.AddComponent<PublishSubscribeSystem>();
      //        }
      //        return _instance;
      //    }

      //}


    private class ReceiptInfo
    {
      public string name_;
      public Delegate delegate_;
      public ReceiptInfo() { }
      public ReceiptInfo(string n, Delegate d)
      {
        name_ = n;
        delegate_ = d;
      }
    }

    public object Subscribe(string ev_name,  MyAction subscriber) { return AddListeners(ev_name, subscriber); }
    public object Subscribe<T0>(string ev_name,  MyAction<T0> subscriber) { return AddListeners(ev_name,subscriber); }
    public object Subscribe<T0, T1>(string ev_name,  MyAction<T0, T1> subscriber) { return AddListeners(ev_name, subscriber); }
    public object Subscribe<T0, T1, T2>(string ev_name,  MyAction<T0, T1, T2> subscriber) { return AddListeners(ev_name, subscriber); }
    public object Subscribe<T0, T1, T2, T3>(string ev_name,  MyAction<T0, T1, T2, T3> subscriber) { return AddListeners(ev_name,subscriber); }
    public object Subscribe<T0, T1, T2, T3, T4>(string ev_name,  MyAction<T0, T1, T2, T3, T4> subscriber) { return AddListeners(ev_name, subscriber); }
    public object Subscribe<T0, T1, T2, T3, T4, T5>(string ev_name,  MyAction<T0, T1, T2, T3, T4, T5> subscriber) { return AddListeners(ev_name, subscriber); }
    public object Subscribe<T0, T1, T2, T3, T4, T5, T6>(string ev_name,  MyAction<T0, T1, T2, T3, T4, T5, T6> subscriber) { return AddListeners(ev_name, subscriber); }
    public object Subscribe<T0, T1, T2, T3, T4, T5, T6, T7>(string ev_name,  MyAction<T0, T1, T2, T3, T4, T5, T6, T7> subscriber) { return AddListeners(ev_name, subscriber); }
    public object Subscribe<T0, T1, T2, T3, T4, T5, T6, T7, T8>(string ev_name,  MyAction<T0, T1, T2, T3, T4, T5, T6, T7, T8> subscriber) { return AddListeners(ev_name, subscriber); }
    public object Subscribe<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(string ev_name,  MyAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> subscriber) { return AddListeners(ev_name, subscriber); }
    public object Subscribe<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string ev_name,  MyAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> subscriber) { return AddListeners(ev_name, subscriber); }
    public object Subscribe<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string ev_name,  MyAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> subscriber) { return AddListeners(ev_name, subscriber); }

    public void RemoveLitener(object receipt)
    {
      ReceiptInfo r = receipt as ReceiptInfo;
      Delegate d;
      if (null != r && listeners_.TryGetValue(r.name_, out d))
      {
          listeners_[r.name_] = Delegate.Remove(d, r.delegate_);
      }

    }

    public void Publish(string ev_name, params object[] parameters)
    {
      try {

        Delegate d;
        string key =ev_name;
        if (listeners_.TryGetValue(key, out d))
        {
          if (null == d) {
              listeners_.Remove(key);
          } else {
            d.DynamicInvoke(parameters);
          }
        }
      } catch (Exception ex) {
          //艹，又没收钱，报错关我鬼事
      }
    }

    private object AddListeners(string ev_name, Delegate d)
    {
      Delegate source;
      string key =ev_name;
      if (listeners_.TryGetValue(key, out source)) {
        if (null != source)
          source = Delegate.Combine(source, d);
        else
          source = d;
      } else {
        source = d;
      }
      listeners_[key] = source;
      return new ReceiptInfo(key, d);
    }

    private Dictionary<string, Delegate> listeners_ = new Dictionary<string, Delegate>();

  }
