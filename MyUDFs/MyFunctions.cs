using System;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using Excel = Microsoft.Office.Interop.Excel;
using System.Numerics; //referans olarak eklenmeli, ama en güncelini kur nugettan


namespace MyUDFs
{
    [Guid("3ADF6501-4D91-4B40-A374-23946CE29E6D")] //Bu GUID sizde farklı olacak
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class MyFunctions
    {
        #region udfler
        public double Topla(double number1, double number2)
        {
            return number1+number2;
        }

        public int KacKelime(Excel.Range hucre)
        {
            string icerik = hucre.Value.ToString();
            return icerik.Split(' ').Length;
        }
        #endregion

        #region performans_vektor
        //https://habr.com/en/post/467689/
        //klasik yöntem
        public int Naive(int[] dizi)
        {
            int result = 0;
            foreach (int i in dizi)
            {
                result += i;
            }
            return result;
        }

        //LINQ ile
        public long LINQ(int[] dizi)
        {
            return dizi.Aggregate<int, long>(0, (current, i) => current + i);
        }

        //Vector paketi ile
        public int Vectors(int[] dizi)
        {
            int vectorSize = Vector<int>.Count;// the amount of 4-byte numbers we can place in a vector. If hardware acceleration is used, this value shows how many 4-byte numbers we can put in one SIMD register. In fact, it shows how many elements of this type can be handled concurrently;
            //The Vector<T> gives the ability to use longer vectors. The count of a Vector<T> instance is fixed, but its value Vector<T>.Count depends on the CPU of the machine running the code.
            var accVector = Vector<int>.Zero;//vector that accumulates the result of the function;
            int i;
            var array = dizi;
            for (i = 0; i <= array.Length - vectorSize; i += vectorSize)
            {
                var v = new Vector<int>(array, i);//he data from array is loaded into a new v vector, starting from i index. The vectorSize of data will be loaded exactly;
                accVector = Vector.Add(accVector, v);//two vectors are summed.
                /*For example, there are 8 numbers in Array: {0, 1, 2, 3, 4, 5, 6, 7} and vectorSize == 4.
                Then during the first cycle iteration accVector = {0, 0, 0, 0}, v = {0, 1, 2, 3} and after addition accVector will hold: {0, 0, 0, 0} + {0, 1, 2, 3} = {0, 1, 2, 3}.
                During the second iteration v = {4, 5, 6, 7} and after addition accVector = {0, 1, 2, 3} + {4, 5, 6, 7} = {4, 6, 8, 10}.
                 */
            }
            /*Now we just need to get the sum of all vector elements. To do this we can use scalar multiplication by a vector filled with ones: int result = Vector.Dot(accVector, Vector<int>.One);
            Then we get: { 4, 6, 8, 10}
            * { 1, 1, 1, 1} = 4 * 1 + 6 * 1 + 8 * 1 + 10 * 1 = 28.*/
            int result = Vector.Dot(accVector, Vector<int>.One);
            for (; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }
        #endregion

        #region resgitry_ayar
        [ComRegisterFunctionAttribute]
        public static void RegisterFunction(Type type)
        {
            Registry.ClassesRoot.CreateSubKey(GetSubKeyName(type, "Programmable"));
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(GetSubKeyName(type, "InprocServer32"), true);
            key.SetValue("", System.Environment.SystemDirectory + @"\mscoree.dll", RegistryValueKind.String);
        }

        [ComUnregisterFunctionAttribute]
        public static void UnregisterFunction(Type type)
        {
            Registry.ClassesRoot.DeleteSubKey(GetSubKeyName(type, "Programmable"), false);
        }

        private static string GetSubKeyName(Type type, string subKeyName)

        {
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            s.Append(@"CLSID\{");
            s.Append(type.GUID.ToString().ToUpper());
            s.Append(@"}\");
            s.Append(subKeyName);
            return s.ToString();
        }

        public void Register()
        {
            RegisterFunction(typeof(MyFunctions));
        }
        #endregion

        #region gizleme
        //Excel'de fnksiyon listesinde görünmesini istemediğimi fonkisyonları override edelim
        [ComVisible(false)]
        public override string ToString()
        {
            return base.ToString();
        }

        [ComVisible(false)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        [ComVisible(false)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
