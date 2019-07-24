using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
  /*

        o         o         o   ____o__ __o____   o         o  
       <|>       <|>       <|>   /   \   /   \   <|>       <|> 
       / \       / \       / \        \o/        < >       < > 
     o/   \o     \o/       \o/         |          |         |  
    <|__ __|>     |         |         < >         o__/_ _\__o  
    /       \    < >       < >         |          |         |  
  o/         \o   \         /          o         <o>       <o> 
 /v           v\   o       o          <|          |         |  
/>             <\  <\__ __/>          / \        / \       / \ 




*/
  /*


   o         o                d'b                      
   8         8                8                        
   8 odYo.  o8P .oPYo. oPYo. o8P  .oPYo. .oPYo. .oPYo. 
   8 8' `8   8  8oooo8 8  `'  8   .oooo8 8    ' 8oooo8 
   8 8   8   8  8.     8      8   8    8 8    . 8.     
   8 8   8   8  `Yooo' 8      8   `YooP8 `YooP' `Yooo' 
   ....::..::..::.....:..:::::..:::.....::.....::.....:
   ::::::::::::::::::::::::::::::::::::::::::::::::::::
   ::::::::::::::::::::::::::::::::::::::::::::::::::::

  */
  public interface IAuthRepository
  {
    Task<User> Register(User user, string password);
    Task<User> Login(string username, string password);
    Task<bool> UserExists(string username);
  }
}