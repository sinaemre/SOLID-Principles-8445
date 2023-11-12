using _1_SRP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SRP.GoodExample
{
    public class GoodInsertEmployee
    {
        public static void CreateEmployee(Employee employee)
        {
            //String dosyası oluşturur!
            StringBuilder stringBuilder = new StringBuilder();
            try
			{
                #region İşlem 1: Çalışanın özlük bilgilerinin kayıt edilmesi
                stringBuilder.Append(employee.Id);
                stringBuilder.AppendLine();
                stringBuilder.Append(employee.FirstName);
                stringBuilder.AppendLine();
                stringBuilder.Append(employee.LastName);
                stringBuilder.AppendLine();
                stringBuilder.Append(employee.HireDate);
                stringBuilder.AppendLine();
                File.WriteAllText(@"C:\Users\sinaemre.bekar\Desktop\EmployeeDB\EmployeeData.txt", stringBuilder.ToString());
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
