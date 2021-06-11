using Adopt1Dev_V2.ASP.Models;
using Adopt1Dev_V2.ASP.Models.Forms;
using Adopt1Dev_V2.ASP.Services.Interfaces;
using Adopt1Dev_V2.DAL;
using Adopt1Dev_V2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adopt1Dev_V2.ASP.Services
{
    public class RegisterService : IService<UserModel, RegisterForm>
    {
        private readonly DataContext _dc;

        public RegisterService(DataContext dc)
        {
            _dc = dc;
        }

        public UserModel GetByEmailPassword(string email, string password)
        {
            //TODO
            throw new NotImplementedException();
        }

        public UserModel MapToUserModel(User user)
        {
            //TODO
            throw new NotImplementedException();

        }
        public void Insert(RegisterForm form)
        {
            UserModel model = new UserModel()
            {
                Email=form.Email,
                PasswordIn=form.Password
            };

            User entity = new User()
            {
                Email = model.Email,
                Password = model.PasswordOut
            };

            _dc.Users.Add(entity);

            _dc.SaveChanges();

            form.Id = entity.UserId;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public RegisterForm GetById(int id)
        {
            throw new NotImplementedException();
        }


        public void Update(RegisterForm form)
        {
            throw new NotImplementedException();
        }
    }
}
