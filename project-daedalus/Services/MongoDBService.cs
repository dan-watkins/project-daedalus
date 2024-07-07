using projectDaedalus.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;

namespace projectDaedalus.Services
{
    public class MongoDBService {
    
        private readonly IMongoCollection<PlayerCharacter> _playerCharacterCollection;

    public MongoDBService(IOptions<MongoDBSettings> mongoDBSettings)
    {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _playerCharacterCollection = database.GetCollection<_playerCharacterCollection>(mongoDBSettings.Value.CollectionName);
    }
}
public async Task<List<PlayerCharacter>> GetAsync() { }
public async Task CreateAsync(PlayerCharacter playerCharacter) {
    await _playerCharacterCollection.InsertOneAsync(character);
    return;
}
    public async Task AddToPlayerCharacterAsync(string id, string characterId) { };
    public async Task DeleteAsync(string id) { };
    public async Task<List<PlayerCharacter>> GetAsync()
    {
        return await _playerCharacterCollection.Find(new BsonDocument()).ToListAsync();
    }
}

