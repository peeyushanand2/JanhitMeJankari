using Grpc.Core;
using UserService; 
public class UserServiceImpl :MyUser.MyUserBase
{
   
    public override Task<UserList> GetUserList(UserRequest request, ServerCallContext context)
    {
        var users = new UserList();
        users.Users.Add(new User { Id = "1", Name = "John Doe", Email = "john@example.com" });
        users.Users.Add(new User { Id = "2", Name = "Jane Doe", Email = "jane@example.com" });

        return Task.FromResult(users);
    }
}
