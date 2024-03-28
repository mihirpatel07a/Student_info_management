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

        StudentData GetStudentData();

        [OperationContract]

        Student GetStudent(int id);

        [OperationContract]

        int GetStudentCount();


    }

    [ServiceContract]
    public interface IBranch
    {
        [OperationContract]
        bool InsertBranch(Branch branch);

        [OperationContract]

        bool DeleteBranch(int id);

        [OperationContract]
        bool UpdateBranch(int id, Branch branch);


        [OperationContract]

        int GetBranchCount();

        [OperationContract]

        Branch GetBranch(int id);

        [OperationContract]

        BranchData GetBranchData();


    }



}
