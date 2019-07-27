using OfficeMate.Prototype.BusinessLogic.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
// using OfficeMate.BusinessLogic.Services.Interface;

namespace OfficeMate.BusinessLogic.UnitOfWork.Interface
{
    public interface ILogicUnitOfWork
    {
        ITempService TempService { get; set; }
    }
}
