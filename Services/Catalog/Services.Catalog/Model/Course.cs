﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Services.Catalog.Model
{
  public class Course
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    [BsonRepresentation(BsonType.Decimal128)]
    public decimal Price { get; set; }
    public string Picture { get; set; }

    [BsonRepresentation(BsonType.DateTime)]
    public DateTime CreatedTime { get; set; }

    public string UserId { get; set; }
    public Feature Feature { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public string CategoryId { get; set; }
    [BsonIgnore]

    public Category Category { get; set; }


  }
}
