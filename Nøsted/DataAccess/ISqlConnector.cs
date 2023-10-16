
using System.Data;

namespace Nøsted.DataAccess;

public class ISqlConnector
{
    public interface ISqlConnector
    {
        IDbConnection GetDbConnection();
    }
}