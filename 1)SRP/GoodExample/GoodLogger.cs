using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SRP.GoodExample
{
    public class GoodLogger
    {
        public static void CreateLog(int id)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                #region İşlem 2: Çalışanın sisteme giriş yapması sonucunda doğan log'ların tutulması
                stringBuilder = new StringBuilder();
                stringBuilder.Append("Kayıt Tarihi: ");
                stringBuilder.Append(DateTime.Now);
                stringBuilder.AppendLine();
                stringBuilder.Append("Çalışan No: ");
                stringBuilder.Append(id);
                File.WriteAllText(@"C:\Users\sinaemre.bekar\Desktop\EmployeeDB\Log.txt", stringBuilder.ToString());
                #endregion
            }
            catch (Exception ex)
            {
                #region İşlem 3: Yukarıdaki süreçlerden herhangi birinin gerçekleşmemesi durumunda alınacak hataların tutulması
                stringBuilder = new StringBuilder();
                stringBuilder.Append(ex.Message);
                stringBuilder.AppendLine();
                stringBuilder.Append(DateTime.Now);
                File.WriteAllText(@"C:\Users\sinaemre.bekar\Desktop\EmployeeDB\Log.txt", stringBuilder.ToString());
                #endregion
            }
        }
    }
}
