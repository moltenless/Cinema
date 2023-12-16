using AutoMapper;
using BLL.DTO;
using BLL.Services.Interfaces;
using CCL.Security;
using CCL.Security.Identity;
using DAL.Entities;
using DAL.UnitOfWork;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Impl
{
    public class SessionService : ISessionService
    {
        private readonly IUnitOfWork _database;
        private int pageSize = 10;
        public SessionService(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            _database = unitOfWork;
        }

        public IEnumerable<SessionDTO> GetSessions()
        {
            var user = SecurityContext.GetUser();
            var userType = user.GetType();
            if (userType != typeof(Director)
            && userType != typeof(Accountant))
            {
                throw new MethodAccessException();
            }
            var sessionsEntities =_database.Sessions.GetAll();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Session, SessionDTO>()).CreateMapper();
            var sessionsDto = mapper.Map<IEnumerable<Session>, List<SessionDTO>>(sessionsEntities);
            return new List<SessionDTO> { new SessionDTO { Session_id = 1, Session_name = "testN" } };
        }
    }
}
