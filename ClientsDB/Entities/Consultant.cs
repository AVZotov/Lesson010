using ClientsDB.BaseClasses_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsDB.Entities
{
    public class Consultant : IWorker
    {
        public bool IsAbleToAddClient() => false;
        public bool IsAbleToEditClient() => true;
        public bool IsAbleToRemoveClient() => false;

        public bool IsAbleToEditName() => false;
        public bool IsAbleToEditPassport() => false;
        public bool IsAbleToEditPhone() => true;

        public bool IsAbleToViewName() => true;
        public bool IsAbleToViewPassport() => false;
        public bool IsAbleToViewPhone() => true;
    }
}
