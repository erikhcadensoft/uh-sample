using uh_sample.Models;

namespace uh_sample.Services;

public interface IUserService
{
    List<User> GetAllUsers();

    User GetUserById(Guid userId);

    List<User> CreateUser(User user);

    User UpdateUser(User user);

    bool DeleteUser(User user);
}

public class UserService : IUserService
{
    private List<User> _inMemUsers { get; set; }

    public UserService()
    {
        _inMemUsers = new List<User>
        {
            new User { Email = "erik@johnson.com", FirstName = "Erik", LastName = "Johnson", UserId = Guid.NewGuid() },
            new User { Email = "marcella@johnson.com", FirstName = "Marcella", LastName = "Johnson", UserId = Guid.NewGuid() },
            new User { Email = "ethan@johnson.com", FirstName = "Ethan", LastName = "Johnson", UserId = Guid.NewGuid() },
            new User { Email = "josh@johnson.com", FirstName = "Josh", LastName = "Johnson", UserId = Guid.NewGuid() },
            new User { Email = "roman@johnson.com", FirstName = "Roman", LastName = "Johnson", UserId = Guid.NewGuid() },
        };
    }
    
    public List<User> GetAllUsers()
    {
        return _inMemUsers;
    }

    public User GetUserById(Guid userId)
    {
        try
        {
            var user = _inMemUsers.FirstOrDefault(u => u.UserId == userId);
            if (user.UserId != Guid.Empty)
                return user;
        }
        catch (Exception ex)
        {
            //TODO: log exception to application logging instance
        }
        return null;
    }

    public List<User> CreateUser(User user)
    {
        try
        {
            _inMemUsers.Add(user);
            return _inMemUsers;
        }
        catch (Exception ex)
        {
            //TODO: log exception to application logging instance
        }
        return null;
    }

    public User UpdateUser(User user)
    {
        try
        {
            var userToUpdate = _inMemUsers.FirstOrDefault(u => u.UserId == user.UserId);
            userToUpdate = user;

            return userToUpdate;
        }
        catch (Exception ex)
        {
            //TODO: log exception to application logging instance
        }
        return null;
    }

    public bool DeleteUser(User user)
    {
        try
        {
            var index = _inMemUsers.FindIndex(u => u.UserId == user.UserId);
            _inMemUsers.RemoveAt(index);

            var deletedUser = _inMemUsers.FirstOrDefault(u => u.UserId == user.UserId);
            return deletedUser.UserId == Guid.Empty;
        }
        catch (Exception ex)
        {
            //TODO: log exception to application logging instance
        }
        return false;
    }
}