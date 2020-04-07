using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMangement.EF;

//using DataManagement.DataBaseClasses;

namespace DataMangement.Repository
{
    public interface IDbRelation
    {
        Model1 GetAll();

    }
}
