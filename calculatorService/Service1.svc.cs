using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace calculatorService
{
    // NOT: "Service1" sınıf adını kodda, svc'de ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    // NOT: Bu hizmeti test etmek üzere WCF Test İstemcisi'ni başlatmak için lütfen Çözüm Gezgini'nde Service1.svc'yi veya Service1.svc.cs'yi seçin ve hata ayıklamaya başlayın.
    public class Service1 : IService1
    {
        double IService1.add(double num1, double num2)
        {
            return num1 + num2;
        }
        double IService1.sub(double num1, double num2)
        {
            return num1-num2;
        }
        double IService1.multipli(double num1, double num2)
        {
            return num1 * num2;
        }
        double IService1.divide(double num1, double num2)
        {
            return num1 / num2;
        }


    }
}
