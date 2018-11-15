using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemFramework
{
    public enum EnumType
    {

    }
    public enum LogType
    {
        GENERAL = 1,
        TRANSACTION,
        COMMUNICATION_ETC,
        COMMUNICATION_WIM,
    }

    public enum LogAction
    {
        LOGIN = 1,
        LOGOUT,
        UPDATE,
        DELETE,
        INSERT,
        RECEIVE_COMMAND_FROM_ETC,
        SEND_DATA_TO_ETC,
        SEND_DATA_TO_WIM,
    }


}
