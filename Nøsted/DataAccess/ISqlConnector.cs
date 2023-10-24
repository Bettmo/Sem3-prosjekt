
using System.Data;

namespace Nøsted.DataAccess;

public class ISqlConnector
{
    public interface IsqlConnector
    {
        IDbConnection GetDbConnection();
    }
}