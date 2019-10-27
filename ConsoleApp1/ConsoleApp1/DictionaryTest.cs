namespace System.Collections.Generic
{
    using System.Linq;

    public class DictionaryTest<T, T1>
    {
        /// <summary>
        /// 初始化一個 KeyValuePair 泛型T,泛型T1 的List
        /// </summary>
        private List<KeyValuePair<T, T1>> dicList = new List<KeyValuePair<T, T1>>();

        /// <summary>
        /// 物件本身
        /// </summary>
        /// <param name="t">泛型T</param>
        /// <param name="t1">泛型T1</param>
        /// <returns></returns>
        public List<KeyValuePair<T, T1>> this[T t, T1 t1]
        {
            get
            {
                return dicList;
            }
            set
            {
                dicList = value;
            }
        }

        /// <summary>
        /// 模擬 Dictionary use Key Get Value 
        /// </summary>
        /// <param name="_key"></param>
        /// <returns></returns>
        public T1 this[T _key]
        {
            get
            {
                return dicList.FirstOrDefault(x => x.Key.Equals(_key)).Value;
            }
        }

        /// <summary>
        /// 模擬 Dictionary 的 Add事件 新增物件加入 dicList 的 List
        /// </summary>
        /// <param name="_key"></param>
        /// <param name="_value"></param>
        public void Add(T _key, T1 _value)
        {
            dicList.Add(new KeyValuePair<T, T1>(_key, _value));
        }

    }
}
