//using ApplicationServices.Models.Users;
//using DomainClass.Common;
//using DomainClass.Repository;
//using DomainClass.Users;

namespace ApplicationServices.Services
{
//    public class UserService : IUserServices
//    {
//        // aca hago inyeccion de dependencia, cada vez que cree una interfaz lo haga en base del isurservices 
//        private readonly IUserRepository _userRepository;
//        public UserService(IUserRepository userRepository)
//    {
//        _userRepository= userRepository;
//    }

//    public async Task<int> Register(AddUserDTO user)
//    {
//            var passEncrip = user.Password.Encrypt();

//            user.Password = passEncrip;

//        //var _user = new UserSystem()
//        //{
//        //    Name = user.Name,
//        //    lastName = user.lastName,
//        //    UserName = user.UserName,
//        //    Email = user.Email,
//        //    Mobile = user.Mobile,
//        //    Password = user.Password,
//        //    UserRol = user.UserRol,

//        //};

//        await _userRepository.Insert(user);
//        return await _userRepository.SaveChange();
//    }

//        public Task<int> Register(UserSystem user)
//        {
//            throw new NotImplementedException();
//        }
//    }



    


}
