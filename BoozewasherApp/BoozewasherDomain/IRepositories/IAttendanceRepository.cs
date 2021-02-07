using BoozewasherDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.IRepositories
{
    public interface IAttendanceRepository
    {
        void TimeInEmployee(Attendance attendance);
        void TimeOutEmployee(Attendance attendance);
        List<Attendance> GetAttendancesByDate(Attendance attendance);
    }
}
