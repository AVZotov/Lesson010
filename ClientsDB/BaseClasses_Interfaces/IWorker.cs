namespace ClientsDB.BaseClasses_Interfaces
{
    public interface IWorker
    {
        public abstract bool IsAbleToAddClient();
        public abstract bool IsAbleToEditClient();
        public abstract bool IsAbleToRemoveClient();

        public abstract bool IsAbleToEditName();
        public abstract bool IsAbleToEditPhone();
        public abstract bool IsAbleToEditPassport();

        public abstract bool IsAbleToViewName();
        public abstract bool IsAbleToViewPhone();
        public abstract bool IsAbleToViewPassport();
    }
}
