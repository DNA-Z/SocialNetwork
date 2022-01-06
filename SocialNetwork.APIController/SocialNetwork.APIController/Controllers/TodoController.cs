//using ApplicationLogic.Commands;
//using MediatR;
//using Microsoft.AspNetCore.Mvc;

//namespace SocialNetwork.APIController.Controllers
//{
//    [ApiController]
//    public class TodoController
//    {
//        private readonly IMediator mediator;
//        public TodoController(IMediator mediator)
//        {
//            this.mediator = mediator;
//        }

//        [HttpGet("/{id}")]
//        public async Task<IActionResult> GetTodoById(int id)
//        {
//            var response = await mediator.Send(new GetTodoById.Command(id));
//            return response == null ? NotFound() : Ok(response);
//        }
//    }
//}
