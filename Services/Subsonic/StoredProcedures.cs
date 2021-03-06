﻿


  
using System;
using SubSonic;
using SubSonic.Schema;
using SubSonic.DataProviders;
using System.Data;

namespace Yota.DataAccess{
	internal partial class YotaDB{

		public StoredProcedure AddComment(string Comment){
			StoredProcedure sp=new StoredProcedure("AddComment",this.Provider);
			sp.Command.AddParameter("Comment",Comment,DbType.AnsiString,ParameterDirection.Input);
			return sp;
		}
		public StoredProcedure AddCompany(string Name){
			StoredProcedure sp=new StoredProcedure("AddCompany",this.Provider);
			sp.Command.AddParameter("Name",Name,DbType.AnsiString,ParameterDirection.Input);
			return sp;
		}
		public StoredProcedure GetComments(int? companyID){
			StoredProcedure sp=new StoredProcedure("GetComments",this.Provider);
			sp.Command.AddParameter("companyID",companyID,DbType.Int32,ParameterDirection.Input);
			return sp;
		}
		public StoredProcedure GetCompanies(){
			StoredProcedure sp=new StoredProcedure("GetCompanies",this.Provider);
			return sp;
		}
	}
}
 