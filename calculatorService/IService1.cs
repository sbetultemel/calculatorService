using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace calculatorService
{
    // NOT: "IService1" arabirim adını kodda ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        double add (double num1, double num2);

        [OperationContract]
        double sub(double num1, double num2);

        [OperationContract]
        double multipli(double num1, double num2);

        [OperationContract]
        double divide(double num1, double num2);

    }

}
