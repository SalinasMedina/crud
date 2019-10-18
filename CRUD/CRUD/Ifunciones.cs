using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CRUD
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "Ifunciones" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface Ifunciones
    {
        [OperationContract]
        void guardar(int a, string b, int c, float d, string e);
        [OperationContract]
        List<string> leer();
        [OperationContract]
        bool modificar(int a, string b, int c, float d, string e);
        [OperationContract]
        bool eliminar(int a);
        [OperationContract]
        string[] buscar(int cla);
    }
}
