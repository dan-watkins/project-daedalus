using System;
using Microsoft.AspNetCore.Mvc;
using projectDaedalus.Services;
using projectDaedalus.Models;

namespace projectDaedalus.Controllers;

[Controller]
[Route("api/[controller]")]
public class CharacterController: Controller
{
    private readonly MongoDBService _mongoDBService;
    public CharacterController(MongoDBService mongoDBservice)
    {
        _mongoDBService = mongoDBservice;
    }

    [HttpGet]
    public async Task<List<PlayerCharacter>> Get() {
        return await _mongoDBService.GetAsync();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] PlayerCharacter character) {
        await _mongoDBService.CreateAsync(character);
        return CreatedAtAction(nameof(Get), new { id = character.Id }, character);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AddToCharacter(string id, [FromBody] string characterId) { }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id) { }