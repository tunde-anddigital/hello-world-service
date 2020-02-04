using helloWorldAPI.Models;

namespace helloWorldAPI.Controllers
{
    public interface IGreeter
    {
        HelloWorld Greet();
    }
}