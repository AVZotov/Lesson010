using ClientsDB.BaseClasses_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsDB.Entities
{
    public class Manager : IWorker
    {
        public bool IsAbleToAddClient() => true;
        public bool IsAbleToEditClient() => true;
        public bool IsAbleToRemoveClient() => true;

        public bool IsAbleToEditName() => true;
        public bool IsAbleToEditPassport() => true;
        public bool IsAbleToEditPhone() => true;

        public bool IsAbleToViewName() => true;
        public bool IsAbleToViewPassport() => true;
        public bool IsAbleToViewPhone() => true;
    }
}
