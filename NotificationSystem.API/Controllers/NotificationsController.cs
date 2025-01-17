using Microsoft.AspNetCore.Mvc;
using NotificationSystem.Domain.Entities;
using NotificationSystem.Infra.Interfaces;


namespace NotificationSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : ControllerBase
    {
        private readonly IGenericRepository<Notification> _repository;

        public NotificationsController(IGenericRepository<Notification> repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var notification = await _repository.GetByIdAsync(id);
            if (notification == null)
            {
                return NotFound();
            }
            return Ok(notification);
        }

        [HttpPost]
        public IActionResult Create(Notification notification)
        {
            _repository.AddAsync(notification);
            return CreatedAtAction(nameof(GetById), new { id = notification.Id }, notification);
        }
    }
}