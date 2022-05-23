using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeFacto.Models
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();

    }
}
