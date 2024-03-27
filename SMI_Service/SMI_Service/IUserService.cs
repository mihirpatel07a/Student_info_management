using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SMI_Service
{
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        bool Insert(Student student);

        [OperationContract]
        bool Update(int id , Student student);

        [OperationContract]

        bool Delete(int id);

        [OperationContract]
        List<Student> GetStudents();

        [OperationContract]

        StudentData GetStudentData();



    }
}
