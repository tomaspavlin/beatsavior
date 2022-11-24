using BildMlue.Application.DTO.Todo;
using BildMlue.Application.Services;
using BildMlue.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BildMlue.API.Controllers;

public class TodoController : ApiController
{
    private readonly CrudService<TodoItem, CreateTodoInDto, UpdateTodoInDto, TodoDetailOutDto, TodoListOutDto> _service;

    public TodoController(
        CrudService<TodoItem, CreateTodoInDto, UpdateTodoInDto, TodoDetailOutDto, TodoListOutDto> service) =>
        _service = service;

    /// <summary>
    /// Get all items
    /// </summary>
    [HttpGet]
    public Task<List<TodoListOutDto>> GetAll() =>
        _service.GetAll();

    /// <summary>
    /// Get item by id
    /// </summary>
    [HttpGet("{id}")]
    public Task<TodoDetailOutDto> GetDetail(Guid id) =>
        _service.GetDetail(id);

    /// <summary>
    /// Create new item
    /// </summary>
    [HttpPost]
    public Task<TodoDetailOutDto> Create(CreateTodoInDto input) =>
        _service.Create(input);

    /// <summary>
    /// Update existing item
    /// </summary>
    [HttpPut("{id}")]
    public Task<TodoDetailOutDto> Update(Guid id, UpdateTodoInDto input) =>
        _service.Update(id, input);

    /// <summary>
    /// Delete item by id
    /// </summary>
    [HttpDelete("{id}")]
    public Task Delete(Guid id) =>
        _service.Delete(id);
}