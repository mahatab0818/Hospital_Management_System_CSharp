using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using Hospital_Information_Layer;
using System.Data;
using System.Data.SqlClient;

namespace Hospital_Operation_Layer
{
    public class Operations
    {
        public DBConnection db = new DBConnection();
        public Informations info = new Informations();

        public int insertEmp(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"INSERT INTO [dbo].[Employee]
           ([Name]
           ,[Gender]
           ,[DOB]
           ,[Age]
           ,[Address]
           ,[Phone_No]
           ,[Designation]
           ,[User_Type]
           ,[Password])
     VALUES
           ('"+info.name+"','"+info.gender+"','"+info.dob+"','"+info.age+"','"+info.address+"','"+info.phoneNo+"','"+info.designation+"','"+info.userType+"','"+info.password+"')";
            return db.ExNonQuery(cmd);
        }




        public DataTable login(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT * FROM [dbo].[Employee] WHERE EID='" + info.eid + "' and Password='" + info.password + "'";
            return db.ExReader(cmd);
        }

        public int insertLgdIn(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"INSERT INTO [dbo].[LoggedIn]
           ([UID])
     VALUES
           ('"+info.eid+"')";
            return db.ExNonQuery(cmd);
        }

        public DataTable viewEmployee(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT * FROM [dbo].[Employee]";
            return db.ExReader(cmd);
        }

        public int deleteEmp(int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"DELETE FROM [dbo].[Employee] WHERE EID='"+x+"'";
            return db.ExNonQuery(cmd);
        }

        public DataTable viewSpEmployee(int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT * FROM [dbo].[Employee] WHERE EID='"+x+"'";
            return db.ExReader(cmd);
        }

        public int updateEmp(Informations info, int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE [dbo].[Employee]
   SET [Name] = '"+info.name+"', [Gender] = '"+info.gender+"', [DOB] = '"+info.dob+"', [Age] = '"+info.age+"', [Address] = '"+info.address+"', [Phone_No] = '"+info.phoneNo+"', [Designation] = '"+info.designation+"', [User_Type] = '"+info.userType+"', [Password] = '"+info.password+"' WHERE EID='"+x+"'";
            return db.ExNonQuery(cmd);
        }

        public DataTable selectLgdIn(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT * FROM [dbo].[LoggedIn]";
            return db.ExReader(cmd);
        }

        public int exitLgdIn()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"DELETE FROM [dbo].[LoggedIn]";
            return db.ExNonQuery(cmd);
        }

        public int insertPatient(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"INSERT INTO [dbo].[Patient]
           ([Name]
           ,[Gender]
           ,[DOB]
           ,[Age]
           ,[Address]
           ,[Phone_No])
     VALUES
           ('"+info.name+"', '"+info.gender+"', '"+info.dob+"', '"+info.age+"', '"+info.address+"', '"+info.phoneNo+"')";
            return db.ExNonQuery(cmd);
        }

        public int insertDiagnosis(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"INSERT INTO [dbo].[Diagnosis]
           ([PID]
           ,[EID]
           ,[DStatus]
           ,[Description]
           ,[BillingStatus])
     VALUES
           ('"+info.pid+"', '"+info.eid+"', 'Open', '"+info.description+"', 'Open')";
            return db.ExNonQuery(cmd);
        }

