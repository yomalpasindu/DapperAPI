namespace DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string stroedProcedure, U parameters, string connectionId = "Default");
        Task SaveData<T>(string stroedProcedure, T parameters, string connectionId = "Default");
    }
}