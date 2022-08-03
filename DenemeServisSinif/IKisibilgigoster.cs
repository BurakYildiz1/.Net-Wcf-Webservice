using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;

namespace DenemeServisSinif
{
    [ServiceContract]
    public interface IKisibilgigoster
    {
        [OperationContract]
        DataSet Kisibilgigoster();

    }
}