        public DataTable selectPIDfordiag()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT top 1 * FROM [dbo].[Patient] ORDER BY PID Desc;";
            return db.ExReader(cmd);
        }

        public DataTable viewPatient(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT * FROM [dbo].[Patient]";
            return db.ExReader(cmd);
        }

        public int updatePatient(Informations info, int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE [dbo].[Patient]
   SET [Name] = '"+info.name+"', [Gender] = '"+info.gender+"', [DOB] = '"+info.dob+"', [Age] = '"+info.age+"', [Address] = '"+info.address+"', [Phone_No] = '"+info.phoneNo+"' WHERE PID='"+x+"'";
            return db.ExNonQuery(cmd);
        }

        public int updateDiagnosis(Informations info, int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE [dbo].[Diagnosis]
   SET [EID] = '"+info.eid+"', [Description] = '"+info.description+"', [BillingStatus] = '"+info.bstatus+"' WHERE PID='"+x+"' AND DStatus='Open'";
            return db.ExNonQuery(cmd);
        }

        public DataTable viewSpPatient(int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT * FROM [dbo].[Patient] WHERE PID='" + x + "'";
            return db.ExReader(cmd);
        }

        public DataTable viewSpDiagnosis(int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT * FROM [dbo].[Diagnosis] WHERE PID='" + x + "' AND DStatus='Open'";
            return db.ExReader(cmd);
        }

        public int deletePatient(int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"DELETE FROM [dbo].[Patient] WHERE PID='" + x + "'";
            return db.ExNonQuery(cmd);
        }

        public DataTable viewDiagnosis(Informations info, int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT * FROM [dbo].[Diagnosis] WHERE PID='"+x+"'";
            return db.ExReader(cmd);
        }

        public DataTable printBill(Informations info, int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT Diagnosis.DID, Patient.PID, Patient.Name, Patient.Gender, Patient.Age, Patient.Address, Diagnosis.Operation, Diagnosis.Cabin, Diagnosis.Days, Diagnosis.Medicin, Diagnosis.Bill, Diagnosis.BillingStatus FROM [dbo].[Diagnosis], [dbo].[Patient], [dbo].[Employee] WHERE Diagnosis.PID=Patient.PID AND Diagnosis.EID=Employee.EID AND Patient.PID='"+x+"'";
            return db.ExReader(cmd);
        }

        public DataTable viewCurrentPatient(Informations info, int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT Diagnosis.DID, Patient.PID, Patient.Name, Patient.Gender, Patient.Age, Patient.Address, Diagnosis.Operation, Diagnosis.Cabin, Diagnosis.Days, Diagnosis.Medicin FROM [dbo].[Diagnosis], [dbo].[Patient], [dbo].[Employee] WHERE Diagnosis.PID=Patient.PID AND Diagnosis.EID=Employee.EID AND Employee.EID='"+x+"' AND Diagnosis.DStatus='Open'";
            return db.ExReader(cmd);
        }

        public int updateDocDiagnos(Informations info, int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE [dbo].[Diagnosis] SET [DStatus] = '"+info.dstatus+"', [Description] = '"+info.description+"', [Operation] = '"+info.operation+"', [Cabin] = '"+info.cabin+"', [Days] = '"+info.days+"', [Medicin] = '"+info.medicin+"' WHERE DID='"+x+"'";
            return db.ExNonQuery(cmd);
        }

        public DataTable viewSpDocPatient(int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT * FROM [dbo].[Diagnosis] WHERE DID='" + x + "'";
            return db.ExReader(cmd);
        }


        public int updateBill(Informations info, int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE [dbo].[Diagnosis] SET [Bill] = '" + info.bill + "' WHERE PID='" + x + "'";
            return db.ExNonQuery(cmd);
        }

        public DataTable viewDocPaitentDiag(Informations info, int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT Diagnosis.DID, Patient.PID, Patient.Name, Patient.Gender, Patient.Age, Patient.Address, Diagnosis.Operation, Diagnosis.Cabin, Diagnosis.Days, Diagnosis.Medicin FROM [dbo].[Diagnosis], [dbo].[Patient], [dbo].[Employee] WHERE Diagnosis.PID=Patient.PID AND Diagnosis.EID=Employee.EID AND Employee.EID='" + x + "' AND Diagnosis.DStatus='Closed'";
            return db.ExReader(cmd);
        }

        public DataTable checkBillingStatus(Informations info, int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT * FROM [dbo].[Diagnosis] WHERE DID='"+x+"'";
            return db.ExReader(cmd);
        }

        public int billclosing(Informations info, int x)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE [dbo].[Diagnosis] SET [BillingStatus] = 'Closed' WHERE DID='" + x + "'";
            return db.ExNonQuery(cmd);
        }
    }
}

